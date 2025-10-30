using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace SetupProjectHelper.Views
{
    /// <summary>
    /// Interaction logic for AutoPropertyGrid.xaml
    /// </summary>
    public partial class AutoPropertyGrid : UserControl
    {
        public AutoPropertyGrid()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register(nameof(TargetObject), typeof(object), typeof(AutoPropertyGrid),
                new PropertyMetadata(null, OnTargetChanged));

        public object? TargetObject
        {
            get => GetValue(TargetObjectProperty);
            set => SetValue(TargetObjectProperty, value);
        }

        private static void OnTargetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var grid = (AutoPropertyGrid)d;
            grid.GenerateFields();
        }

        private void GenerateFields()
        {
            PART_ItemsControl.Items.Clear();
            if (TargetObject == null)
                return;

            var properties = TargetObject.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var isBrowsable = property.GetCustomAttribute<BrowsableAttribute>();
                if (isBrowsable == null || isBrowsable.Browsable == false)
                    continue;

                var field = new VdprojPropertyKeyValuePair
                {
                    Label = property.Name,
                };

                var binding = new Binding(property.Name)
                {
                    Source = TargetObject,
                    Mode = BindingMode.OneWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };

                field.SetBinding(VdprojPropertyKeyValuePair.ValueProperty, binding);
                PART_ItemsControl.Items.Add(field);
            }
        }
    }
}
