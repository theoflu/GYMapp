using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMapp
{
    public partial class ProductCodeListPage : Form
    {
        public ProductCodeListPage()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("provider=microsoft.ace.oledb.12.0; Data source =GYMAPP.accdb");
        void baglan()
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
        }
        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT *  FROM productCodes", bag);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ProductCodeListPage_Load(object sender, EventArgs e)
        {
            baglan();
            listele();
        }
    }
}
