using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Microsoft.CognitiveServices.Speech.Translation;

namespace Maui_Azure_Translator.AzureTranslator;

public class SpeechTranslator : ISpeechTranslator
{
	private readonly SpeechTranslationConfig _translationConfig;

	public SpeechTranslator(LanguageSettings source, LanguageSettings target)
	{
		_translationConfig = SpeechTranslationConfig.FromSubscription(TempKeys.Key, TempKeys.Region);
		_translationConfig.SpeechRecognitionLanguage = source.Locale;
		_translationConfig.AddTargetLanguage(target.Language);
	}

	public async Task<string> TranslateAsync()
	{
		using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
		using var recognizer = new TranslationRecognizer(_translationConfig, audioConfig);
		var result = await recognizer.RecognizeOnceAsync();
		return result.Translations[_translationConfig.TargetLanguages.First()];
	}
}


