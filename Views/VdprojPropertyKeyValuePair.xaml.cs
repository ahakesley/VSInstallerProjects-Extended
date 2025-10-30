using System.Windows;
using System.Windows.Controls;

namespace SetupProjectHelper.Views
{
    /// <summary>
    /// Interaction logic for VdprojPropertyKeyValuePair.xaml
    /// </summary>
    public partial class VdprojPropertyKeyValuePair : UserControl
    {
        public VdprojPropertyKeyValuePair()
        {
            InitializeComponent();
        }
        
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(nameof(Label), typeof(string), typeof(VdprojPropertyKeyValuePair), new PropertyMetadata(default(string)));
        
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(nameof(Value), typeof(string), typeof(VdprojPropertyKeyValuePair), new PropertyMetadata(default(string)));


        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }

            set
            {
                SetValue(LabelProperty, value);
            }
        }

        public string Value
        {
            get
            {
                return (string)GetValue(ValueProperty);
            }

            set
            {
                SetValue(ValueProperty, value);
            }
        }
    }
    
}
