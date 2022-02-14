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
            var textBox = this.FindControl<TextBox>("textBox");

            var fahrenheitString = textBox.Text;
            var fahrenheit = double.Parse(fahrenheitString);
            var celsius = (fahrenheit - 32) / 1.8;
            var celsiusString = celsius.ToString();

            textBox.Text = celsiusString;
        }
    }
}
