using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntp2_hft3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string veri = "Elma;Armut;Çilek;Portakal;Mandalina";
            //Dizi değişkeni            
            string[] meyveler = veri.Split(';');
            
            string veri2 = "Domates;Salatalık;Patlıcan;Kabak;Karnibahar";
            //Dizi değişkeni            
            string[] sebzeler = veri2.Split(';');

            for (int i = 0; i < sebzeler.Length; i++)
            {
                listBox1.Items.Add(meyveler[i]);
                listBox2.Items.Add(sebzeler[i]);
            }

            this.Text= "Meyve ve Sebze Listesi";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox2.SelectedIndex = index;

        }
    }
}
