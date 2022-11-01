using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaryakıtOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EklenenBenzin95 = Convert.ToDouble(dtbx1.Text);
                if (1000 < DepoBenzin95 + EklenenBenzin95 || EklenenBenzin95 <= 0)
                    dtbx1.Text = "Hata!";
                else
                    DepoBilgileri[0] = Convert.ToString(DepoBenzin95 + EklenenBenzin95);

            }
            catch (Exception)
            {

                dtbx1.Text = "Hata!";
            }
            try
            {
                EklenenBenzin97 = Convert.ToDouble(dtbx2.Text);
                if (1000 < DepoBenzin97 + EklenenBenzin97 || EklenenBenzin97 <= 0) 
                dtbx2.Text = "Hata!";
                else
                DepoBilgileri[1] = Convert.ToString(DepoBenzin97 + EklenenBenzin97);
            }
            catch (Exception)
            {

                dtbx2.Text = "Hata!";
            }
            try
            {
                EklenenDizel = Convert.ToDouble(dtbx3.Text);
                if (1000 < DepoDizel + EklenenDizel || EklenenDizel <= 0)
                    dtbx3.Text = "Hata!";
                else
                    DepoBilgileri[2] = Convert.ToString(DepoDizel + EklenenDizel);

            }
            catch (Exception)
            {

                dtbx3.Text = "Hata!";
            }
            try
            {
                EkleneEuroDizel = Convert.ToDouble(dtbx4.Text);
                if (1000 < DepoEuroDizel + EkleneEuroDizel || EkleneEuroDizel <= 0)
                    dtbx4.Text = "Hata!";
                else
                    DepoBilgileri[3] = Convert.ToString(EkleneEuroDizel + DepoEuroDizel);

            }
            catch (Exception)
            {

                dtbx4.Text = "Hata!";
            }
            try
            {
                EklenenLpg = Convert.ToDouble(dtbx5.Text);
                if (1000 < DepoLpg + EklenenLpg || EklenenLpg <= 0)
                    dtbx5.Text = "Hata!";
                else;
                DepoBilgileri[4] = Convert.ToString(EklenenLpg + DepoLpg);
            }
            catch (Exception)
            {

                dtbx5.Text = "Hata!";
            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt.txt", DepoBilgileri);
            TxtDepoOku();
            TxtDepoYaz();
            ProgresBarGuncelle();
            NumericUpDownValue();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void lebel6_Click(object sender, EventArgs e)
        {

        }
        
        private void fiyatbutton_Click(object sender, EventArgs e)
        {
            try
            {
                FiyatBenzin95 = FiyatBenzin95 + (FiyatBenzin95 * Convert.ToDouble
                    (ftbx1.Text) / 100);
                FiyatBilgileri[0] = Convert.ToString(FiyatBenzin95);
            }
            catch (Exception)
            {

                ftbx1.Text = "Hata!";
            }
            try
            {
                FiyatBenzin97 = FiyatBenzin97 + (FiyatBenzin97 * Convert.ToDouble
                    (ftbx2.Text) / 100);
                FiyatBilgileri[1] = Convert.ToString(FiyatBenzin97);

            }
            catch (Exception)
            {
                ftbx2.Text = "Hata!";
            }
            try
            {
                FiyatDizel = FiyatDizel + (FiyatDizel * Convert.ToDouble(ftbx3.Text) / 100);
                FiyatBilgileri[3] = Convert.ToString(FiyatDizel);
            }
            catch (Exception)
            {

                ftbx3.Text = "Hata!";
            }
            try
            {
                FiyatEuroDizel = FiyatEuroDizel + (FiyatEuroDizel * Convert.ToDouble(ftbx4.Text) / 100);
                FiyatBilgileri[3] = Convert.ToString(FiyatEuroDizel);
            }
            catch (Exception)
            {

                ftbx4.Text = "Hata!";
            }
            try

            {
                FiyatLpg = FiyatLpg + (FiyatLpg * Convert.ToDouble(ftbx5.Text) / 100);
                FiyatBilgileri[4] = Convert.ToString(FiyatLpg);
            }
            catch (Exception)
            {

                ftbx5.Text = "Hata!";
            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\Fiyat.txt.txt", FiyatBilgileri);
            TxtFiyatOku();
            TxtFiyatYaz();
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Benzin 95")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Benzin 97")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Euro Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }
            else if (comboBox1.Text == "Lpg")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            tlbl1.Text = "_______";
        }
        double DepoBenzin95 = 0, DepoBenzin97 = 0, DepoDizel = 0, DepoEuroDizel = 0, DepoLpg = 0;
        double EklenenBenzin95 = 0, EklenenBenzin97 = 0, EklenenDizel = 0, EkleneEuroDizel = 0, EklenenLpg = 0;
        double FiyatBenzin95 = 0, FiyatBenzin97 = 0, FiyatDizel = 0, FiyatEuroDizel = 0, FiyatLpg = 0;
        double SatisBenzin95 = 0, SatisBenzin97 = 0, SatisDizel = 0, SatisEuroDizel = 0, SatisLpg = 0;
        private void satisbutton_Click(object sender, EventArgs e)
        {
            SatisBenzin95 = double.Parse(numericUpDown1.Value.ToString());
            SatisBenzin97 = double.Parse(numericUpDown2.Value.ToString());
            SatisDizel = double.Parse(numericUpDown3.Value.ToString());
            SatisEuroDizel = double.Parse(numericUpDown4.Value.ToString());
            SatisLpg = double.Parse(numericUpDown5.Value.ToString());

            if (numericUpDown1.Enabled == true)
            {
                DepoBenzin95 = DepoBenzin95 - SatisBenzin95;
                tlbl1.Text = Convert.ToString(SatisBenzin95 * FiyatBenzin95);
            }
            else if (numericUpDown2.Enabled == true)
            {
                DepoBenzin97 = DepoBenzin97 - SatisBenzin97;
                tlbl1.Text = Convert.ToString(SatisBenzin97 * FiyatBenzin97);
            }
            else if (numericUpDown3.Enabled == true)
            {
                DepoDizel = DepoDizel - SatisDizel;
                tlbl1.Text = Convert.ToString(SatisDizel * FiyatDizel);
            }
            else if (numericUpDown4.Enabled == true)
            {
                DepoEuroDizel = DepoEuroDizel - SatisEuroDizel;
                tlbl1.Text = Convert.ToString(SatisEuroDizel * FiyatEuroDizel);
            }
            else if (numericUpDown5.Enabled == true)
            {
                DepoLpg = DepoLpg - SatisLpg;
                tlbl1.Text = Convert.ToString(SatisLpg * FiyatLpg);
            }

            DepoBilgileri[0] = Convert.ToString(DepoBenzin95);
            DepoBilgileri[1] = Convert.ToString(DepoBenzin97);
            DepoBilgileri[2] = Convert.ToString(DepoDizel);
            DepoBilgileri[3] = Convert.ToString(DepoEuroDizel);
            DepoBilgileri[4] = Convert.ToString(DepoLpg);
            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt.txt", DepoBilgileri);

            TxtDepoYaz();
            TxtDepoOku();
            ProgresBarGuncelle();
            NumericUpDownValue();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;


        }


        string[] DepoBilgileri;
        string[] FiyatBilgileri;

        private void TxtDepoOku()
        {

            DepoBilgileri = File.ReadAllLines(Application.StartupPath + "\\depo.txt.txt");
            DepoBenzin95 = Convert.ToDouble(DepoBilgileri[0]);
            DepoBenzin97 = Convert.ToDouble(DepoBilgileri[1]);
            DepoDizel = Convert.ToDouble(DepoBilgileri[2]);
            DepoEuroDizel = Convert.ToDouble(DepoBilgileri[3]);
            DepoLpg = Convert.ToDouble(DepoBilgileri[4]);
        }

        private void TxtDepoYaz()
        {
            dlbl1.Text = DepoBenzin95.ToString("N");
            dlbl2.Text = DepoBenzin97.ToString("N");
            dlbl3.Text = DepoDizel.ToString("N");
            dlbl4.Text = DepoEuroDizel.ToString("N");
            dlbl5.Text = DepoLpg.ToString("N");

        }

        private void TxtFiyatOku()
        {
            FiyatBilgileri = File.ReadAllLines(Application.StartupPath + "\\Fiyat.txt.txt");
            FiyatBenzin95 = Convert.ToDouble(FiyatBilgileri[0]);
            FiyatBenzin97 = Convert.ToDouble(FiyatBilgileri[1]);
            FiyatDizel = Convert.ToDouble(FiyatBilgileri[2]);
            FiyatEuroDizel = Convert.ToDouble(FiyatBilgileri[3]);
            FiyatLpg = Convert.ToDouble(FiyatBilgileri[4]);
        }

        private void TxtFiyatYaz()
        {
            flbl1.Text = FiyatBenzin95.ToString("N");
            flbl2.Text = FiyatBenzin97.ToString("N");
            flbl3.Text = FiyatDizel.ToString("N");
            flbl4.Text = FiyatEuroDizel.ToString("N");
            flbl5.Text = FiyatLpg.ToString("N");
        }

        private void ProgresBarGuncelle()
        {
            progressBar1.Value = Convert.ToInt16(DepoBenzin95);
            progressBar2.Value = Convert.ToInt16(DepoBenzin97);
            progressBar3.Value = Convert.ToInt16(DepoDizel);
            progressBar4.Value = Convert.ToInt16(DepoEuroDizel);
            progressBar5.Value = Convert.ToInt16(DepoLpg);
        }

        private void NumericUpDownValue()
        {
            numericUpDown1.Maximum = decimal.Parse(DepoBenzin95.ToString());
            numericUpDown2.Maximum = decimal.Parse(DepoBenzin97.ToString());
            numericUpDown3.Maximum = decimal.Parse(DepoDizel.ToString());
            numericUpDown4.Maximum = decimal.Parse(DepoEuroDizel.ToString());
            numericUpDown5.Maximum = decimal.Parse(DepoLpg.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "AKARYAKIT OTOMOSYONU";
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;
            progressBar5.Maximum = 1000;
            TxtDepoOku();
            TxtDepoYaz();
            TxtFiyatOku();
            TxtFiyatYaz();
            ProgresBarGuncelle();
            NumericUpDownValue();
            string[] YakitTürleri = { "Benzin 95", "Benzin 97", "Dizel", "Euro Dizel", "Lpg" };
            comboBox1.Items.AddRange(YakitTürleri);
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;

        }

        private void label10_Click(object sender, EventArgs e)
        {
            

        }
    }
}
