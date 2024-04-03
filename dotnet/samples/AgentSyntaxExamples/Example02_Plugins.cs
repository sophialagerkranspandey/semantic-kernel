﻿// Copyright (c) Microsoft. All rights reserved.
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AgentSyntaxExamples;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Plugins;
using Xunit;
using Xunit.Abstractions;

namespace Examples;

/// <summary>
/// Demonstrate creation of <see cref="ChatCompletionAgent"/> with a <see cref="KernelPlugin"/>,
/// and then eliciting its response to explicit user messages.
/// </summary>
public class Example02_Plugins : BaseTest
{
    [Fact]
    public async Task RunAsync()
    {
        // Define the agent
        ChatCompletionAgent agent =
            new(
                kernel: this.CreateKernelWithChatCompletion(),
                instructions: AgentInventory.HostInstructions,
                name: AgentInventory.HostName)
            {
                ExecutionSettings = new OpenAIPromptExecutionSettings() { ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions }
            };

        // Initialize plugin and add to the agent's Kernel (same as direct Kernel usage).
        KernelPlugin plugin = KernelPluginFactory.CreateFromType<MenuPlugin>();
        agent.Kernel.Plugins.Add(plugin);

        // Create a nexus for agent interaction. For more, see: Example03_Chat.
        var nexus = new TestChat();

        // Respond to user input, invoking functions where appropriate.
        await WriteAgentResponseAsync("Hello");
        await WriteAgentResponseAsync("What is the special soup?");
        await WriteAgentResponseAsync("What is the special drink?");
        await WriteAgentResponseAsync("Thank you");

        // Local function to invoke agent and display the conversation messages.
        async Task WriteAgentResponseAsync(string input)
        {
            await foreach (var content in nexus.InvokeAsync(agent, input))
            {
                this.WriteLine($"# {content.Role} - {content.AuthorName ?? "*"}: '{content.Content}'");
            }
        }
    }

    public Example02_Plugins(ITestOutputHelper output)
        : base(output)
    {
        // Nothing to do...
    }

    /// <summary>
    ///
    /// A basic nexus for the agent example.
    /// </summary>
    /// <remarks>
    /// For further exploration of AgentNexus, see: Example03_Chat.
    /// </remarks>
    private sealed class TestChat : AgentNexus
    {
        public IAsyncEnumerable<ChatMessageContent> InvokeAsync(
            Agent agent,
            string? input = null,
            CancellationToken cancellationToken = default) =>
                base.InvokeAgentAsync(agent, CreateUserMessage(input), cancellationToken);
    }
}
