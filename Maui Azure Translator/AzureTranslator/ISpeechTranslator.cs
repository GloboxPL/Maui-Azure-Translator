using Microsoft.CognitiveServices.Speech.Translation;

namespace Maui_Azure_Translator.AzureTranslator;

public interface ISpeechTranslator
{
	Task<string> TranslateAsync();
}
