namespace UI
{
    partial class CustomersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            FormPanel = new TableLayoutPanel();
            FormMenuPanel = new TableLayoutPanel();
            btn_close = new Button();
            btn_maximize = new Button();
            btn_minimize = new Button();
            pictureBox1 = new PictureBox();
            MainPanel = new TableLayoutPanel();
            MainDownPanel = new TableLayoutPanel();
            dataview = new DataGridView();
            LeftMenuPanel = new TableLayoutPanel();
            btn_opencustomer = new Button();
            btn_balance = new Button();
            btn_add = new Button();
            btn_delete = new Button();
            btn_back = new Button();
            RightMenuPanel = new TableLayoutPanel();
            btn_operation = new Button();
            tbox_customername = new TextBox();
            cbox_custoemrtype = new ComboBox();
            cbox_customercurrency = new ComboBox();
            UpperMenuPanel = new TableLayoutPanel();
            btn_search = new Button();
            tbox_search = new TextBox();
            cbox_type = new ComboBox();
            cbox_currency = new ComboBox();
            cbox_balance = new ComboBox();
            FormPanel.SuspendLayout();
            FormMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            MainDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            LeftMenuPanel.SuspendLayout();
            RightMenuPanel.SuspendLayout();
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
            FormMenuPanel.Controls.Add(btn_close, 4, 0);
            FormMenuPanel.Controls.Add(btn_maximize, 3, 0);
            FormMenuPanel.Controls.Add(btn_minimize, 2, 0);
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
            // btn_close
            // 
            btn_close.Dock = DockStyle.Fill;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1377, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(54, 48);
            btn_close.TabIndex = 3;
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
            btn_maximize.TabIndex = 4;
            btn_maximize.TabStop = false;
            btn_maximize.UseVisualStyleBackColor = true;
            btn_maximize.Click += btn_maximize_Click;
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
            btn_minimize.TabIndex = 5;
            btn_minimize.TabStop = false;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(586, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
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
            // 
            // MainDownPanel
            // 
            MainDownPanel.ColumnCount = 3;
            MainDownPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            MainDownPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainDownPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            MainDownPanel.Controls.Add(dataview, 1, 0);
            MainDownPanel.Controls.Add(LeftMenuPanel, 0, 0);
            MainDownPanel.Controls.Add(RightMenuPanel, 2, 0);
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
            dataGridViewCellStyle3.ForeColor = Color.Red;
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
            // LeftMenuPanel
            // 
            LeftMenuPanel.ColumnCount = 3;
            LeftMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LeftMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.Controls.Add(btn_opencustomer, 1, 1);
            LeftMenuPanel.Controls.Add(btn_balance, 1, 3);
            LeftMenuPanel.Controls.Add(btn_add, 1, 5);
            LeftMenuPanel.Controls.Add(btn_delete, 1, 7);
            LeftMenuPanel.Controls.Add(btn_back, 1, 9);
            LeftMenuPanel.Dock = DockStyle.Fill;
            LeftMenuPanel.Location = new Point(3, 3);
            LeftMenuPanel.Name = "LeftMenuPanel";
            LeftMenuPanel.RowCount = 11;
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.Size = new Size(294, 584);
            LeftMenuPanel.TabIndex = 1;
            // 
            // btn_opencustomer
            // 
            btn_opencustomer.Dock = DockStyle.Fill;
            btn_opencustomer.FlatAppearance.BorderSize = 0;
            btn_opencustomer.FlatStyle = FlatStyle.Flat;
            btn_opencustomer.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_opencustomer.Image = (Image)resources.GetObject("btn_opencustomer.Image");
            btn_opencustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_opencustomer.Location = new Point(23, 23);
            btn_opencustomer.Name = "btn_opencustomer";
            btn_opencustomer.Size = new Size(248, 66);
            btn_opencustomer.TabIndex = 0;
            btn_opencustomer.Text = "Islemler";
            btn_opencustomer.UseVisualStyleBackColor = true;
            btn_opencustomer.Click += btn_opencustomer_Click;
            // 
            // btn_balance
            // 
            btn_balance.Dock = DockStyle.Fill;
            btn_balance.FlatAppearance.BorderSize = 0;
            btn_balance.FlatStyle = FlatStyle.Flat;
            btn_balance.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_balance.Image = (Image)resources.GetObject("btn_balance.Image");
            btn_balance.ImageAlign = ContentAlignment.MiddleLeft;
            btn_balance.Location = new Point(23, 115);
            btn_balance.Name = "btn_balance";
            btn_balance.Size = new Size(248, 66);
            btn_balance.TabIndex = 1;
            btn_balance.Text = "Bakiye";
            btn_balance.UseVisualStyleBackColor = true;
            btn_balance.Click += btn_balance_Click;
            // 
            // btn_add
            // 
            btn_add.Dock = DockStyle.Fill;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(23, 207);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(248, 66);
            btn_add.TabIndex = 2;
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
            btn_delete.Location = new Point(23, 299);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(248, 66);
            btn_delete.TabIndex = 3;
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
            btn_back.Location = new Point(23, 492);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(248, 66);
            btn_back.TabIndex = 4;
            btn_back.Text = "Geri Dön";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // RightMenuPanel
            // 
            RightMenuPanel.ColumnCount = 3;
            RightMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RightMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RightMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RightMenuPanel.Controls.Add(btn_operation, 1, 7);
            RightMenuPanel.Controls.Add(tbox_customername, 1, 1);
            RightMenuPanel.Controls.Add(cbox_custoemrtype, 1, 3);
            RightMenuPanel.Controls.Add(cbox_customercurrency, 1, 5);
            RightMenuPanel.Dock = DockStyle.Fill;
            RightMenuPanel.Location = new Point(1131, 3);
            RightMenuPanel.Name = "RightMenuPanel";
            RightMenuPanel.RowCount = 9;
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightMenuPanel.Size = new Size(294, 584);
            RightMenuPanel.TabIndex = 2;
            // 
            // btn_operation
            // 
            btn_operation.Dock = DockStyle.Fill;
            btn_operation.FlatAppearance.BorderSize = 0;
            btn_operation.FlatStyle = FlatStyle.Flat;
            btn_operation.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_operation.ImageAlign = ContentAlignment.MiddleLeft;
            btn_operation.Location = new Point(23, 345);
            btn_operation.Name = "btn_operation";
            btn_operation.Size = new Size(248, 74);
            btn_operation.TabIndex = 0;
            btn_operation.TabStop = false;
            btn_operation.Text = "Button";
            btn_operation.UseVisualStyleBackColor = true;
            btn_operation.Click += btn_operation_Click;
            // 
            // tbox_customername
            // 
            tbox_customername.BackColor = Color.AliceBlue;
            tbox_customername.Dock = DockStyle.Fill;
            tbox_customername.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_customername.ForeColor = Color.Black;
            tbox_customername.Location = new Point(23, 165);
            tbox_customername.Name = "tbox_customername";
            tbox_customername.PlaceholderText = "Müsteri Adi";
            tbox_customername.Size = new Size(248, 37);
            tbox_customername.TabIndex = 1;
            tbox_customername.TabStop = false;
            // 
            // cbox_custoemrtype
            // 
            cbox_custoemrtype.BackColor = Color.AliceBlue;
            cbox_custoemrtype.Dock = DockStyle.Fill;
            cbox_custoemrtype.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_custoemrtype.ForeColor = Color.Black;
            cbox_custoemrtype.FormattingEnabled = true;
            cbox_custoemrtype.Items.AddRange(new object[] { "Türü Seçiniz", "Musteri", "Tedarikci" });
            cbox_custoemrtype.Location = new Point(23, 225);
            cbox_custoemrtype.Name = "cbox_custoemrtype";
            cbox_custoemrtype.Size = new Size(248, 38);
            cbox_custoemrtype.TabIndex = 2;
            cbox_custoemrtype.TabStop = false;
            // 
            // cbox_customercurrency
            // 
            cbox_customercurrency.BackColor = Color.AliceBlue;
            cbox_customercurrency.Dock = DockStyle.Fill;
            cbox_customercurrency.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_customercurrency.ForeColor = Color.Black;
            cbox_customercurrency.FormattingEnabled = true;
            cbox_customercurrency.Items.AddRange(new object[] { "Para Birimi Seçiniz", "TL", "Dolar", "Euro" });
            cbox_customercurrency.Location = new Point(23, 285);
            cbox_customercurrency.Name = "cbox_customercurrency";
            cbox_customercurrency.Size = new Size(248, 38);
            cbox_customercurrency.TabIndex = 3;
            cbox_customercurrency.TabStop = false;
            // 
            // UpperMenuPanel
            // 
            UpperMenuPanel.ColumnCount = 11;
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpperMenuPanel.Controls.Add(btn_search, 9, 1);
            UpperMenuPanel.Controls.Add(tbox_search, 1, 1);
            UpperMenuPanel.Controls.Add(cbox_type, 3, 1);
            UpperMenuPanel.Controls.Add(cbox_currency, 5, 1);
            UpperMenuPanel.Controls.Add(cbox_balance, 7, 1);
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
            // btn_search
            // 
            btn_search.Dock = DockStyle.Fill;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI Variable Text Semiligh", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(1108, 54);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(294, 34);
            btn_search.TabIndex = 5;
            btn_search.TabStop = false;
            btn_search.Text = "Arama Yap";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // tbox_search
            // 
            tbox_search.BackColor = Color.AliceBlue;
            tbox_search.Dock = DockStyle.Fill;
            tbox_search.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_search.ForeColor = Color.Black;
            tbox_search.Location = new Point(23, 54);
            tbox_search.Name = "tbox_search";
            tbox_search.PlaceholderText = "Arama Yap";
            tbox_search.Size = new Size(294, 37);
            tbox_search.TabIndex = 0;
            tbox_search.TabStop = false;
            // 
            // cbox_type
            // 
            cbox_type.BackColor = Color.AliceBlue;
            cbox_type.Dock = DockStyle.Fill;
            cbox_type.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_type.ForeColor = Color.Black;
            cbox_type.FormattingEnabled = true;
            cbox_type.Items.AddRange(new object[] { "Hepsi", "Müsteriler", "Tedarikçiler" });
            cbox_type.Location = new Point(343, 54);
            cbox_type.Name = "cbox_type";
            cbox_type.Size = new Size(229, 38);
            cbox_type.TabIndex = 1;
            cbox_type.TabStop = false;
            // 
            // cbox_currency
            // 
            cbox_currency.BackColor = Color.AliceBlue;
            cbox_currency.Dock = DockStyle.Fill;
            cbox_currency.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_currency.ForeColor = Color.Black;
            cbox_currency.FormattingEnabled = true;
            cbox_currency.Items.AddRange(new object[] { "Bütün Birimler", "TL", "Dolar", "Euro" });
            cbox_currency.Location = new Point(598, 54);
            cbox_currency.Name = "cbox_currency";
            cbox_currency.Size = new Size(229, 38);
            cbox_currency.TabIndex = 2;
            cbox_currency.TabStop = false;
            // 
            // cbox_balance
            // 
            cbox_balance.BackColor = Color.AliceBlue;
            cbox_balance.Dock = DockStyle.Fill;
            cbox_balance.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_balance.ForeColor = Color.Black;
            cbox_balance.FormattingEnabled = true;
            cbox_balance.Items.AddRange(new object[] { "Bütün Bakiyeler", "Borçlular", "Alacaklılar" });
            cbox_balance.Location = new Point(853, 54);
            cbox_balance.Name = "cbox_balance";
            cbox_balance.Size = new Size(229, 38);
            cbox_balance.TabIndex = 3;
            cbox_balance.TabStop = false;
            // 
            // CustomersMenu
            // 
            AcceptButton = btn_operation;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1440, 810);
            Controls.Add(FormPanel);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomersMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CustomersMenu_Load;
            FormPanel.ResumeLayout(false);
            FormMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            MainDownPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            LeftMenuPanel.ResumeLayout(false);
            RightMenuPanel.ResumeLayout(false);
            RightMenuPanel.PerformLayout();
            UpperMenuPanel.ResumeLayout(false);
            UpperMenuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FormPanel;
        private TableLayoutPanel FormMenuPanel;
        private Button btn_close;
        private Button btn_maximize;
        private Button btn_minimize;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel MainDownPanel;
        private DataGridView dataview;
        private TableLayoutPanel LeftMenuPanel;
        private TableLayoutPanel RightMenuPanel;
        private TableLayoutPanel UpperMenuPanel;
        private TextBox tbox_search;
        private ComboBox cbox_type;
        private ComboBox cbox_currency;
        private ComboBox cbox_balance;
        private Button btn_search;
        private Button btn_opencustomer;
        private Button btn_balance;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_back;
        private Button btn_operation;
        private TextBox tbox_customername;
        private ComboBox cbox_custoemrtype;
        private ComboBox cbox_customercurrency;
        private PictureBox pictureBox1;
    }
}