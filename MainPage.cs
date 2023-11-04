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
    public partial class mainPage : Form
    {
        public mainPage()
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

        void clearUpdate()
        {
            shelfNo.Text = "";
            updateCode.Text = "";
        }
        void clearSearch()
        {
            productCode.Text = "";
            result.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand comn = new OleDbCommand("select * from productCodes where productCode= '" + productCode.Text + "'", bag);
                OleDbDataReader dr = comn.ExecuteReader();
                if (dr.HasRows)
                {
                    result.Visible = true;

                    while (dr.Read())
                     {
                 
                        result.Text = "Raf No : " + dr["shelf_no"];
                        // MessageBox.Show("Kullanıcı Adı = " + dr["productCode"].ToString() + "\nŞifre              =" + dr["shelf_no"].ToString(), "HATIRLATMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
                else
                {
                    MessageBox.Show("Ürün Kodu HATALI!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearSearch();
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message,"UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private ContextMenu menu;
        protected void kapat_click(object sender, System.EventArgs e)
        {
            Application.Exit();

        }
       
        private void mainPage_Load(object sender, EventArgs e)
        {
            NotifyIcon icn = new NotifyIcon();//yeni bir NotifyIcon tanımladık "örneğin ismi" mause ile üaerine geldiginde bilgi verir.
            icn.Visible = true;
            icn.Icon = new Icon("giyimmasali-new-logo.ico");
            menu = new ContextMenu();
            menu.MenuItems.Add(0, new MenuItem("Kapat", new System.EventHandler(kapat_click)));// göster click eventını oluşturuyoruz
            icn.ContextMenu = menu;
            baglan();
            result.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
       
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (shelfNo.Text != "" && updateCode.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("Update productCodes set shelf_No= '" + shelfNo.Text + "'where productCode='" + updateCode.Text + "'", bag);
               int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected>0)
                {
                      MessageBox.Show("Raf Numarası '"+shelfNo.Text +"' Olarak Başarılı Şekilde Güncellendi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      clearUpdate();
                }
                else
                {
                    MessageBox.Show("Ürün Kodu HATALI!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    clearUpdate();
                }



            }
            else
                MessageBox.Show("Ürün Kodu ve Raf Numarası Boş OLAMAZ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void productCodes_Click(object sender, EventArgs e)
        {
            ProductCodeListPage prd = new ProductCodeListPage();
            prd.Show();
        }

        private void productCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
