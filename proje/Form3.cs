using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] isim = new string[15];
        string[] telefon = new string[15];
        string[] adres = new string[20];
        string[] metrekare = new string[15];
        string[] salon = new string[1000];
        string[] oda = new string[1000];
        string[] balkon = new string[1000];
        string[] kat = new string[1000];
        string[] fiyat = new string[15];

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10000)
            {
                isim[i] = textBox1.Text;
                telefon[i] = textBox2.Text;
                adres[i] = textBox3.Text;
                metrekare[i] = textBox4.Text;
                salon[i] = textBox5.Text;
                oda[i] = textBox6.Text;
                balkon[i] = textBox7.Text;
                kat[i] = textBox8.Text;
                fiyat[i] = textBox9.Text;

                listBox1.Items.Add(isim[i] + "\t" + telefon[i] + "\t" + adres[i] + "\t" + metrekare[i] + "\t" + salon[i] + "\t" + oda[i] + "\t" + balkon[i] + "\t" + kat[i] + "\t" + fiyat[i]);
                i++;
            }

            MessageBox.Show("kayit eklendi");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show("Veri Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Seçilmemiş.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                string degisad = Interaction.InputBox("Adınızı Giriniz", "Kaydet", "", 100, 100);
                string degistel = Interaction.InputBox("Telefonunuzu Giriniz", "Kaydet", "", 100, 100);
                string degisadres = Interaction.InputBox("Adresinizi Giriniz", "Kaydet", "", 100, 100);
                string degismetre = Interaction.InputBox("Metrekareyi Giriniz", "Kaydet", "", 100, 100);
                string degissalon = Interaction.InputBox("Salon Sayısını Giriniz", "Kaydet", "", 100, 100);
                string degisoda = Interaction.InputBox("Oda Sayısını Giriniz", "Kaydet", "", 100, 100);
                string degisbalkon = Interaction.InputBox("Balkon Sayısını Giriniz", "Kaydet", "", 100, 100);
                string degiskat = Interaction.InputBox("Kat Sayısını Giriniz", "Kaydet", "", 100, 100);
                string degisfiyat = Interaction.InputBox("Fiyatı Giriniz", "Kaydet", "", 100, 100);

                listBox1.Items.Add(degisad + "\t" + degistel + "\t" + degisadres + "\t" + degismetre + "\t" + degissalon + "\t" + degisoda + "\t" + degisbalkon + "\t" + degiskat + "\t" + degisfiyat);
                MessageBox.Show("Seçilen Veri Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Seçilemedi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aranankisi = Interaction.InputBox("Aradığınız kişiyi Giriniz", "Kaydet", "", 100, 100);
            string metrekaresi = Interaction.InputBox("İstediğiniz metrekareyi Giriniz", "Kaydet", "", 100, 100);
            string salonsayisi = Interaction.InputBox("İstediğiniz Salon Sayısını Giriniz", "Kaydet", "", 100, 100);
            string odasayisi = Interaction.InputBox("İstediğiniz Oda Sayısını Giriniz", "Kaydet", "", 100, 100);
            string balkonsayisi = Interaction.InputBox("İstediğiniz Balkon Sayısını Giriniz", "Kaydet", "", 100, 100);
            string katsayisi = Interaction.InputBox("İstediğiniz Toplam Daire Sayısını Giriniz", "Kaydet", "", 100, 100);

            for (int j = 0; j < i; j++)
            {
                if (isim[j] == aranankisi) listBox1.SetSelected(j, true);
                if (metrekare[j] == metrekaresi) listBox1.SetSelected(j, true);
                if (salon[j] == salonsayisi) listBox1.SetSelected(j, true);
                if (oda[j] == odasayisi) listBox1.SetSelected(j, true);
                if (balkon[j] == balkonsayisi) listBox1.SetSelected(j, true);
                if (kat[j] == katsayisi) listBox1.SetSelected(j, true);
            }
            
            /*
            foreach (var eleman in listBox1.Items)
            {

            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox10.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
            
             * 
             * 
             * 
             * 
                if (salon[i] == salonsayisi) listBox1.SetSelected(j, true);
                if (oda[i] == odasayisi) listBox1.SetSelected(j, true);
                if (balkon[i] == balkonsayisi) listBox1.SetSelected(j, true);
                if (toplamdaire[i] == toplamdairesayisi) listBox1.SetSelected(j, true);**/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
