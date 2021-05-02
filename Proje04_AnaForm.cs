using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BIP2504_PROJE04
{
    public partial class ESProje04_AnaForm : Form
    {
        static string baglanti = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + Environment.CurrentDirectory + "\\data\\Kitaplar.accdb";
        OleDbConnection bag = new OleDbConnection(baglanti);
        OleDbDataAdapter da;
        OleDbCommand cmd;

        void VeriGetir()
        {
            da = new OleDbDataAdapter("Select * From KitapBilgisi",baglanti);
            DataSet ds = new DataSet();
            bag.Open();
            da.Fill(ds,"KitapBilgisi");
            ESdgvKitapListesi.DataSource = ds.Tables["KitapBilgisi"];
            bag.Close();
        }


     
        public ESProje04_AnaForm()
        {
            InitializeComponent();
        }

        private void ESbtnKaydet_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "insert into KitapBilgisi  (KitapNo,KitapAdi,YazarAdi,KitapTuru) values ('" + EStbKitapNo.Text + "','" + EStbKitapAdi.Text + "','" + EStbYazarAdi.Text + "','" + EScmbKitapTuru.Text + "')";
            cmd.ExecuteNonQuery();
            bag.Close();
            VeriGetir();


        }

        private void kitapGuncelleMenuItem_Click(object sender, EventArgs e)
        {

            cmd = new OleDbCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "Update KitapBilgisi  set KitapAdi= '" + EStbKitapAdi.Text + "'YazarAdi='" +EStbYazarAdi.Text + "'KitapTuru='" +EScmbKitapTuru.Text+ "'where  'KitapNo=''"+ EStbKitapNo.Text +"" ;
            cmd.ExecuteNonQuery();
            bag.Close();
            VeriGetir();

        }


        private void kitapSilMenuItem_Click(object sender, EventArgs e)
        {
            bag.Open();
            using (OleDbCommand cmd = new OleDbCommand("delete  from KitapBilgisi where KitapNo=?", bag))
            {
                cmd.Parameters.Add("KitapNo", OleDbType.Integer).Value = ESdgvKitapListesi.CurrentRow.Cells[1].Value.ToString();
                cmd.ExecuteNonQuery();
                bag.Close();
            }

            VeriGetir();
        }



        private void ESbtnGuncelle_Click(object sender, EventArgs e)
        {
            VeriGetir();
        }


        private void ESProje04_AnaForm_Load(object sender, EventArgs e)
        {
            VeriGetir();

        }

        private void ESbtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ESbtnKitapRapor_Click(object sender, EventArgs e)
        {
            FrmRapor frmrapor = new FrmRapor();
            frmrapor.Show();



        }

        

        private void yayinciBilgisiMenuItem_Click(object sender, EventArgs e)
        {
            ESProje04_YayinlaForm Yayincifrm = new ESProje04_YayinlaForm();
            Yayincifrm.Show();
        }
    }
}
