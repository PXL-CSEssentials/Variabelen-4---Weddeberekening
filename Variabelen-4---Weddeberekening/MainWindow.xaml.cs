using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Variabelen_4___Weddeberekening
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Declaratie van variabelen     
            float gross;
            float tax;
            float net;
            float hourlyWage;
            short numberOfHours;

            // Declaratie constante     
            const float TaxPercentage = 0.3f;

            // Toekenning aan variabele naam.     
            string name = employeeTextBox.Text;
            hourlyWage = float.Parse(hourlyWageTextBox.Text);
            numberOfHours = short.Parse(numberOfHoursTextBox.Text);
            // OF: aantalUren = Convert.ToInt16(TxtAantalUren.Text); 

            // Berekening     
            gross = numberOfHours * hourlyWage;
            tax = gross * TaxPercentage;
            net = gross - tax;

            // Afdruk met interpolation string of $-string
            // {variabele naam} om waarde van variabele in string te zetten
            // \r\n is 1 nieuwe regel
            // + om te strings aan elkaar te plakken
            resultTextBox.Text = $"LOONFICHE VAN {name}\r\n\r\n" +
                $"Aantal gewerkte uren : {numberOfHours}\r\n" +
                $"Uurloon : {hourlyWage:c}\r\n" +
                $"Brutojaarwedde : {gross:C}\r\n" +
                $"Belasting : {tax:C} \r\nNettojaarwedde : {net:c}";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            employeeTextBox.Clear();
            numberOfHoursTextBox.Text = "0";
            hourlyWageTextBox.Text = "0";
            resultTextBox.Text = string.Empty;

            employeeTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
