using Microsoft.CognitiveServices.Speech;

namespace Maui_Azure_Translator.AzureTranslator;

public class SpeechSynthesis : ISpeechSynthesis
{
	private readonly SpeechConfig _speechConfig;

	public SpeechSynthesis(LanguageSettings languageSettings)
	{
		_speechConfig = SpeechConfig.FromSubscription(TempKeys.Key, TempKeys.Region);
		_speechConfig.SpeechRecognitionLanguage = languageSettings.Locale;
		_speechConfig.SpeechSynthesisVoiceName = languageSettings.VoiceName;
	}

	public async Task SpeakAsync(string text)
	{
		using var synthesizer = new SpeechSynthesizer(_speechConfig);
		using var result =await synthesizer.SpeakTextAsync(text);
		var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
	}
}
