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
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void ResetClicks(object? sender, EventArgs e)
        {
            count = 0;

            CounterBtn.Text = $"Clicked 0 time";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
