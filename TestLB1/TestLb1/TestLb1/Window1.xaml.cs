using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace TestLb1
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        bool inputCorrect;
        bool textC;
        bool datumC;
        bool radioC;
        bool checkC;

        public Window1()
        {
            InitializeComponent();
            checkError.Visibility = Visibility.Hidden;
            radioError.Visibility = Visibility.Hidden;
            datumError.Visibility = Visibility.Hidden;
            textError.Visibility = Visibility.Hidden;
        }

        private void ValidatorButton_Click(object sender, RoutedEventArgs e)
        {
            Regex regexDatum = new Regex(@"^\d\d\d\d$");

            result.Clear();

            if (Text.Text == "")
            {
                textError.Visibility = Visibility.Visible;
            }
            else
            {
                textError.Visibility = Visibility.Hidden;
                textC = true;
            }

            if (!(Regex.IsMatch(Datum.Text, regexDatum.ToString())))
            {
                datumError.Visibility = Visibility.Visible;
            }
            else
            {
                datumError.Visibility = Visibility.Hidden;
                datumC = true;
            }

            if (r1.IsChecked == false & r2.IsChecked == false)
            {
                radioError.Visibility = Visibility.Visible;
            }
            else
            {
                radioError.Visibility = Visibility.Hidden;
                radioC = true;
            }

            if (c1.IsChecked == false & c2.IsChecked == false & c3.IsChecked == false)
            {
                checkError.Visibility = Visibility.Visible;
            }
            else
            {
                checkError.Visibility = Visibility.Hidden;
                checkC = true;
            }

            if (textC & datumC & radioC & checkC)
            {
                inputCorrect = true;
            }

            if (inputCorrect)
            {
                result.Text += Text.Text + "\n";
                result.Text += Datum.Text + "\n";

                foreach (RadioButton item in Radiobuttonslist.Items)
                {
                    if (item.IsChecked == true)
                    {
                        result.Text += item.Content + " ";
                    }
                }

                result.Text += "\n";

                foreach (CheckBox item in Checkboxlist.Items)
                {
                    if (item.IsChecked == true)
                    {
                        result.Text += item.Content + " ";
                    }
                }

            }
            else
            {
                result.Text = "";
            }
        }
    }
}
