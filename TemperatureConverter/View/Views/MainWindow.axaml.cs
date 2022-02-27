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

        private void ConvertToCelcius(object sender,RoutedEventArgs e)
        {
            var outputBox = this.FindControl<TextBox>("inputBoxCelcius");
            var inputBox = this.FindControl<TextBox>("inputBoxFahrenheit");
            var inputText = inputBox.Text;
            var fahrenheit = double.Parse(inputText);
            var celcius = (fahrenheit-32)/1.8;
            outputBox.Text = celcius.ToString();

        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var outputBox = this.FindControl<TextBox>("inputBoxFahrenheit");
            var inputBox = this.FindControl<TextBox>("inputBoxCelcius");
            var inputText = inputBox.Text;
            var celcius = double.Parse(inputText);
            var fahrenheit = (celcius *1.8) * 1.8;
            outputBox.Text = fahrenheit.ToString();

        }
    }
}
