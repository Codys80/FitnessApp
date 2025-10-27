namespace FitnessApp;

public partial class ThirdPage : ContentPage
{
    async void PageBack(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new SecondPage());

    }
    async void PageUp(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }
    public ThirdPage()
	{
		InitializeComponent();
	}
}