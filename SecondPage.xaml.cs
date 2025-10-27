namespace FitnessApp;

public partial class SecondPage : ContentPage
{
    static int selectedCoachIndex = 9;
    async void OnActionClicked(object sender, EventArgs e)
    {

        //await Navigation.PushAsync(new MainPage());
        Header.Text = selectedCoachIndex.ToString();
    }
    async void PageBack(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }
    async void PageUp(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ThirdPage());

    }
    public SecondPage(int index)
	{
        selectedCoachIndex = index;
        InitializeComponent();
	}
    public SecondPage()
    {
        InitializeComponent();
    }
}