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
            float bruto, belasting, netto, uurloon;
            short aantalUren;

            // Declaratie constante     
            const float belastingPercentage = 0.3f;

            // Toekenning aan variabele naam.     
            string naam = employeeTextBox.Text;
            uurloon = float.Parse(hourlyWageTextBox.Text);
            aantalUren = short.Parse(numberOfHoursTextBox.Text);
            // OF: aantalUren = Convert.ToInt16(TxtAantalUren.Text); 

            // Berekening     
            bruto = aantalUren * uurloon;
            belasting = bruto * belastingPercentage;
            netto = bruto - belasting;

            // Afdruk met interpolation string of $-string
            // {variabele naam} om waarde van variabele in string te zetten
            // \r\n is 1 nieuwe regel
            // + om te strings aan elkaar te plakken
            resultTextBox.Text = $"LOONFICHE VAN {naam}\r\n\r\n" +
                $"Aantal gewerkte uren : {aantalUren}\r\n" +
                $"Uurloon : {uurloon:c}\r\n" +
                $"Brutojaarwedde : {bruto:C}\r\n" +
                $"Belasting : {belasting:C} \r\nNettojaarwedde : {netto:c}";
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
