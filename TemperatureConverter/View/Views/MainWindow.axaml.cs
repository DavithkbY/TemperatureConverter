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
            var inputBox = this.FindControl<TextBox>("inputBox");
            inputBox.Text = "You click the button!";
        }
    }
}
