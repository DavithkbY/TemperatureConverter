using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace View.Views
{
    public partial class TemperatureScaleControl : UserControl
    {
        public TemperatureScaleControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
