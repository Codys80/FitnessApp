namespace FitnessApp;

public partial class FourthPage : ContentPage
{
    async void PageBack(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ThirdPage());

    }
    async void PageUp(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }
    public FourthPage()
	{      
        InitializeComponent();
	}
}