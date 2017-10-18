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
using System.Windows.Shapes;

namespace KLModulzaro
{
    /// <summary>
    /// Interaction logic for TreatmentSheet.xaml
    /// </summary>
    public partial class TreatmentSheet : Window
    {
        public TreatmentSheet()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            TreatmentSheetViewModel model = (TreatmentSheetViewModel)DataContext;
            if (model.Valid())
                DialogResult=true;
        }
    }
}
