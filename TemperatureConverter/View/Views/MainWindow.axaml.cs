using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace View.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var celsiusTextBox = this.FindControl<TextBox>("celsiusTextBox");
            var fahrenheitTextBox = this.FindControl<TextBox>("fahrenheitTextBox");

            var fahrenheitString = fahrenheitTextBox.Text;
            var fahrenheit = double.Parse(fahrenheitString);
            var celsius = (fahrenheit - 32) / 1.8;
            var celsiusString = celsius.ToString();

            celsiusTextBox.Text = celsiusString;
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var celsiusTextBox = this.FindControl<TextBox>("celsiusTextBox");
            var fahrenheitTextBox = this.FindControl<TextBox>("fahrenheitTextBox");

            var celsiusString = celsiusTextBox.Text;
            var celsius = double.Parse(celsiusString);
            var fahrenheit = celsius * 1.8 + 32;
            var fahrenheitString = fahrenheit.ToString();

            fahrenheitTextBox.Text = fahrenheitString;
        }
    }
}
