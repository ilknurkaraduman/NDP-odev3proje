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
    public partial class Form4 : Form
    {
        int secili = -1;
        int sayac = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "" && textBox7.Text.Trim() != "")
            {
                dataGridView1.Rows.Add(1);
                int toplam = dataGridView1.Rows.Count;
                dataGridView1.Rows[toplam - 2].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[toplam - 2].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[toplam - 2].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[toplam - 2].Cells[3].Value = textBox4.Text;
                dataGridView1.Rows[toplam - 2].Cells[4].Value = textBox5.Text;
                dataGridView1.Rows[toplam - 2].Cells[5].Value = textBox6.Text;
                dataGridView1.Rows[toplam - 2].Cells[6].Value = textBox7.Text;
                dataGridView1.Rows[toplam - 2].Cells[7].Value = comboBox2.SelectedItem;
                dataGridView1.Rows[toplam - 2].Cells[8].Value = comboBox1.SelectedItem;

                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                textBox1.Focus();
                sayac++;
            }
            else MessageBox.Show("TÜM ALANLARI DOLDURUNUZ..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            else MessageBox.Show("LÜTFEN BİR KAYIT SEÇİNİZ..");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secili != -1)
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "" && textBox7.Text.Trim() != "")
                {
                    dataGridView1.Rows[secili].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[secili].Cells[1].Value = textBox2.Text;
                    dataGridView1.Rows[secili].Cells[2].Value = textBox3.Text;
                    dataGridView1.Rows[secili].Cells[3].Value = textBox4.Text;
                    dataGridView1.Rows[secili].Cells[4].Value = textBox5.Text;
                    dataGridView1.Rows[secili].Cells[5].Value = textBox6.Text;
                    dataGridView1.Rows[secili].Cells[6].Value = textBox7.Text;
                }
                else MessageBox.Show("TÜM ALANLARI DOLDURUNUZ..");
            }
            else MessageBox.Show("BİR KAYIT LİSTELEYİNİZ..");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                secili = dataGridView1.CurrentRow.Index;
            }
            else MessageBox.Show("LÜTFEN BİR KAYIT SEÇİNİZ..");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string aranankisi = Interaction.InputBox("Aradığınız kişiyi Giriniz", "Kaydet", "", 100, 100);
            string metrekaresi = Interaction.InputBox("İstediğiniz metrekareyi Giriniz", "Kaydet", "", 100, 100);
            string salonsayisi = Interaction.InputBox("İstediğiniz Salon Sayısını Giriniz", "Kaydet", "", 100, 100);
            string odasayisi = Interaction.InputBox("İstediğiniz Oda Sayısını Giriniz", "Kaydet", "", 100, 100);
            string balkonsayisi = Interaction.InputBox("İstediğiniz Balkon Sayısını Giriniz", "Kaydet", "", 100, 100);
            
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranankisi)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == metrekaresi)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == salonsayisi)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == odasayisi)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == balkonsayisi)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }

            }
        }
    }
}
