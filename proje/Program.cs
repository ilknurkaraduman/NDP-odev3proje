/***********************************************************************************************************
**                                         SAKARYA ÜNİVERSİTESİ                                           **
**                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                               **
**                                 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                                 **
**                                    NESNEYE DAYALI PROGRAMLAMA DERSİ                                    **
**                                         2016-2017 BAHAR DÖNEMİ                                         **
**                                                                                                        **
**                                ÖDEV NUMARASI..........: 3                                              **
**                                ÖĞRENCİ ADI............: İLKNUR KARADUMAN                               **
**                                ÖĞRENCİ NUMARASI.......: b161200040                                     **
**                                DERSİN ALINDIĞI GRUP...: A                                              **
***********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
