using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabalarForm.Models
{
    public class Arabalar
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int BeygirGucu { get; set; }
        public double MaxHiz { get; set; }
        public  Cekis Cekis { get; set; }
        public double Hizlanma { get; set; }
        public double Agirlik { get; set; }
        public double MotorHacmi { get; set;}
        public ArabaTuru ArabaTuru { get; set; }
        public KapiSayisi KapiSayisi { get; set; }



    }
}
