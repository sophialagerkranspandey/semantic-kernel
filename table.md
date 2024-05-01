## Concepts
 
| Kernel - Using [`Kernel`](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/src/SemanticKernel.Abstractions/Kernel.cs) Features |
| -------- | 
| [Building Kernel](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/samples/Concepts/Kernel/BuildingKernel.cs) |
| [Configure Execution Settings](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/samples/Concepts/Kernel/ConfigureExecutionSettings.cs) |
| [Custom AI Service Selector](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/samples/Concepts/Kernel/CustomAIServiceSelector.cs) |
 
| Functions - Invoking [`Method`](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/src/SemanticKernel.Core/Functions/KernelFunctionFromMethod.cs) or [`Prompt`](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/src/SemanticKernel.Core/Functions/KernelFunctionFromPrompt.cs) functions with [`Kernel`](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/src/SemanticKernel.Abstractions/Kernel.cs) |
| -------- |
| [Arguments](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/samples/Concepts/Functions/Arguments.cs) | 

| -------- | -------- | -------- |
| Agents | ComplexChat_NestedShopper.cs <br> Legacy_AgentAuthoring.cs <br> Legacy_AgentCharts.cs <br> Legacy_AgentCollaboration.cs <br> Legacy_AgentDelegation.cs 
<br> Legacy_AgentTools.cs <br> Legacy_Agents.cs <br> Legacy_ChatCompletionAgent.cs <br> MixedChat_Agents.cs <br> OpenAIAssistant_ChartMaker.cs <br>
OpenAIAssistant_CodeInterpreter.cs <br> OpenAIAssistant_Retrieval.cs | 
| AudioToText | OpenAI_AudioToText.cs |
| AutoFunctionCalling | Gemini_FunctionCalling.cs <br> OpenAI_FunctionCalling.cs |
| ChatCompletion | AzureOpenAIWithData_ChatCompletion.cs <br> ChatHistoryAuthorName.cs <br> ChatHistorySerialization.cs <br> Connectors_CustomHttpClient.cs <br>
Connectors_KernelStreaming.cs <br> Connectors_WithMultipleLLMs.cs <br> Google_GeminiChatCompletion.cs <br> Google_GeminiChatCompletionStreaming.cs <br> 
Google_GeminiGetModelResult.cs <br> Google_GeminiVision.cs <br> OpenAI_ChatCompletion.cs <br> OpenAI_ChatCompletionMultipleChoices.cs <br> OpenAI_ChatCompletionStreaming.cs
<br> OpenAI_ChatCompletionStreamingMultipleChoices.cs <br> OpenAI_ChatCompletionWithVision.cs <br> OpenAI_CustomAzureOpenAIClient.cs <br> OpenAI_UsingLogitBias.cs |
| DependencyInjection | HttpClient_Registration.cs  <br> HttpClient_Resiliency.cs  <br> Kernel_Building.cs  <br> Kernel_Injecting.cs |
| Filtering | AutoFunctionInvocationFiltering.cs <br> FunctionInvocationFiltering.cs <br> Legacy_KernelHooks.cs <br> PromptRenderFiltering.cs |
| Functions | Arguments.cs  <br> FunctionResult_Metadata.cs  <br> FunctionResult_StronglyTyped.cs  <br> MethodFunctions.cs  <br> 
MethodFunctions_Advanced.cs <br> MethodFunctions_Types.cs <br> PromptFunctions_Inline.cs <br> PromptFunctions_MultipleArguments.cs |
| ImageToText | HuggingFace_ImageToText.cs |
| Kernel | BuildingKernel.cs <br> ConfigureExecutionSettings.cs <br> CustomAIServiceSelector.cs |
| Local Models | HuggingFace_ChatCompletionWithTGI.cs <br> MultipleProviders_ChatCompletion.cs |
| Memory | HuggingFace_EmbeddingGeneration.cs <br> MemoryStore_CustomReadOnly.cs <br> SemanticTextMemory_Building.cs
TextChunkerUsage.cs <br> TextChunkingAndEmbedding.cs <br> TextMemoryPlugin_GeminiEmbeddingGeneration.cs <br> TextMemoryPlugin_MultipleMemoryStore.cs |
| Planners | FunctionCallStepwisePlanning.cs <br> HandlebarsPlanning.cs |
| Plugins | ApiManifestBasedPlugins.cs <br> ConversationSummaryPlugin.cs <br> CreatePluginFromOpenAI_AzureKeyVault.cs <br>
CreatePluginFromOpenApiSpec_Github.cs <br> CreatePluginFromOpenApiSpec_Jira.cs <br> CustomMutablePlugin.cs <br> DescribeAllPluginsAndFunctions.cs
<br> GroundednessChecks.cs <br> ImportPluginFromGrpc.cs <br> OpenAIPlugins.cs |
|PromptsTemplates | ChatCompletionPrompts.cs <br> ChatWithPrompts.cs <br> MultiplePromptTemplates.cs <br> PromptFunctionsWithChatGPT.cs <br> TemplateLanguage.cs |
| RAG | WithFunctionCallingStepwisePlanner.cs <br> WithPlugins.cs |
| Resources | Agents Folder <br> EnglishRoberta Folder <br> Plugins <br> 22-ai-plugin.json <br> 22-openapi.json <br> 30-system-prompt.txt <br>
30-user-context.txt <br> 30-user-prompt.txt <br> 65-prompt-override.handlebars <br> GenerateStory.yaml <br> GenerateStoryHandlebars.yaml <br> 
chat-gpt-retrieval-plugin-open-api.yaml <br> sample_image.jpg <br> test_audio.wav <br> test_image.jpg <br> travelinfo.txt |
| Search | BingAndGooglePlugins.cs <br> MyAzureAISearchPlugin.cs <br> WebSearchQueriesPlugin.cs |
| TextGeneration | Custom_TextGenerationService.cs <br> HuggingFace_TextGeneration.cs <br> OpenAI_TextGenerationStreaming.cs |
| TextToAudio | OpenAI_TextToAudio.cs |
| TextToImage | OpenAI_TextToImageDalle3.cs |
