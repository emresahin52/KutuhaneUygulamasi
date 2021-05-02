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
    public partial class ESProje04_YayinlaForm : Form
    {



        static string baglanti = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + Environment.CurrentDirectory + "\\data\\Kitaplar.accdb";
        OleDbConnection bag = new OleDbConnection(baglanti);
        OleDbCommand cmd;



        public ESProje04_YayinlaForm()
        {
            InitializeComponent();
        }
       




        private void ESProje04_YayinlaForm_Load(object sender, EventArgs e)
        {

        }




        private void ESbtnAnaForm_Click(object sender, EventArgs e)
        {
            ESProje04_AnaForm AnaForm = new ESProje04_AnaForm();
            AnaForm.Show();

        }

        private void ESbtnKaydet_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "insert into YayinlanmaBilgisi   (KitapNo,YayinEvi,YayinYili,Fiyati) values ('" + EStbKitapNo.Text + "','" + EStxtyayinevi.Text + "','" + EStxtyayinyili.Text + "','" + EStxtfiyati.Text + "')";
            cmd.ExecuteNonQuery();
            bag.Close();
            this.Close();
           
        }
    }
}
