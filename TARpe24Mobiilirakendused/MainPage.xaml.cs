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
            if (count >= 5)
            {
                CounterBtn.BackgroundColor = Colors.Red;
                CounterBtn.TextColor = Colors.White;
                CounterBtn.Text = $"Clicked {count} times";
            }
            if (count >= 10)
            {
                MainImage.IsVisible = false;
                CounterBtn.Text = "Make image visible again!";
            }
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            // Image rotation
            MainImage.Rotation += 15;

            // Reset button random color
            var random = new Random();
            var randomColor = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256)
                );

            ResetBtn.BackgroundColor = randomColor;

            if (MainImage.HorizontalOptions == LayoutOptions.Start)
            {
                MainImage.HorizontalOptions = LayoutOptions.End;
            }
            else
            {
                MainImage.HorizontalOptions = LayoutOptions.Start;
            }
        }

        // Reset button
        private void ResetClicks(object? sender, EventArgs e)
        {
            count = 0;
            CounterBtn.Text = "Click me";

            MainImage.Rotation = 0;
            MainImage.IsVisible = true;

            CounterBtn.BackgroundColor = Colors.DarkMagenta;
            MainImage.HorizontalOptions = LayoutOptions.Center; 
        }
    }
}
