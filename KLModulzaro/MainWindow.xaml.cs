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

namespace KLModulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainModel;
        public MainWindow()
        {
            InitializeComponent();
            mainModel = new MainViewModel();
            DataContext = mainModel;
        }

        private void NewPatientClick(object sender, RoutedEventArgs e)
        {
            mainModel.SelectedPatient = new Patient { Birthday=DateTime.Now};
            DatientDataViewModel model = new DatientDataViewModel { Patient = mainModel.SelectedPatient };
            DatientData window = new DatientData { DataContext = model};
            window.ShowDialog();
            if (window.DialogResult == true)
                mainModel.PatientList.Add(mainModel.SelectedPatient);
        }

        private void PatientClick(object sender, RoutedEventArgs e)
        {
            if(mainModel.SelectedPatient != null)
            {
                DatientDataViewModel model = new DatientDataViewModel { Patient = mainModel.SelectedPatient };
                DatientData window = new DatientData { DataContext = model };
                window.ShowDialog();
            }
           
        }


        

        private void ButtoTreatmentSheetClick(object sender, RoutedEventArgs e)
        {
            TreatmentSheetViewModel model = new TreatmentSheetViewModel { Patient = mainModel.SelectedPatient };
            TreatmentSheet window = new TreatmentSheet { DataContext = model };
            window.ShowDialog();
            if(window.DialogResult==true)
                mainModel.SelectedPatient.TreatmentList.Add(model.NewTreatment);
        }

        private void Querry1(object sender, RoutedEventArgs e)
        {
            var list = mainModel.PatientList.OrderByDescending(x=>x.TreatmentList.Count).ToArray();
            MessageBox.Show(list[0].Name);
        }

        private void Querry2(object sender, RoutedEventArgs e)
        {
            var sum = mainModel.PatientList.Count;
            MessageBox.Show(sum.ToString());
        }
    }
}
