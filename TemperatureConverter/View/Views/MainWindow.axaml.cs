using Avalonia;
using Avalonia.Controls;
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

            slider = this.FindControl<Slider>("slider");
            celsiusTextBox = this.FindControl<TextBox>("celsiusTextBox");
            fahrenheitTextBox = this.FindControl<TextBox>("fahrenheitTextBox");
            kelvinTextBox = this.FindControl<TextBox>("kelvinTextBox");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private Slider slider;
        private TextBox celsiusTextBox;
        private TextBox fahrenheitTextBox;
        private TextBox kelvinTextBox;

        private void SliderChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
            if (slider != null)
            {
                var kelvin = slider.Value;
                var celsius = kelvin - 273.15;
                var fahrenheit = celsius * 1.8 + 32;

                var kelvinString = kelvin.ToString();
                var fahrenheitString = fahrenheit.ToString();
                var celsiusString = celsius.ToString();

                kelvinTextBox.Text = kelvinString;
                fahrenheitTextBox.Text = fahrenheitString;
                celsiusTextBox.Text = celsiusString;
            }
        }
    }
}
