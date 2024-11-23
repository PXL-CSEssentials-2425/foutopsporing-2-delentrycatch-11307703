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

namespace Oefening2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            numberTextBox.Focus();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            DelenTryCatch();
           
        }

        private void DelenTryCatch()
        {

            try
            {
                int result = int.Parse(numberTextBox.Text) / int.Parse(dividerTextBox.Text);
                resultTextBox.Text = result.ToString();

                if(int.Parse(numberTextBox.Text) > int.MaxValue)
                {
                    throw new OverflowException();
                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("De deler mag niet 0 zijn", "Fout bij deling",MessageBoxButton.OK);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Je moet 2 gehele getallen ingeven.\n\nDe indeling van de invoertekens is onjuist", "Conversiefout bij DELER/DEELTAL", MessageBoxButton.OK);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("DEELTAL is te groot!", "Conversiefout",MessageBoxButton.OK);
            }
        }
    }
}