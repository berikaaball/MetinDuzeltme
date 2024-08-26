using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetinDüzeltme
{
    public partial class Form1 : Form
    {
        private string eskiMetin;
        public Form1()
        {
            InitializeComponent();
            eskiMetin = TBoxMetin.Text;
        }

        private void BtnDuzelt_Click(object sender, EventArgs e)
        {
            string metin = TBoxMetin.Text.Trim();
            string yeniParca = TBoxYeniParca.Text.Trim();
            string eskiParca = TBoxEskiParca.Text.Trim();
            Dolumu();

            Regex myregex = new Regex(Regex.Escape(eskiParca), RegexOptions.IgnoreCase);
            string yeniMetin = myregex.Replace(metin, yeniParca);

            if (yeniMetin != metin)
            {
                TBoxMetin.Text = yeniMetin;
                MessageBox.Show("Kelime başarıyla değiştirildi.", "Bilgi");
            }
            else
            {
                MessageBox.Show($"'{eskiParca}' kelimesi metin içinde bulunamadı.", "Uyarı");
            }

            try
            {
                string sorgu = "INSERT INTO Metinler (Metin,YeniParca,EskiParca) VALUES ('" + TBoxMetin.Text + "','" + TBoxYeniParca.Text + "','" + TBoxEskiParca.Text + "')";
                VtIslemleri.KomutCalistir(sorgu);
            }
            catch (Exception msg)
            {
                MessageBox.Show("Metin veri tabanına eklenemedi.", msg.Message);
            }
            DGVDoldur();
        }

        private void Dolumu()
        {
            if (string.IsNullOrEmpty(TBoxMetin.Text)|| string.IsNullOrEmpty(TBoxYeniParca.Text)|| string.IsNullOrEmpty(TBoxEskiParca.Text))
            {
                MessageBox.Show("Tüm alanların dolu olduğundan emin olunuz.", "Uyarı");
            }
        }

        private void DGVDoldur()
        {
            string komut = "SELECT MetinID,Metin,YeniParca,EskiParca FROM Metinler";
            DGV1.DataSource = VtIslemleri.VeriGetir(komut);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVDoldur();
            TBoxMetin.Clear();
            TBoxYeniParca.Clear();
            TBoxEskiParca.Clear();
        }

        private void DGV1_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count>0)

            {
                DataGridViewRow secilisatir = DGV1.SelectedRows[0];

                TBoxMetin.Text = secilisatir.Cells["Metin"].Value.ToString();
                TBoxYeniParca.Text = secilisatir.Cells["YeniParca"].Value.ToString();
                TBoxEskiParca.Text = secilisatir.Cells["EskiParca"].Value.ToString();
            }
            else
            {
                TBoxMetin.Clear();
                TBoxEskiParca.Clear();
                TBoxYeniParca.Clear();
            }
        }
    }
}
