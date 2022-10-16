namespace Maui_Azure_Translator.AzureTranslator;

public class Translator
{
	private readonly ISpeechTranslator _speechTranslator;
	private readonly ISpeechSynthesis _speechSynthesis;

	public bool IsTranslationSpeaked { get; set; } = true;

	public Translator(LanguageSettings source, LanguageSettings target)
	{
		_speechTranslator = new SpeechTranslator(source, target);
		_speechSynthesis = new SpeechSynthesis(target);
	}

	public async Task<string> TranslateAsync()
	{
		var translation = await _speechTranslator.TranslateAsync();
		await SpeakAsync(translation);
		return translation;
	}

	private async Task SpeakAsync(string translation)
	{
		if (!IsTranslationSpeaked) return;
		await _speechSynthesis.SpeakAsync(translation);
	}
}
