using Maui_Azure_Translator.AzureTranslator;

namespace Maui_Azure_Translator;

public partial class TranslationPage : ContentPage
{
	//private readonly Translator translator = new(PredefinedLanguageSettings.Polish, PredefinedLanguageSettings.EnglishUK);
	public TranslationPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		var speechSynthesis = new SpeechSynthesis(PredefinedLanguageSettings.EnglishUK);
		label1.Text += "XD";// await translator.TranslateAsync();
		await speechSynthesis.SpeakAsync("Yes, please.");
		//await speechSynthesis.SpeakAsync("No, not today, maybe tomorrow.");
	}
}