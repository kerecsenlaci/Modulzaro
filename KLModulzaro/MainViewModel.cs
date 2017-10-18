using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLModulzaro
{
    class MainViewModel
    {
        public ObservableCollection<Patient> PatientList { get; set; }
        public Patient SelectedPatient { get; set; }

        public MainViewModel()
        {
            PatientList = new ObservableCollection<Patient> {
                new Patient{Name = "Teszt Laci",TAJ="123123123",Birthplace="Kerepestarcsa"},
                new Patient{Name = "Alap Béla",TAJ="123123123",Birthplace="Kerepestarcsa"}
            };
        }


    }
}
