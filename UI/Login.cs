using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point mouseDownLocation;
        private void FormMenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mouseDownLocation.X;
                this.Top = e.Y + this.Top - mouseDownLocation.Y;
            }
        }

        private void FormMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string host = tbox_host.Text;
            string db = tbox_db.Text;
            string user = tbox_user.Text;
            string pwd = tbox_pwd.Text;
            if (host != "" && db != "" && user != "" && pwd != "")
            {
                string conString = @"Data Source= " + host + "; Initial Catalog= " + db + "; User ID = " + user + "; Password = " + pwd + ";";
                SqlConnection con = new SqlConnection(conString);
                try
                {
                    con.Open();
                    con.Close();
                    CustomersMenu newform = new CustomersMenu();
                    newform.conString = conString;
                    newform.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Bağlantı kurulurken bir hata ile karşılaşıldı!\nLütfen girdiğiniz bilgilerin doğruluğundan ve sql hizmetinizin başlatıldığından emin olun.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli bütün alanları doldurunuz!");
            }
        }

        private void btn_newdb_Click(object sender, EventArgs e)
        {
            string host = tbox_newhost.Text;
            string db = tbox_newdb.Text;
            string user = tbox_newuser.Text;
            string pwd = tbox_newpwd.Text;
            if (host != "" && db != "" && user != "" && pwd != "")
            {
                string conString1 = @"Data Source= " + host + "; Initial Catalog= master; User ID = " + user + "; Password = " + pwd + ";";
                SqlConnection con1 = new SqlConnection(conString1);
                string comString1 = "CREATE DATABASE " + db + ";";
                SqlCommand com1 = new SqlCommand(comString1, con1);
                string conString2 = @"Data Source= " + host + "; Initial Catalog= " + db + "; User ID = " + user + "; Password = " + pwd + ";";
                SqlConnection con2 = new SqlConnection(conString2);
                string comString2 = "CREATE TABLE Musteriler(Musteri_No int IDENTITY(1000,1) PRIMARY KEY, Musteri varchar(255) NOT NULL,Musteri_Turu varchar(25) NOT NULL,Bakiye decimal(18, 2) NOT NULL, Bakiye_Turu varchar(255) NOT NULL);";
                SqlCommand com2 = new SqlCommand(comString2, con2);
                string comString3 = "CREATE TABLE Islemler(Islem_No int IDENTITY(1000,1) PRIMARY KEY, Musteri_No int NOT NULL, Tarih varchar(255) NOT NULL, Urun varchar(255), Birim varchar(255), Birim_Fiyat decimal(18,2) NOT NULL, Adet int NOT NULL, Bakiye decimal(18,2) NOT NULL, Odeme decimal(18,2) NOT NULL, Genel_Toplam decimal(18,2) NOT NULL);";
                SqlCommand com3 = new SqlCommand(comString3, con2);
                try
                {
                    con1.Open();
                    com1.ExecuteNonQuery();
                    con1.Close();
                    con2.Open();
                    com2.ExecuteNonQuery();
                    com3.ExecuteNonQuery();
                    con2.Close();
                    tbox_host.Text = host;
                    tbox_db.Text = db;
                    tbox_user.Text = user;
                    tbox_pwd.Text = pwd;
                    tbox_newhost.Text = "localhost";
                    tbox_newdb.Text = "";
                    tbox_newuser.Text = "";
                    tbox_newpwd.Text = "";
                    MessageBox.Show("Veri tabanınız başarı ile oluşturulmuştur!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri tabanı oluşturulurken bir hata ile karşılaşıldı!\nHata:\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli bütün alanları doldurunuz!");
            }
        }
    }
}
