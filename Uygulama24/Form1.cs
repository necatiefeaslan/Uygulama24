using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama24
{
    public partial class Form1 : Form
    {
        List<Ogrenciler> liste = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumara.Text);
            ogrenci.AdSoyad = txtAdSoyad.Text;
            ogrenci.DersNotu = int.Parse(txtDersNotu.Text);
            liste.Add(ogrenci);
            Bagla();
        }
        private void Bagla()
        {
            gridListe.DataSource = null;
            gridListe.DataSource = liste;
        }

        private void gridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = gridListe.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = gridListe.CurrentRow.Cells[1].Value.ToString();
            txtDersNotu.Text = gridListe.CurrentRow.Cells[2].Value.ToString();
        }
    }
    class Ogrenciler
    {
        public int Numara { get; set; }
        public string AdSoyad { get; set; }
        public int DersNotu { get; set; }
    }
}
