namespace Maui_Azure_Translator;

public partial class AboutPage : ContentPage
{
	private const string LinkedInProfileUrl= "https://www.linkedin.com/in/jacek-adamus-840909198/";
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void AuthorLinkedIn_Clicked(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync(LinkedInProfileUrl);
	}
}