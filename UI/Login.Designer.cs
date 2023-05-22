namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            FormPanel = new TableLayoutPanel();
            FormMenuPanel = new TableLayoutPanel();
            btn_close = new Button();
            btn_maximize = new Button();
            btn_minimize = new Button();
            pictureBox1 = new PictureBox();
            MainPanel = new TableLayoutPanel();
            btn_login = new Button();
            btn_newdb = new Button();
            tbox_pwd = new TextBox();
            tbox_user = new TextBox();
            tbox_db = new TextBox();
            tbox_host = new TextBox();
            tbox_newhost = new TextBox();
            tbox_newdb = new TextBox();
            tbox_newuser = new TextBox();
            tbox_newpwd = new TextBox();
            FormPanel.SuspendLayout();
            FormMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FormPanel
            // 
            FormPanel.AutoSize = true;
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
            btn_close.TabIndex = 0;
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
            btn_maximize.TabIndex = 1;
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
            btn_minimize.TabIndex = 2;
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 5;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            MainPanel.Controls.Add(btn_login, 3, 9);
            MainPanel.Controls.Add(btn_newdb, 1, 9);
            MainPanel.Controls.Add(tbox_pwd, 3, 7);
            MainPanel.Controls.Add(tbox_user, 3, 5);
            MainPanel.Controls.Add(tbox_db, 3, 3);
            MainPanel.Controls.Add(tbox_host, 3, 1);
            MainPanel.Controls.Add(tbox_newhost, 1, 1);
            MainPanel.Controls.Add(tbox_newdb, 1, 3);
            MainPanel.Controls.Add(tbox_newuser, 1, 5);
            MainPanel.Controls.Add(tbox_newpwd, 1, 7);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 63);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 11;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MainPanel.Size = new Size(1434, 744);
            MainPanel.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(790, 455);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(352, 74);
            btn_login.TabIndex = 5;
            btn_login.Text = "Giris Yap";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_newdb
            // 
            btn_newdb.FlatAppearance.BorderSize = 0;
            btn_newdb.FlatStyle = FlatStyle.Flat;
            btn_newdb.Font = new Font("Segoe UI Variable Text Semiligh", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_newdb.Image = (Image)resources.GetObject("btn_newdb.Image");
            btn_newdb.ImageAlign = ContentAlignment.MiddleLeft;
            btn_newdb.Location = new Point(289, 455);
            btn_newdb.Name = "btn_newdb";
            btn_newdb.Size = new Size(352, 74);
            btn_newdb.TabIndex = 10;
            btn_newdb.Text = "Yeni Veri Tabanı";
            btn_newdb.UseVisualStyleBackColor = true;
            btn_newdb.Click += btn_newdb_Click;
            // 
            // tbox_pwd
            // 
            tbox_pwd.BackColor = Color.AliceBlue;
            tbox_pwd.Dock = DockStyle.Fill;
            tbox_pwd.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_pwd.ForeColor = Color.Black;
            tbox_pwd.Location = new Point(790, 395);
            tbox_pwd.Name = "tbox_pwd";
            tbox_pwd.PlaceholderText = "parola";
            tbox_pwd.Size = new Size(352, 37);
            tbox_pwd.TabIndex = 4;
            tbox_pwd.UseSystemPasswordChar = true;
            // 
            // tbox_user
            // 
            tbox_user.BackColor = Color.AliceBlue;
            tbox_user.Dock = DockStyle.Fill;
            tbox_user.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_user.ForeColor = Color.Black;
            tbox_user.Location = new Point(790, 335);
            tbox_user.Name = "tbox_user";
            tbox_user.PlaceholderText = "kullanıcı adı";
            tbox_user.Size = new Size(352, 37);
            tbox_user.TabIndex = 3;
            // 
            // tbox_db
            // 
            tbox_db.BackColor = Color.AliceBlue;
            tbox_db.Dock = DockStyle.Fill;
            tbox_db.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_db.ForeColor = Color.Black;
            tbox_db.Location = new Point(790, 275);
            tbox_db.Name = "tbox_db";
            tbox_db.PlaceholderText = "veri tabanı";
            tbox_db.Size = new Size(352, 37);
            tbox_db.TabIndex = 2;
            // 
            // tbox_host
            // 
            tbox_host.BackColor = Color.AliceBlue;
            tbox_host.Dock = DockStyle.Fill;
            tbox_host.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_host.ForeColor = Color.Black;
            tbox_host.Location = new Point(790, 215);
            tbox_host.Name = "tbox_host";
            tbox_host.PlaceholderText = "ip adresi";
            tbox_host.Size = new Size(352, 37);
            tbox_host.TabIndex = 1;
            tbox_host.Text = "localhost";
            // 
            // tbox_newhost
            // 
            tbox_newhost.BackColor = Color.AliceBlue;
            tbox_newhost.Dock = DockStyle.Fill;
            tbox_newhost.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_newhost.ForeColor = Color.Black;
            tbox_newhost.Location = new Point(289, 215);
            tbox_newhost.Name = "tbox_newhost";
            tbox_newhost.PlaceholderText = "ip adresi";
            tbox_newhost.Size = new Size(352, 37);
            tbox_newhost.TabIndex = 6;
            tbox_newhost.Text = "localhost";
            // 
            // tbox_newdb
            // 
            tbox_newdb.BackColor = Color.AliceBlue;
            tbox_newdb.Dock = DockStyle.Fill;
            tbox_newdb.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_newdb.ForeColor = Color.Black;
            tbox_newdb.Location = new Point(289, 275);
            tbox_newdb.Name = "tbox_newdb";
            tbox_newdb.PlaceholderText = "veri tabanı";
            tbox_newdb.Size = new Size(352, 37);
            tbox_newdb.TabIndex = 7;
            // 
            // tbox_newuser
            // 
            tbox_newuser.BackColor = Color.AliceBlue;
            tbox_newuser.Dock = DockStyle.Fill;
            tbox_newuser.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_newuser.ForeColor = Color.Black;
            tbox_newuser.Location = new Point(289, 335);
            tbox_newuser.Name = "tbox_newuser";
            tbox_newuser.PlaceholderText = "kullanıcı adı";
            tbox_newuser.Size = new Size(352, 37);
            tbox_newuser.TabIndex = 8;
            // 
            // tbox_newpwd
            // 
            tbox_newpwd.BackColor = Color.AliceBlue;
            tbox_newpwd.Dock = DockStyle.Fill;
            tbox_newpwd.Font = new Font("Elephant", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_newpwd.ForeColor = Color.Black;
            tbox_newpwd.Location = new Point(289, 395);
            tbox_newpwd.Name = "tbox_newpwd";
            tbox_newpwd.PlaceholderText = "parola";
            tbox_newpwd.Size = new Size(352, 37);
            tbox_newpwd.TabIndex = 9;
            tbox_newpwd.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1440, 810);
            Controls.Add(FormPanel);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            FormPanel.ResumeLayout(false);
            FormMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel FormPanel;
        private TableLayoutPanel FormMenuPanel;
        private Button btn_close;
        private Button btn_maximize;
        private Button btn_minimize;
        private TableLayoutPanel MainPanel;
        private Button btn_login;
        private Button btn_newdb;
        private TextBox tbox_pwd;
        private TextBox tbox_user;
        private TextBox tbox_db;
        private TextBox tbox_host;
        private TextBox tbox_newhost;
        private TextBox tbox_newdb;
        private TextBox tbox_newuser;
        private TextBox tbox_newpwd;
        private PictureBox pictureBox1;
    }
}