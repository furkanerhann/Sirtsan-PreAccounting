using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomersMenu : Form
    {
        public CustomersMenu()
        {
            InitializeComponent();
        }
        public string conString;
        private int selectedId = 0;
        private int operationId;
        private string selectedName;
        private string selectedType;
        private string selectedCurrency;
        private decimal selectedBalance;

        private void getData(int type = 0, int currency = 0, int balance = 0, string search = "")
        {
            SqlConnection con = new SqlConnection(conString);
            string comstring = "SELECT * FROM Musteriler";
            if (type == 0 && currency == 0 && balance == 0 && search == "")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comstring, con);
                DataSet customerdata = new DataSet();
                da.Fill(customerdata, "Customers");
                dataview.DataSource = customerdata.Tables["Customers"];
                con.Close();
            }
            else
            {
                comstring += " WHERE ";
                int addand = 0;
                if (type != 0)
                {
                    if (type == 1)
                    {
                        comstring += "Musteri_Turu = 'Musteri'";
                    }
                    else if (type == 2)
                    {
                        comstring += "Musteri_Turu = 'Tedarikci'";
                    }
                    addand = 1;
                }
                if (currency != 0)
                {
                    if (addand == 1)
                    {
                        comstring += " AND ";
                    }
                    if (currency == 1)
                    {
                        comstring += "Bakiye_Turu = 'TL'";
                    }
                    else if (currency == 2)
                    {
                        comstring += "Bakiye_Turu = 'Dolar'";
                    }
                    else if (currency == 3)
                    {
                        comstring += "Bakiye_Turu = 'Euro'";
                    }
                    addand = 1;
                }
                if (balance != 0)
                {
                    if (addand == 1)
                    {
                        comstring += " AND ";
                    }
                    if (balance == 1)
                    {
                        comstring += "Bakiye < 0";
                    }
                    else if (balance == 2)
                    {
                        comstring += "Bakiye > 0";
                    }
                    addand = 1;
                }
                if (search != "")
                {
                    if (addand == 1)
                    {
                        comstring += " AND ";
                    }
                    comstring += "Musteri LIKE '%" + search + "%'";
                }
                comstring += ";";
                con.Open();
                SqlCommand com = new SqlCommand(comstring, con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet customerdata = new DataSet();
                da.Fill(customerdata, "Customers");
                dataview.DataSource = customerdata.Tables["Customers"];
                con.Close();
            }
        }
        private void setup(int setupId)
        {
            if (setupId == 0)
            {
                tbox_customername.Visible = false;
                cbox_custoemrtype.Visible = false;
                cbox_customercurrency.Visible = false;
                btn_operation.Visible = false;
            }
            else if (setupId == 1)
            {
                tbox_search.Text = "";
                cbox_type.SelectedIndex = 0;
                cbox_balance.SelectedIndex = 0;
                cbox_currency.SelectedIndex = 0;
            }
            else if (setupId == 2)
            {
                tbox_customername.Visible = true;
                tbox_customername.Text = "";
                cbox_custoemrtype.Visible = true;
                cbox_custoemrtype.SelectedIndex = 0;
                cbox_customercurrency.Visible = true;
                cbox_customercurrency.SelectedIndex = 0;
                btn_operation.Visible = true;
                btn_operation.Text = "Yeni Ekle";
                operationId = 1;
            }
            else if (setupId == 3)
            {
                tbox_customername.Visible = true;
                cbox_custoemrtype.Visible = true;
                cbox_customercurrency.Visible = true;
                btn_operation.Visible = true;
                btn_operation.Text = "Güncelle";
                operationId = 2;
            }
        }

        private void CustomersMenu_Load(object sender, EventArgs e)
        {
            setup(0);
            setup(1);
            getData();
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

        private void btn_opencustomer_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                OperationsMenu newform = new OperationsMenu();
                newform.conString = conString;
                newform.customerId = selectedId;
                newform.customerName = selectedName;
                newform.customerType = selectedType;
                newform.customerCurrency = selectedCurrency;
                newform.customerBalance = selectedBalance;
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!");
            }
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            int c = cbox_currency.SelectedIndex;
            if (c == 0)
            {
                MessageBox.Show("Lütfen bir tane para birimi seçiniz!");
            }
            else
            {
                btn_search.PerformClick();
                int total = dataview.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));
                string currency = cbox_currency.SelectedItem.ToString();
                string result = "Total Balance: " + currency + " " + total.ToString();
                MessageBox.Show(result);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            setup(2);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        string comstring = "DELETE FROM Musteriler WHERE Musteri_No = " + selectedId + ";";
                        con.Open();
                        SqlCommand com = new SqlCommand(comstring, con);
                        com.ExecuteNonQuery();
                        btn_search.PerformClick();
                        con.Close();
                        setup(0);
                        setup(1);
                        getData();
                        tbox_customername.Text = "";
                        cbox_custoemrtype.SelectedIndex = 0;
                        cbox_customercurrency.SelectedIndex = 0;
                        selectedId = 0;
                        selectedBalance = 0;
                        operationId = 0;
                        selectedName = "";
                        selectedType = "";
                        selectedCurrency = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata!\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir müşteri seçiniz!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            newform.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int type = cbox_type.SelectedIndex;
            int currency = cbox_currency.SelectedIndex;
            int balance = cbox_balance.SelectedIndex;
            string search = tbox_search.Text;
            getData(type, currency, balance, search);
        }

        private void btn_operation_Click(object sender, EventArgs e)
        {
            if (operationId == 1)
            {
                string name = tbox_customername.Text;
                string type = cbox_custoemrtype.SelectedItem.ToString();
                if (type == "Türü Seçiniz")
                {
                    type = "";
                }
                string currency = cbox_customercurrency.SelectedItem.ToString();
                if (currency == "Para Birimi Seçiniz")
                {
                    currency = "";
                }
                if (name != "" && type != "" && currency != "")
                {
                    string comstring = "INSERT INTO Musteriler (Musteri, Musteri_Turu, Bakiye, Bakiye_Turu) VALUES(@m, @mt, @b, @bt)";
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        try
                        {
                            con.Open();
                            using (SqlCommand com = new SqlCommand(comstring, con))
                            {
                                com.Parameters.Add("@m", SqlDbType.NVarChar).Value = name;
                                com.Parameters.Add("@mt", SqlDbType.NVarChar).Value = type;
                                com.Parameters.Add("@b", SqlDbType.Decimal).Value = 0;
                                com.Parameters.Add("@bt", SqlDbType.NVarChar).Value = currency;
                                int rowsAdded = com.ExecuteNonQuery();
                                if (rowsAdded > 0)
                                {
                                    setup(0);
                                    setup(1);
                                    getData();
                                    tbox_customername.Text = "";
                                    cbox_custoemrtype.SelectedIndex = 0;
                                    cbox_customercurrency.SelectedIndex = 0;
                                    selectedId = 0;
                                    selectedBalance = 0;
                                    operationId = 0;
                                    selectedName = "";
                                    selectedType = "";
                                    selectedCurrency = "";
                                }
                                else
                                {
                                    MessageBox.Show("Hata!");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata!\n" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz!");
                }
            }
            else if (operationId == 2)
            {
                try
                {
                    string name = tbox_customername.Text;
                    string type = cbox_custoemrtype.SelectedItem.ToString();
                    if (type == "Müsteri")
                    {
                        type = "Müşteri";
                    }
                    else if (type == "Türü Seçiniz")
                    {
                        type = "";
                    }
                    string currency = cbox_customercurrency.SelectedItem.ToString();
                    if (currency == "Para Birimi Seçiniz")
                    {
                        currency = "";
                    }
                    if (name != "" && type != "" && currency != "")
                    {
                        string comstring = "UPDATE Musteriler SET Musteri = @cs, Musteri_Turu = @t, Bakiye_Turu = @cr WHERE Musteri_No = " + selectedId + ";";
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            try
                            {
                                con.Open();
                                using (SqlCommand com = new SqlCommand(comstring, con))
                                {
                                    com.Parameters.Add("@cs", SqlDbType.NVarChar).Value = name;
                                    com.Parameters.Add("@t", SqlDbType.NVarChar).Value = type;
                                    com.Parameters.Add("@cr", SqlDbType.NVarChar).Value = currency;
                                    int rowsAdded = com.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        setup(0);
                                        setup(1);
                                        getData();
                                        tbox_customername.Text = "";
                                        cbox_custoemrtype.SelectedIndex = 0;
                                        cbox_customercurrency.SelectedIndex = 0;
                                        selectedId = 0;
                                        selectedBalance = 0;
                                        operationId = 0;
                                        selectedName = "";
                                        selectedType = "";
                                        selectedCurrency = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Hata!");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Hata!\n" + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bütün bilgileri giriniz!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı Girdi:\n" + ex);
                }
            }
        }

        private void dataview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = Convert.ToInt32(dataview.CurrentRow.Cells[0].Value);
                selectedName = dataview.CurrentRow.Cells[1].Value.ToString();
                tbox_customername.Text = selectedName;
                selectedType = dataview.CurrentRow.Cells[2].Value.ToString();
                if (selectedType == "Musteri")
                {
                    cbox_custoemrtype.SelectedIndex = 1;
                }
                else if (selectedType == "Tedarikci")
                {
                    cbox_custoemrtype.SelectedIndex = 2;
                }
                selectedBalance = Convert.ToDecimal(dataview.CurrentRow.Cells[3].Value);
                selectedCurrency = dataview.CurrentRow.Cells[4].Value.ToString();
                if (selectedCurrency == "TL")
                {
                    cbox_customercurrency.SelectedIndex = 1;
                }
                else if (selectedCurrency == "Dolar")
                {
                    cbox_customercurrency.SelectedIndex = 2;
                }
                else if (selectedCurrency == "Euro")
                {
                    cbox_customercurrency.SelectedIndex = 3;
                }
                setup(3);
            }
            catch
            {
                MessageBox.Show("Müşteri Bulunamadı!");
            }
        }
    }
}
