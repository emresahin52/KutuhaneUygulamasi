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
    public partial class FrmRapor : Form
    {

        static string baglanti = "Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + Environment.CurrentDirectory + "\\data\\Kitaplar.accdb";
        OleDbConnection bag = new OleDbConnection(baglanti);
        DataTable Tables = new DataTable();


        public FrmRapor()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from KitapBilgisi",bag);
            da.Fill(Tables);
            CrystalReport1 crRapor = new CrystalReport1();
            crRapor.SetDataSource(Tables);
            crystalReportViewer1.ReportSource = crRapor;
        }
    }
}
