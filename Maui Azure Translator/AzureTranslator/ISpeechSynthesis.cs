namespace Maui_Azure_Translator.AzureTranslator;

public interface ISpeechSynthesis
{
	Task SpeakAsync(string text);
}
