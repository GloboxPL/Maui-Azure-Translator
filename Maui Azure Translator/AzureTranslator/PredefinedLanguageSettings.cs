namespace Maui_Azure_Translator.AzureTranslator;

public static class PredefinedLanguageSettings
{
	public static readonly LanguageSettings Polish = new("pl", "pl-PL", "pl-PL-AgnieszkaNeural");
	public static readonly LanguageSettings EnglishUK = new("en", "en-GB", "en-GB-BellaNeural");
	public static readonly LanguageSettings Italian = new("it", "it-IT", "it-IT-ElsaNeural");
}