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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] isim = new string[15];
        string[] telefon = new string[15];
        string[] adres = new string[20];
        string[] metrekare = new string[15];
        string[] fiyat = new string[15];
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10000)
            {
                isim[i] = textBox1.Text;
                telefon[i] = textBox2.Text;
                adres[i] = textBox3.Text;
                metrekare[i] = textBox4.Text;
                fiyat[i] = textBox5.Text;

                listBox1.Items.Add(isim[i] + "\t" + telefon[i] + "\t" + adres[i] + "\t" + metrekare[i] + "\t" + fiyat[i]);
                i++;
            }

            MessageBox.Show("kayit eklendi");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        } 
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                string degisad = Interaction.InputBox("Adınızı Giriniz", "Kaydet", "", 100, 100);
                string degistel = Interaction.InputBox("Telefonunuzu Giriniz", "Kaydet", "", 100, 100);
                string degisadres = Interaction.InputBox("Adresinizi Giriniz", "Kaydet", "", 100, 100);
                string degismetre = Interaction.InputBox("Metrekareyi Giriniz", "Kaydet", "", 100, 100);
                string degisfiyat = Interaction.InputBox("Fiyatı Giriniz", "Kaydet", "", 100, 100);

                listBox1.Items.Add(degisad + "\t" + degistel + "\t" + degisadres + "\t" + degismetre + "\t"+ degisfiyat);
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

            for (int j = 0; j < i; j++)
            {
                if (isim[j] == aranankisi) listBox1.SetSelected(j, true);
                if (metrekare[j] == metrekaresi) listBox1.SetSelected(j, true);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
