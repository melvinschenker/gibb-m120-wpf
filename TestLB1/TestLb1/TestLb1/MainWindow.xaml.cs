using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TestLb1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool inputCorrect = false;
        bool cbInputCorrect;
        bool textInputCorrect;
        bool dateInputCorrect;
        bool rbInputCorrect;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void ValidierenButton_click(object sender, RoutedEventArgs e)
        {
            ValidierungBox.Text = "";
            Regex regexDatum = new Regex(@"^\d\d/\d\d/(19|20)[0-9]{2}$");
            string[] checkBoxContent = new string[3];
            string[] radioButtonsContent = new string[3];

            if (CBItem1.IsChecked == false & CBItem2.IsChecked == false & CBItem3.IsChecked == false)
            {
                CBError.Visibility = Visibility.Visible;
            }
            else { cbInputCorrect = true; CBError.Visibility = Visibility.Hidden; }

            if (TextBox.Text == "" | TextBox.Text == "Feld ist leer")
            {
                TBError.Visibility = Visibility.Visible;
            }
            else { textInputCorrect = true; TBError.Visibility = Visibility.Hidden; }

            if (RBItem1.IsChecked == false & RBItem2.IsChecked == false & RBItem3.IsChecked == false)
            {
                RBError.Visibility = Visibility.Visible;
            }
            else { rbInputCorrect = true; RBError.Visibility = Visibility.Hidden; }

            if (!Regex.IsMatch(DatumBox.Text, regexDatum.ToString()))
            {
                DBError.Visibility = Visibility.Visible;
            }
            else { dateInputCorrect = true; DBError.Visibility = Visibility.Hidden; }

            if (cbInputCorrect & textInputCorrect & rbInputCorrect & dateInputCorrect)
            {
                inputCorrect = true;
            }



            if (inputCorrect)
            {
                foreach (CheckBox item in CheckboxList.Items)
                {
                    int i = 0;
                    if (item.IsChecked == true)
                    {
                        checkBoxContent[i] = item.Content.ToString();
                        i++;

                        for (int j = 0; j < checkBoxContent.Length; j++)
                        {
                            ValidierungBox.Text += checkBoxContent[j] + " ";
                        }
                    }
                }

                ValidierungBox.Text += "\n" + TextBox.Text + "\n";
                ValidierungBox.Text += DatumBox.Text + "\n";

                foreach (RadioButton item in RadioButtonsList.Items)
                {
                    int i = 0;
                    if (item.IsChecked == true)
                    {
                        radioButtonsContent[i] = item.Content.ToString();
                        i++;

                        for (int j = 0; j < radioButtonsContent.Length; j++)
                        {
                            ValidierungBox.Text += radioButtonsContent[j];
                        }
                    }
                }

            }
            else
            {
                ValidierungBox.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "")
            {
                TextBox.Text = "Feld ist leer";
                TextBox.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "Feld ist leer")
            {
                TextBox.Text = "";
                TextBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NewWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 newWindow = new Window1();
            newWindow.Show();
        }
    }
}
