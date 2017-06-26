using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAplication
{
    public partial class Form1 : Form
    {
        public double raza_actiune_tambur;
        public double numar_spire_initiale;
        public double dim_spira_initiala;
        public double dim_fir;
        public double dim_umpluta;
        public double dim_fir_tambur;
        public double dim_u;
        public double lungimea_fir_tambur_plin;
        public double lungimea_fir_tambur_final;
        public double lungime_fir_aruncat;
        public double inaltime;
        public double unghi;
        public double adancime_peste;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double copie_pentru_dim_spira_initiala = dim_spira_initiala;
            dim_fir_tambur = 0;
            double pas;
            pas = dim_fir * 2 / 10;
            while (raza_actiune_tambur > 0)
            {
                dim_fir_tambur += numar_spire_initiale * copie_pentru_dim_spira_initiala / 100;
                //consider ca numarul de spire ramane acelasi;		
                copie_pentru_dim_spira_initiala += pas;
                raza_actiune_tambur -= dim_fir;
            }
            MessageBox.Show("Pe mulineta dumneavoastra incape  " + dim_fir_tambur+" m fir");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox1.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i]==',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);

            raza_actiune_tambur = nr / p;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox2.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i] == ',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);

            numar_spire_initiale = nr / p;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox3.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i] == ',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);

            dim_spira_initiala = nr / p;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox4.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i] == ',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);

            dim_fir = nr / p;
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox5.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i] == ',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);

            dim_umpluta = nr / p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double copie_pentru_dim_spira_initiala = dim_spira_initiala;
            double pas;
            pas = dim_fir * 2 / 10;
            lungimea_fir_tambur_plin = 0;
            while (dim_umpluta > 0)
            {
                lungimea_fir_tambur_plin = lungimea_fir_tambur_plin + numar_spire_initiale * copie_pentru_dim_spira_initiala / 100;
                copie_pentru_dim_spira_initiala = copie_pentru_dim_spira_initiala + pas;
                dim_umpluta = dim_umpluta - dim_fir;
            }
            MessageBox.Show("Ati pus pe mulineta "+lungimea_fir_tambur_plin+ " m fir din " + dim_fir_tambur+" posibili");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double copie_pentru_dim_spira_initiala = dim_spira_initiala;
            lungimea_fir_tambur_final = 0;
            double pas;
            pas = dim_fir * 2 / 10;
            while (dim_u > 0)
            {
                lungimea_fir_tambur_final = lungimea_fir_tambur_final + numar_spire_initiale * copie_pentru_dim_spira_initiala / 100;
                copie_pentru_dim_spira_initiala = copie_pentru_dim_spira_initiala + pas;
                dim_u = dim_u - dim_fir;
            }
            lungime_fir_aruncat= lungimea_fir_tambur_plin - lungimea_fir_tambur_final;
            MessageBox.Show("Felicitari! Ai aruncat "+lungime_fir_aruncat+" m fir" );
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox6.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i] == ',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);

            dim_u = nr / p;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double distanta_aruncata = lungime_fir_aruncat;
            double grosime_fir =dim_fir;
            double greutate_metru_fir = (Math.Pow((grosime_fir / 2) , 2) * 0.1) / (Math.Pow((0.155), 2));
            double masa_fir_intins = 2 * distanta_aruncata * greutate_metru_fir;
            MessageBox.Show("Pentru a se intinde firul este nevoie de o greutate minima de: " + masa_fir_intins + " g");
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i, dif;
            string element = textBox7.Text;
            int p = 1;
            for (i = 0; i < element.Length; i++)
                if (element[i] == '.' || element[i] == ',')
                {
                    dif = element.Length - i - 1;
                    while (dif > 0)
                    {
                        p = p * 10;
                        dif = dif - 1;
                    }
                }
                else
                    if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);
            inaltime = nr / p;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double nr = 0;
            int i;
            string element = textBox8.Text;
            for (i = 0; i < element.Length; i++)
                if (element[i] >= '0' && element[i] <= '9')
                    nr = nr * 10 + (int)Char.GetNumericValue(element[i]);
            unghi = nr;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double distanta_aruncata = lungime_fir_aruncat;
            adancime_peste = distanta_aruncata * Math.Cos(unghi) - inaltime;
            MessageBox.Show("Peste se afla la adancimea " + adancime_peste + "m");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double ip;
            double distanta_aruncata = lungime_fir_aruncat;
            ip = (distanta_aruncata * adancime_peste) / (inaltime + adancime_peste);
            MessageBox.Show("Peste a ajuns la "+ip+" m distanta de aer");
        }
    }
}
