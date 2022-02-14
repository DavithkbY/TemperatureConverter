using Avalonia;
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

        public string Header
        {
            get { return GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly StyledProperty<string> HeaderProperty = AvaloniaProperty.Register<TemperatureScaleControl, string>("Header");
    }
}
