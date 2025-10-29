namespace FitnessApp;

public partial class FifthPage : ContentPage
{
    async void PageBack(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FourthPage());

    }
    async void PageUp(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }
    public FifthPage()
    {
        InitializeComponent();
    }
}