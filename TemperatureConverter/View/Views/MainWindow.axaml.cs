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

            celsiusTextBox = this.FindControl<TextBox>("celsiusTextBox");
            fahrenheitTextBox = this.FindControl<TextBox>("fahrenheitTextBox");
            kelvinTextBox = this.FindControl<TextBox>("kelvinTextBox");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private TextBox celsiusTextBox;
        private TextBox fahrenheitTextBox;
        private TextBox kelvinTextBox;

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var fahrenheitString = fahrenheitTextBox.Text;
            var fahrenheit = double.Parse(fahrenheitString);
            var celsius = (fahrenheit - 32) / 1.8;
            var kelvin = celsius + 273.15;
            var celsiusString = celsius.ToString();
            var kelvinString = kelvin.ToString();

            celsiusTextBox.Text = celsiusString;
            kelvinTextBox.Text = kelvinString;
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var celsiusString = celsiusTextBox.Text;
            var celsius = double.Parse(celsiusString);
            var fahrenheit = celsius * 1.8 + 32;
            var kelvin = celsius + 273.15;
            var fahrenheitString = fahrenheit.ToString();
            var kelvinString = kelvin.ToString();

            fahrenheitTextBox.Text = fahrenheitString;
            kelvinTextBox.Text = kelvinString;
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var kelvinString = kelvinTextBox.Text;
            var kelvin = double.Parse(kelvinString);
            var celsius = kelvin - 273.15;
            var fahrenheit = celsius * 1.8 + 32;
            var fahrenheitString = fahrenheit.ToString();
            var celsiusString = celsius.ToString();

            fahrenheitTextBox.Text = fahrenheitString;
            celsiusTextBox.Text = celsiusString;
        }
    }
}
