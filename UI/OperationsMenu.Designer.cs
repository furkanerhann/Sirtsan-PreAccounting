namespace UI
{
    partial class OperationsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            FormPanel = new TableLayoutPanel();
            FormMenuPanel = new TableLayoutPanel();
            btn_minimize = new Button();
            btn_close = new Button();
            btn_maximize = new Button();
            pictureBox1 = new PictureBox();
            MainPanel = new TableLayoutPanel();
            MainDownPanel = new TableLayoutPanel();
            dataview = new DataGridView();
            LeftPanel = new TableLayoutPanel();
            btn_add = new Button();
            btn_delete = new Button();
            btn_back = new Button();
            btn_counts = new Button();
            lbl_info = new Label();
            RightPanel = new TableLayoutPanel();
            DatePanel = new TableLayoutPanel();
            cbox_day = new ComboBox();
            cbox_month = new ComboBox();
            cbox_year = new ComboBox();
            tbox_product = new TextBox();
            tbox_measure = new TextBox();
            tbox_price = new TextBox();
            tbox_nop = new TextBox();
            tbox_payment = new TextBox();
            btn_operation = new Button();
            UpperMenuPanel = new TableLayoutPanel();
            cbox_date = new ComboBox();
            cbox_balance = new ComboBox();
            btn_search = new Button();
            btn_pdf = new Button();
            FormPanel.SuspendLayout();
            FormMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            MainDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            LeftPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            DatePanel.SuspendLayout();
            UpperMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FormPanel
            // 
            FormPanel.ColumnCount = 1;
            FormPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FormPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            FormPanel.Controls.Add(FormMenuPanel, 0, 0);
            FormPanel.Controls.Add(MainPanel, 0, 1);
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(0, 0);
            FormPanel.Name = "FormPanel";
            FormPanel.RowCount = 2;
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FormPanel.Size = new Size(1440, 810);
            FormPanel.TabIndex = 0;
            // 
            // FormMenuPanel
            // 
            FormMenuPanel.ColumnCount = 5;
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FormMenuPanel.Controls.Add(btn_minimize, 2, 0);
            FormMenuPanel.Controls.Add(btn_close, 4, 0);
            FormMenuPanel.Controls.Add(btn_maximize, 3, 0);
            FormMenuPanel.Controls.Add(pictureBox1, 1, 0);
            FormMenuPanel.Dock = DockStyle.Fill;
            FormMenuPanel.Location = new Point(3, 3);
            FormMenuPanel.Name = "FormMenuPanel";
            FormMenuPanel.RowCount = 1;
            FormMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FormMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            FormMenuPanel.Size = new Size(1434, 54);
            FormMenuPanel.TabIndex = 0;
            FormMenuPanel.MouseDown += FormMenuPanel_MouseDown;
            FormMenuPanel.MouseMove += FormMenuPanel_MouseMove;
            // 
            // btn_minimize
            // 
            btn_minimize.Dock = DockStyle.Fill;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(1257, 3);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(54, 48);
            btn_minimize.TabIndex = 6;
            btn_minimize.TabStop = false;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_close
            // 
            btn_close.Dock = DockStyle.Fill;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1377, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(54, 48);
            btn_close.TabIndex = 7;
            btn_close.TabStop = false;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_maximize
            // 
            btn_maximize.Dock = DockStyle.Fill;
            btn_maximize.FlatAppearance.BorderSize = 0;
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.Image = (Image)resources.GetObject("btn_maximize.Image");
            btn_maximize.Location = new Point(1317, 3);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(54, 48);
            btn_maximize.TabIndex = 8;
            btn_maximize.TabStop = false;
            btn_maximize.UseVisualStyleBackColor = true;
            btn_maximize.Click += btn_maximize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(586, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainPanel.Controls.Add(MainDownPanel, 0, 1);
            MainPanel.Controls.Add(UpperMenuPanel, 0, 0);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 63);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            MainPanel.Size = new Size(1434, 744);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // MainDownPanel
            // 
            MainDownPanel.ColumnCount = 3;
            MainDownPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            MainDownPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainDownPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            MainDownPanel.Controls.Add(dataview, 1, 0);
            MainDownPanel.Controls.Add(LeftPanel, 0, 0);
            MainDownPanel.Controls.Add(RightPanel, 2, 0);
            MainDownPanel.Dock = DockStyle.Fill;
            MainDownPanel.Location = new Point(3, 151);
            MainDownPanel.Name = "MainDownPanel";
            MainDownPanel.RowCount = 1;
            MainDownPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainDownPanel.Size = new Size(1428, 590);
            MainDownPanel.TabIndex = 0;
            // 
            // dataview
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataview.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 154, 240);
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataview.DefaultCellStyle = dataGridViewCellStyle3;
            dataview.Dock = DockStyle.Fill;
            dataview.GridColor = Color.AliceBlue;
            dataview.Location = new Point(303, 3);
            dataview.Name = "dataview";
            dataview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Red;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.AliceBlue;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataview.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataview.RowTemplate.Height = 25;
            dataview.Size = new Size(822, 584);
            dataview.TabIndex = 0;
            dataview.TabStop = false;
            dataview.CellDoubleClick += dataview_CellDoubleClick;
            // 
            // LeftPanel
            // 
            LeftPanel.ColumnCount = 3;
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LeftPanel.Controls.Add(btn_add, 1, 1);
            LeftPanel.Controls.Add(btn_delete, 1, 3);
            LeftPanel.Controls.Add(btn_back, 1, 7);
            LeftPanel.Controls.Add(btn_counts, 1, 5);
            LeftPanel.Controls.Add(lbl_info, 1, 6);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.RowCount = 9;
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftPanel.Size = new Size(294, 584);
            LeftPanel.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Dock = DockStyle.Fill;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(23, 23);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(248, 69);
            btn_add.TabIndex = 0;
            btn_add.Text = "Yeni";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Fill;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(23, 118);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(248, 69);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Sil";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_back
            // 
            btn_back.Dock = DockStyle.Fill;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(23, 489);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(248, 69);
            btn_back.TabIndex = 3;
            btn_back.Text = "Geri Dön";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_counts
            // 
            btn_counts.Dock = DockStyle.Fill;
            btn_counts.FlatAppearance.BorderSize = 0;
            btn_counts.FlatStyle = FlatStyle.Flat;
            btn_counts.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_counts.Image = (Image)resources.GetObject("btn_counts.Image");
            btn_counts.ImageAlign = ContentAlignment.MiddleLeft;
            btn_counts.Location = new Point(23, 213);
            btn_counts.Name = "btn_counts";
            btn_counts.Size = new Size(248, 69);
            btn_counts.TabIndex = 2;
            btn_counts.Text = "Özet";
            btn_counts.UseVisualStyleBackColor = true;
            btn_counts.Click += btn_counts_Click;
            // 
            // lbl_info
            // 
            lbl_info.Anchor = AnchorStyles.Top;
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Segoe UI Variable Text Semiligh", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_info.Location = new Point(125, 285);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(43, 26);
            lbl_info.TabIndex = 3;
            lbl_info.Text = "info";
            lbl_info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RightPanel
            // 
            RightPanel.ColumnCount = 3;
            RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RightPanel.Controls.Add(DatePanel, 1, 1);
            RightPanel.Controls.Add(tbox_product, 1, 3);
            RightPanel.Controls.Add(tbox_measure, 1, 5);
            RightPanel.Controls.Add(tbox_price, 1, 7);
            RightPanel.Controls.Add(tbox_nop, 1, 9);
            RightPanel.Controls.Add(tbox_payment, 1, 11);
            RightPanel.Controls.Add(btn_operation, 1, 13);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(1131, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.RowCount = 15;
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightPanel.Size = new Size(294, 584);
            RightPanel.TabIndex = 2;
            // 
            // DatePanel
            // 
            DatePanel.ColumnCount = 5;
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            DatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            DatePanel.Controls.Add(cbox_day, 0, 0);
            DatePanel.Controls.Add(cbox_month, 2, 0);
            DatePanel.Controls.Add(cbox_year, 4, 0);
            DatePanel.Dock = DockStyle.Fill;
            DatePanel.Location = new Point(23, 75);
            DatePanel.Name = "DatePanel";
            DatePanel.RowCount = 1;
            DatePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DatePanel.Size = new Size(248, 34);
            DatePanel.TabIndex = 0;
            // 
            // cbox_day
            // 
            cbox_day.BackColor = Color.AliceBlue;
            cbox_day.Dock = DockStyle.Fill;
            cbox_day.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_day.ForeColor = Color.Black;
            cbox_day.FormattingEnabled = true;
            cbox_day.Items.AddRange(new object[] { "Gün", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbox_day.Location = new Point(3, 3);
            cbox_day.Name = "cbox_day";
            cbox_day.Size = new Size(51, 38);
            cbox_day.TabIndex = 4;
            // 
            // cbox_month
            // 
            cbox_month.BackColor = Color.AliceBlue;
            cbox_month.Dock = DockStyle.Fill;
            cbox_month.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_month.ForeColor = Color.Black;
            cbox_month.FormattingEnabled = true;
            cbox_month.Items.AddRange(new object[] { "Ay", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbox_month.Location = new Point(70, 3);
            cbox_month.Name = "cbox_month";
            cbox_month.Size = new Size(51, 38);
            cbox_month.TabIndex = 5;
            // 
            // cbox_year
            // 
            cbox_year.BackColor = Color.AliceBlue;
            cbox_year.Dock = DockStyle.Fill;
            cbox_year.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_year.ForeColor = Color.Black;
            cbox_year.FormattingEnabled = true;
            cbox_year.Items.AddRange(new object[] { "Yıl", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            cbox_year.Location = new Point(137, 3);
            cbox_year.Name = "cbox_year";
            cbox_year.Size = new Size(108, 38);
            cbox_year.TabIndex = 6;
            // 
            // tbox_product
            // 
            tbox_product.BackColor = Color.AliceBlue;
            tbox_product.Dock = DockStyle.Fill;
            tbox_product.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_product.ForeColor = Color.Black;
            tbox_product.Location = new Point(23, 135);
            tbox_product.Name = "tbox_product";
            tbox_product.PlaceholderText = "Ürün";
            tbox_product.Size = new Size(248, 37);
            tbox_product.TabIndex = 7;
            // 
            // tbox_measure
            // 
            tbox_measure.BackColor = Color.AliceBlue;
            tbox_measure.Dock = DockStyle.Fill;
            tbox_measure.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_measure.ForeColor = Color.Black;
            tbox_measure.Location = new Point(23, 195);
            tbox_measure.Name = "tbox_measure";
            tbox_measure.PlaceholderText = "Birim";
            tbox_measure.Size = new Size(248, 37);
            tbox_measure.TabIndex = 8;
            // 
            // tbox_price
            // 
            tbox_price.BackColor = Color.AliceBlue;
            tbox_price.Dock = DockStyle.Fill;
            tbox_price.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_price.ForeColor = Color.Black;
            tbox_price.Location = new Point(23, 255);
            tbox_price.Name = "tbox_price";
            tbox_price.PlaceholderText = "Birim Fiyat";
            tbox_price.Size = new Size(248, 37);
            tbox_price.TabIndex = 9;
            // 
            // tbox_nop
            // 
            tbox_nop.BackColor = Color.AliceBlue;
            tbox_nop.Dock = DockStyle.Fill;
            tbox_nop.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_nop.ForeColor = Color.Black;
            tbox_nop.Location = new Point(23, 315);
            tbox_nop.Name = "tbox_nop";
            tbox_nop.PlaceholderText = "Adet";
            tbox_nop.Size = new Size(248, 37);
            tbox_nop.TabIndex = 10;
            // 
            // tbox_payment
            // 
            tbox_payment.BackColor = Color.AliceBlue;
            tbox_payment.Dock = DockStyle.Fill;
            tbox_payment.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_payment.ForeColor = Color.Black;
            tbox_payment.Location = new Point(23, 375);
            tbox_payment.Name = "tbox_payment";
            tbox_payment.PlaceholderText = "Ödeme";
            tbox_payment.Size = new Size(248, 37);
            tbox_payment.TabIndex = 11;
            // 
            // btn_operation
            // 
            btn_operation.Dock = DockStyle.Fill;
            btn_operation.FlatAppearance.BorderSize = 0;
            btn_operation.FlatStyle = FlatStyle.Flat;
            btn_operation.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_operation.Location = new Point(23, 435);
            btn_operation.Name = "btn_operation";
            btn_operation.Size = new Size(248, 74);
            btn_operation.TabIndex = 12;
            btn_operation.Text = "Button";
            btn_operation.UseVisualStyleBackColor = true;
            btn_operation.Click += btn_operation_Click;
            // 
            // UpperMenuPanel
            // 
            UpperMenuPanel.ColumnCount = 9;
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.Controls.Add(cbox_date, 1, 1);
            UpperMenuPanel.Controls.Add(cbox_balance, 3, 1);
            UpperMenuPanel.Controls.Add(btn_search, 5, 1);
            UpperMenuPanel.Controls.Add(btn_pdf, 7, 1);
            UpperMenuPanel.Dock = DockStyle.Fill;
            UpperMenuPanel.Location = new Point(3, 3);
            UpperMenuPanel.Name = "UpperMenuPanel";
            UpperMenuPanel.RowCount = 3;
            UpperMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            UpperMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            UpperMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            UpperMenuPanel.Size = new Size(1428, 142);
            UpperMenuPanel.TabIndex = 1;
            // 
            // cbox_date
            // 
            cbox_date.BackColor = Color.AliceBlue;
            cbox_date.Dock = DockStyle.Fill;
            cbox_date.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_date.ForeColor = Color.Black;
            cbox_date.FormattingEnabled = true;
            cbox_date.Items.AddRange(new object[] { "Hepsi", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            cbox_date.Location = new Point(23, 54);
            cbox_date.Name = "cbox_date";
            cbox_date.Size = new Size(326, 38);
            cbox_date.TabIndex = 0;
            cbox_date.TabStop = false;
            // 
            // cbox_balance
            // 
            cbox_balance.BackColor = Color.AliceBlue;
            cbox_balance.Dock = DockStyle.Fill;
            cbox_balance.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_balance.ForeColor = Color.Black;
            cbox_balance.FormattingEnabled = true;
            cbox_balance.Items.AddRange(new object[] { "Hepsi", "Borçlanmalar", "Ödemeler" });
            cbox_balance.Location = new Point(375, 54);
            cbox_balance.Name = "cbox_balance";
            cbox_balance.Size = new Size(326, 38);
            cbox_balance.TabIndex = 1;
            cbox_balance.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.Dock = DockStyle.Fill;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI Variable Text Semiligh", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(727, 54);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(326, 34);
            btn_search.TabIndex = 2;
            btn_search.TabStop = false;
            btn_search.Text = "Filtrele";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_pdf
            // 
            btn_pdf.Dock = DockStyle.Fill;
            btn_pdf.FlatAppearance.BorderSize = 0;
            btn_pdf.FlatStyle = FlatStyle.Flat;
            btn_pdf.Font = new Font("Segoe UI Variable Text Semiligh", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pdf.Image = (Image)resources.GetObject("btn_pdf.Image");
            btn_pdf.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pdf.Location = new Point(1079, 54);
            btn_pdf.Name = "btn_pdf";
            btn_pdf.Size = new Size(326, 34);
            btn_pdf.TabIndex = 3;
            btn_pdf.TabStop = false;
            btn_pdf.Text = "PDF Yazdır";
            btn_pdf.UseVisualStyleBackColor = true;
            btn_pdf.Click += btn_pdf_Click;
            // 
            // OperationsMenu
            // 
            AcceptButton = btn_operation;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 57, 112);
            ClientSize = new Size(1440, 810);
            Controls.Add(FormPanel);
            ForeColor = Color.FromArgb(51, 154, 240);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OperationsMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OperationsMenu";
            Load += OperationsMenu_Load;
            FormPanel.ResumeLayout(false);
            FormMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            MainDownPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            DatePanel.ResumeLayout(false);
            UpperMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FormPanel;
        private TableLayoutPanel FormMenuPanel;
        private Button btn_minimize;
        private Button btn_close;
        private Button btn_maximize;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel MainDownPanel;
        private DataGridView dataview;
        private TableLayoutPanel LeftPanel;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_back;
        private TableLayoutPanel RightPanel;
        private TableLayoutPanel DatePanel;
        private ComboBox cbox_day;
        private ComboBox cbox_month;
        private ComboBox cbox_year;
        private TextBox tbox_product;
        private TextBox tbox_measure;
        private TextBox tbox_price;
        private TextBox tbox_nop;
        private TextBox tbox_payment;
        private Button btn_operation;
        private TableLayoutPanel UpperMenuPanel;
        private ComboBox cbox_date;
        private ComboBox cbox_balance;
        private Button btn_search;
        private Button btn_pdf;
        private Label lbl_info;
        private Button btn_counts;
        private PictureBox pictureBox1;
    }
}