using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KLModulzaro
{
    /// <summary>
    /// Interaction logic for DatientData.xaml
    /// </summary>
    public partial class DatientData : Window
    {
        public DatientData()
        {
            InitializeComponent();
        }

        private void TAJPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {
            DatientDataViewModel model = (DatientDataViewModel)DataContext;
            if (model.Validate())
            {
                DialogResult = true;
                return;
            }
                
            MessageBox.Show("Hibás adatbevitel!");
        }
    }
}
