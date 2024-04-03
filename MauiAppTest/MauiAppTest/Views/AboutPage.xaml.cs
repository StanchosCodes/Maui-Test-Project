namespace MauiAppTest.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void SearchMore_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is Models.About about)
		{
			await Launcher.Default.OpenAsync(about.GoogleUrl);
		}
	}
}