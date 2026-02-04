namespace TARpe24Mobiilirakendused
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            // Counter
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            // Image rotation
            MainImage.Rotation += 15;
        }

        // Reset button
        private void ResetClicks(object? sender, EventArgs e)
        {
            count = 0;
            CounterBtn.Text = "Click me";

            MainImage.Rotation = 0;
        }
    }
}
