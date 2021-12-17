using ArabalarForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabalarForm
{
    public partial class Form1 : Form
    {
        private Arabalar arabalar;

        public Form1()
        {
            InitializeComponent();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            arabalar = new Arabalar()
            {
                ID = 1,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                KapiSayisi = (KapiSayisi)ddlkapiSayisi.SelectedIndex,
                BeygirGucu = Convert.ToInt32(nudHp.Value),
                ArabaTuru = (ArabaTuru)ddlArabaTuru.SelectedIndex,
                MaxHiz = Convert.ToDouble(tbMaxHiz.Text),
                Cekis = (Cekis)ddlCekis.SelectedIndex,
                Hizlanma = Convert.ToDouble(tbHizlanma.Text),
                Agirlik = Convert.ToDouble(tbAgirlik.Text),
                MotorHacmi = Convert.ToDouble(tbMotorHacmi.Text)
            };
            MessageBox.Show("Arabanız Oluşturuldu. ");
        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            string result = "";
            result += "ID: " + arabalar.ID + "\n";
            result += "Marka: " + arabalar.Marka + "\n";
            result += "Model: " + arabalar.Model + "\n";
            result += "Kapı Sayısı: " + arabalar.KapiSayisi + "\n";
            result += "Beygir Gücü: " + arabalar.BeygirGucu + "\n";
            result += "Araba Gücü: " + arabalar.ArabaTuru + "\n";
            result += "Max Hız: " + arabalar.MaxHiz + "\n";
            result += "Çekiş: " + arabalar.Cekis + "\n";
            result += "Hızlanma (saniye): " + arabalar.Hizlanma + "\n";
            result += "Ağırlık (kg): " + arabalar.Agirlik + "\n";
            result += "Motor Hacmi (cm3): " + arabalar.MotorHacmi + "\n";
            MessageBox.Show(result);
        }
        
    }
}
