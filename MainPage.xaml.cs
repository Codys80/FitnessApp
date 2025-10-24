namespace FitnessApp
{
    public partial class MainPage : ContentPage
    {
        static protected int selectedCoachIndex = 0;

        async void CoachSelected(object sender, EventArgs e)
        {
            selectedCoachIndex = Int32.Parse(((Button)sender).ClassId);
            await Navigation.PushAsync(new SecondPage(selectedCoachIndex));
        }

        //async void OnActionClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SecondPage(selectedCoachIndex));
        //}
        public MainPage()
        {
            InitializeComponent();
        }
    }

}
