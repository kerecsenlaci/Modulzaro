using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLModulzaro
{
    class Patient
    {
        public string Name{ get; set; }
        public string Birthplace { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; }


        public string TAJ { get; set; }
        public List<Treatment> TreatmentList { get; set; }
        public Patient()
        {
            TreatmentList = new List<Treatment>();
        }

    }
}
