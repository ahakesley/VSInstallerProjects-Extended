using System.Windows;
using System.Windows.Input;
using SetupProjectHelper.ViewModels;

namespace SetupProjectHelper.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ((ViewModel)DataContext).OpenFileEntryPropertiesCommand.Execute();
        }
    }
}