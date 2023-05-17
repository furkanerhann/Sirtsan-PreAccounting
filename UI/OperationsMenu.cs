using Core;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;

namespace UI
{
    public partial class OperationsMenu : Form
    {
        public OperationsMenu()
        {
            InitializeComponent();
        }
        public string conString;
        public int customerId;
        public string customerName;
        public string customerType;
        public string customerCurrency;
        public decimal customerBalance;
        private int selectedId;
        private int operationId;
        private decimal op_financalimpact;
        private void getData(int date = 0, int balance = 0)
        {
            SqlConnection con = new SqlConnection(conString);
            string comstring = "SELECT Islem_No, Tarih, Urun, Birim, Birim_Fiyat, Adet, Bakiye, Odeme, Genel_Toplam FROM Islemler WHERE Musteri_No = " + customerId;
            if (date == 0 && balance == 0)
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comstring, con);
                DataSet operationdata = new DataSet();
                da.Fill(operationdata, "Operations");
                dataview.DataSource = operationdata.Tables["Operations"];
                con.Close();
            }
            else
            {
                comstring += " AND ";
                int addand = 0;
                if (date != 0)
                {
                    comstring += "Tarih LIKE '%" + date + "%'";
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
                        comstring += "Genel_Toplam < 0";
                    }
                    else if (balance == 2)
                    {
                        comstring += "Genel_Toplam > 0";
                    }
                    addand = 1;
                }
                comstring += ";";
                con.Open();
                SqlCommand com = new SqlCommand(comstring, con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet operationdata = new DataSet();
                da.Fill(operationdata, "Operations");
                dataview.DataSource = operationdata.Tables["Operations"];
                con.Close();
            }
        }
        private void setup(int setupId)
        {
            if (setupId == 0)
            {
                cbox_day.Visible = false;
                cbox_month.Visible = false;
                cbox_year.Visible = false;
                tbox_product.Visible = false;
                tbox_measure.Visible = false;
                tbox_price.Visible = false;
                tbox_nop.Visible = false;
                tbox_payment.Visible = false;
                btn_operation.Visible = false;
            }
            else if (setupId == 1)
            {
                cbox_date.SelectedIndex = 0;
                cbox_balance.SelectedIndex = 0;
                lbl_info.Text = customerName + "\n" + "Bakiyesi: " + customerBalance.ToString();
            }
            else if (setupId == 2)
            {
                cbox_day.Visible = true;
                cbox_day.SelectedIndex = 0;
                cbox_month.Visible = true;
                cbox_month.SelectedIndex = 0;
                cbox_year.Visible = true;
                cbox_year.SelectedIndex = 0;
                tbox_product.Visible = true;
                tbox_product.Text = "";
                tbox_measure.Visible = true;
                tbox_measure.Text = "";
                tbox_price.Visible = true;
                tbox_price.Text = "";
                tbox_nop.Visible = true;
                tbox_nop.Text = "";
                tbox_payment.Visible = true;
                tbox_payment.Text = "";
                btn_operation.Visible = true;
                btn_operation.Text = "Yeni Ekle";
                operationId = 1;
            }
            else if (setupId == 3)
            {
                cbox_day.Visible = true;
                cbox_month.Visible = true;
                cbox_year.Visible = true;
                tbox_product.Visible = true;
                tbox_measure.Visible = true;
                tbox_price.Visible = true;
                tbox_nop.Visible = true;
                tbox_payment.Visible = true;
                btn_operation.Visible = true;
                btn_operation.Text = "Güncelle";
                operationId = 2;
            }
        }
        private void OperationsMenu_Load(object sender, EventArgs e)
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
                        string comstring = "DELETE FROM Islemler WHERE Islem_No = " + selectedId + ";";
                        con.Open();
                        SqlCommand com = new SqlCommand(comstring, con);
                        com.ExecuteNonQuery();
                        customerBalance = BalanceUpdater.updateBalance(conString, customerId, (-1 * op_financalimpact), current_balance: customerBalance);
                        setup(0);
                        setup(1);
                        getData();
                        cbox_day.SelectedIndex = 0;
                        cbox_month.SelectedIndex = 0;
                        cbox_year.SelectedIndex = 0;
                        tbox_product.Text = "";
                        tbox_measure.Text = "";
                        tbox_price.Text = "";
                        tbox_nop.Text = "";
                        tbox_payment.Text = "";
                        selectedId = 0;
                        operationId = 0;
                        op_financalimpact = 0;
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
            CustomersMenu newform = new CustomersMenu();
            newform.conString = conString;
            newform.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int d = cbox_date.SelectedIndex;
            if (d != 0)
            {
                d = Convert.ToInt32(cbox_date.Text);
            }
            int b = cbox_balance.SelectedIndex;
            getData(date: d, balance: b);
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (dataview.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font1 = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font font3 = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font font4 = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Hata!\n" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataview.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataview.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText.Replace("_", " "), font3));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataview.Rows)
                            {
                                foreach (DataGridViewCell rowcell in row.Cells)
                                {
                                    if (rowcell.Value == null)
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(" ", font3));
                                        pdfTable.AddCell(cell);
                                    }
                                    else
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(rowcell.Value.ToString(), font3));
                                        pdfTable.AddCell(cell);
                                    }
                                }
                            }

                            Paragraph p0 = new Paragraph(new Chunk("          ", font3));
                            p0.Alignment = Element.ALIGN_CENTER;
                            Paragraph p1 = new Paragraph(new Chunk("SIRTSAN", font1));
                            p1.Alignment = Element.ALIGN_CENTER;
                            Paragraph p2 = new Paragraph(new Chunk("cari hesap ekstresi", font4));
                            p2.Alignment = Element.ALIGN_CENTER;
                            Paragraph p3 = new Paragraph(new Chunk("Tel: +90 533 514 31 86     -     Mail: semiherhann@gmail.com     -     WebSite: sirtsan.com", font3));
                            p3.Alignment = Element.ALIGN_CENTER;
                            Paragraph p4 = new Paragraph(new Chunk(customerName, font2));
                            p4.Alignment = Element.ALIGN_LEFT;
                            Paragraph p5 = new Paragraph(new Chunk("Bakiye: " + customerBalance.ToString(), font2));
                            p5.Alignment = Element.ALIGN_RIGHT;
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(p1);
                                pdfDoc.Add(p2);
                                pdfDoc.Add(p3);
                                pdfDoc.Add(p4);
                                pdfDoc.Add(p0);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(p0);
                                pdfDoc.Add(p5);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dosya Başarı ile kaydedildi!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata!\n" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce işlem ekleyiniz", "Info");
            }
        }

        private void btn_operation_Click(object sender, EventArgs e)
        {
            if (operationId == 1)
            {
                try
                {
                    string day = cbox_day.Text;
                    string month = cbox_month.Text;
                    string year = cbox_year.Text;
                    string product = tbox_product.Text;
                    string measure = tbox_measure.Text;
                    decimal price = Convert.ToDecimal(tbox_price.Text.Replace(".", ","));
                    int nop = Convert.ToInt32(tbox_nop.Text);
                    decimal totalprice = price * nop;
                    decimal payment = Convert.ToDecimal(tbox_payment.Text.Replace(".", ","));
                    decimal financalimpact = payment - totalprice;
                    if (customerType == "Tedarikci")
                    {
                        financalimpact *= -1;
                    }
                    if (day != "Gün" && month != "Ay" && year != "Yıl")
                    {
                        string date = day + "." + month + "." + year;
                        string comstring = "INSERT INTO Islemler (Musteri_No, Tarih, Urun, Birim, Birim_Fiyat, Adet, Bakiye, Odeme, Genel_Toplam) VALUES(@cid, @d, @pr, @prt, @prp, @nop, @tp, @p, @fi)";
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            try
                            {
                                con.Open();
                                using (SqlCommand com = new SqlCommand(comstring, con))
                                {
                                    com.Parameters.Add("@cid", SqlDbType.Int).Value = customerId;
                                    com.Parameters.Add("@d", SqlDbType.NVarChar).Value = date;
                                    com.Parameters.Add("@pr", SqlDbType.NVarChar).Value = product;
                                    com.Parameters.Add("@prt", SqlDbType.NVarChar).Value = measure;
                                    com.Parameters.Add("@prp", SqlDbType.Decimal).Value = price;
                                    com.Parameters.Add("@nop", SqlDbType.Int).Value = nop;
                                    com.Parameters.Add("@tp", SqlDbType.Decimal).Value = totalprice;
                                    com.Parameters.Add("@p", SqlDbType.Decimal).Value = payment;
                                    com.Parameters.Add("@fi", SqlDbType.Decimal).Value = financalimpact;
                                    customerBalance = Convert.ToDecimal(BalanceUpdater.updateBalance(conString, customerId, financalimpact, current_balance: customerBalance));
                                    int rowsAdded = com.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        setup(0);
                                        setup(1);
                                        getData();
                                        cbox_day.SelectedIndex = 0;
                                        cbox_month.SelectedIndex = 0;
                                        cbox_year.SelectedIndex = 0;
                                        tbox_product.Text = "";
                                        tbox_measure.Text = "";
                                        tbox_price.Text = "";
                                        tbox_nop.Text = "";
                                        tbox_payment.Text = "";
                                        selectedId = 0;
                                        operationId = 0;
                                        op_financalimpact = 0;
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
                        MessageBox.Show("Lütfen geçerli bir tarih seçiniz!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı Girdi:\n" + ex);
                }
            }
            else if (operationId == 2)
            {
                try
                {
                    string day = cbox_day.Text;
                    string month = cbox_month.Text;
                    string year = cbox_year.Text;
                    string product = tbox_product.Text;
                    string measure = tbox_measure.Text;
                    decimal price = Convert.ToDecimal(tbox_price.Text.Replace(".", ","));
                    int nop = Convert.ToInt32(tbox_nop.Text);
                    decimal totalprice = price * nop;
                    decimal payment = Convert.ToDecimal(tbox_payment.Text.Replace(".", ","));
                    decimal financalimpact = payment - totalprice;
                    if (customerType == "Tedarikci")
                    {
                        financalimpact *= -1;
                    }
                    if (day != "Gün" && month != "Ay" && year != "Yıl")
                    {
                        string date = day + "." + month + "." + year;
                        string comstring = "UPDATE Islemler SET Tarih = @d, Urun = @prd, Birim = @m, Birim_Fiyat = @prc, Adet = @nop, Bakiye = @tp, Odeme = @p, Genel_Toplam = @fi WHERE Islem_No = " + selectedId + ";";
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            try
                            {
                                con.Open();
                                using (SqlCommand com = new SqlCommand(comstring, con))
                                {
                                    com.Parameters.Add("@d", SqlDbType.NVarChar).Value = date;
                                    com.Parameters.Add("@prd", SqlDbType.NVarChar).Value = product;
                                    com.Parameters.Add("@m", SqlDbType.NVarChar).Value = measure;
                                    com.Parameters.Add("@prc", SqlDbType.Decimal).Value = price;
                                    com.Parameters.Add("@nop", SqlDbType.Int).Value = nop;
                                    com.Parameters.Add("@tp", SqlDbType.Decimal).Value = totalprice;
                                    com.Parameters.Add("@p", SqlDbType.Decimal).Value = payment;
                                    com.Parameters.Add("@fi", SqlDbType.Decimal).Value = financalimpact;
                                    customerBalance = Convert.ToDecimal(BalanceUpdater.updateBalance(conString, customerId, financalimpact, old_balance: op_financalimpact, current_balance: customerBalance));
                                    int rowsAdded = com.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        setup(0);
                                        setup(1);
                                        getData();
                                        cbox_day.SelectedIndex = 0;
                                        cbox_month.SelectedIndex = 0;
                                        cbox_year.SelectedIndex = 0;
                                        tbox_product.Text = "";
                                        tbox_measure.Text = "";
                                        tbox_price.Text = "";
                                        tbox_nop.Text = "";
                                        tbox_payment.Text = "";
                                        selectedId = 0;
                                        operationId = 0;
                                        op_financalimpact = 0;
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
                        MessageBox.Show("Lütfen geçerli bir tarih seçiniz!");
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
                try
                {
                    string op_date = dataview.CurrentRow.Cells[1].Value.ToString();
                    string day = op_date.Substring(0, 2);
                    string month = op_date.Substring(3, 2);
                    string year = op_date.Substring(6, 4);
                    cbox_day.SelectedIndex = Convert.ToInt32(day);
                    cbox_month.SelectedIndex = Convert.ToInt32(month);
                    cbox_year.SelectedIndex = (Convert.ToInt32(year) - 2019);
                }
                catch
                {
                    cbox_day.SelectedIndex = 0;
                    cbox_month.SelectedIndex = 0;
                    cbox_year.SelectedIndex = 0;
                }
                tbox_product.Text = dataview.CurrentRow.Cells[2].Value.ToString();
                tbox_measure.Text = dataview.CurrentRow.Cells[3].Value.ToString();
                tbox_price.Text = dataview.CurrentRow.Cells[4].Value.ToString();
                tbox_nop.Text = dataview.CurrentRow.Cells[5].Value.ToString();
                tbox_payment.Text = dataview.CurrentRow.Cells[7].Value.ToString();
                op_financalimpact = Convert.ToDecimal(dataview.CurrentRow.Cells[8].Value);
                setup(3);
            }
            catch
            {
                MessageBox.Show("İşlem Bulunamadı!");
            }
        }

        private void btn_counts_Click(object sender, EventArgs e)
        {
            List<string> list_of_product = new List<string>();
            List<string> list_of_measure = new List<string>();
            List<int> list_of_nop = new List<int>();
            decimal total_payment = 0;
            decimal payment = 0;
            foreach (DataGridViewRow item in dataview.Rows)
            {
                var x = item.Cells[2].Value;
                var y = item.Cells[3].Value;
                var z = item.Cells[5].Value;
                var r = item.Cells[6].Value;
                var p = item.Cells[7].Value;
                if (x != null && y != null && z != null)
                {
                    list_of_measure.Add(y.ToString());
                    list_of_product.Add(x.ToString());
                    total_payment += Convert.ToDecimal(r);
                    list_of_nop.Add(Convert.ToInt32(z));
                }
                if (p != null)
                {
                    payment += Convert.ToDecimal(p);
                }
            }
            List<string> list_of_products = new List<string>();
            List<string> list_of_measures = new List<string>();
            List<int> list_of_nops = new List<int>();
            for (int i = 0; i < list_of_product.Count; i++)
            {
                if (list_of_nop[i] != 0)
                {
                    int counter = 0;
                    int address = 0;
                    for (int j = 0; j < list_of_products.Count; j++)
                    {
                        if (list_of_product[i] == list_of_products[j] && list_of_measure[i] == list_of_measures[j])
                        {
                            counter++;
                            address = j;
                            break;
                        }
                    }
                    if (counter == 0)
                    {
                        list_of_products.Add(list_of_product[i]);
                        list_of_nops.Add(list_of_nop[i]);
                        list_of_measures.Add(list_of_measure[i]);
                    }
                    else if (counter == 1)
                    {
                        list_of_nops[address] += list_of_nop[i];
                    }
                }
            }
            string message = "Toplam İşlem Haznesi\n----------\n";
            for (int i = 0; i < list_of_products.Count; i++)
            {
                message += list_of_products[i] + ": " + list_of_nops[i].ToString() + " " + list_of_measures[i] + "\n";
            }
            message += "----------\nToplam Ödeme: " + total_payment.ToString() + "\nYapılan Ödeme: " + payment.ToString() + "\nGenel Durum: " + (payment - total_payment).ToString();
            MessageBox.Show(message);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
