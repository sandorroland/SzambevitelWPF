using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzambevitelWPF
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

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            HozzadPanel.Children.Clear();
            if (!int.TryParse(tbxBevitel.Text, out int number))
            {
                MessageBox.Show("Nem megfelelő számformátum", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            for (int i = 1; i <= number; i++)
            {
                CheckBox newCheckBox = new CheckBox
                {

                    Width = 50,
                    Height = 30,
                    Margin = new Thickness(0, 5, 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left
                };
                HozzadPanel.Children.Add(newCheckBox);
            }
        }

        private void rbnJelolt_Click(object sender, RoutedEventArgs e)
        {
            bool isChecked = (sender as RadioButton)?.IsChecked == true;

            foreach (var hozzaad in HozzadPanel.Children)
            {
                if (hozzaad is CheckBox checkBox)
                {
                    checkBox.IsChecked = isChecked;
                }
            }
        
        }

        private void rbnNemJelolt_Click(object sender, RoutedEventArgs e)
        {
            bool isChecked = (sender as RadioButton)?.IsChecked == false;
            foreach (var nemadhozza in HozzadPanel.Children)
            {
                if (nemadhozza is CheckBox checkBox)
                {
                    checkBox.IsChecked = isChecked;
                }
            }
        }
    }
}