namespace FitnessApp;

public partial class SecondPage : ContentPage
{
    static int selectedCoachIndex = 9;
    async void OnActionClicked(object sender, EventArgs e)
    {

        //await Navigation.PushAsync(new MainPage());
        Header.Text = selectedCoachIndex.ToString();
    }
    async void OnActionClicked2(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }
    public SecondPage(int index)
	{
        selectedCoachIndex = index;
        InitializeComponent();
	}
}