namespace ILib
{
    partial class homePage
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
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.btn_bookTicket = new System.Windows.Forms.Button();
            this.btn_Reader = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_bookManagement = new System.Windows.Forms.Button();
            this.btn_BookType = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_Author = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navButton1
            // 
            this.navButton1.Caption = "Main Menu";
            this.navButton1.IsMain = true;
            this.navButton1.Name = "navButton1";
            // 
            // navButton3
            // 
            this.navButton3.Caption = "Main Menu";
            this.navButton3.IsMain = true;
            this.navButton3.Name = "navButton3";
            // 
            // btn_bookTicket
            // 
            this.btn_bookTicket.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_bookTicket.Location = new System.Drawing.Point(4, 447);
            this.btn_bookTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bookTicket.Name = "btn_bookTicket";
            this.btn_bookTicket.Size = new System.Drawing.Size(140, 70);
            this.btn_bookTicket.TabIndex = 12;
            this.btn_bookTicket.Text = "Quản lý vé mượn";
            this.btn_bookTicket.UseVisualStyleBackColor = true;
            this.btn_bookTicket.Click += new System.EventHandler(this.btn_bookTicket_Click);
            // 
            // btn_Reader
            // 
            this.btn_Reader.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Reader.Location = new System.Drawing.Point(4, 372);
            this.btn_Reader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reader.Name = "btn_Reader";
            this.btn_Reader.Size = new System.Drawing.Size(140, 70);
            this.btn_Reader.TabIndex = 21;
            this.btn_Reader.Text = "Quản lý bạn đọc";
            this.btn_Reader.UseVisualStyleBackColor = true;
            this.btn_Reader.Click += new System.EventHandler(this.btn_Reader_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Account.Location = new System.Drawing.Point(4, 522);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(140, 70);
            this.btn_Account.TabIndex = 18;
            this.btn_Account.Text = "Quản lý tài khoản";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_bookManagement
            // 
            this.btn_bookManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_bookManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bookManagement.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_bookManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bookManagement.Location = new System.Drawing.Point(4, 145);
            this.btn_bookManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bookManagement.Name = "btn_bookManagement";
            this.btn_bookManagement.Size = new System.Drawing.Size(140, 70);
            this.btn_bookManagement.TabIndex = 11;
            this.btn_bookManagement.Text = "Quản lý sách";
            this.btn_bookManagement.UseVisualStyleBackColor = false;
            this.btn_bookManagement.Click += new System.EventHandler(this.btn_bookManagement_Click);
            // 
            // btn_BookType
            // 
            this.btn_BookType.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_BookType.Location = new System.Drawing.Point(4, 296);
            this.btn_BookType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BookType.Name = "btn_BookType";
            this.btn_BookType.Size = new System.Drawing.Size(140, 70);
            this.btn_BookType.TabIndex = 20;
            this.btn_BookType.Text = "Quản lý loại sách";
            this.btn_BookType.UseVisualStyleBackColor = true;
            this.btn_BookType.Click += new System.EventHandler(this.btn_BookType_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Red;
            this.ButtonExit.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(2, 608);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(140, 50);
            this.ButtonExit.TabIndex = 30;
            this.ButtonExit.Text = "THOÁT";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::ILib.Properties.Resources.logo;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(4, 9);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 120);
            this.logo.TabIndex = 28;
            this.logo.TabStop = false;
            // 
            // btn_Author
            // 
            this.btn_Author.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Author.Location = new System.Drawing.Point(4, 220);
            this.btn_Author.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Size = new System.Drawing.Size(140, 70);
            this.btn_Author.TabIndex = 19;
            this.btn_Author.Text = "Quản lý tác giả";
            this.btn_Author.UseVisualStyleBackColor = true;
            this.btn_Author.Click += new System.EventHandler(this.btn_Author_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Author);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.btn_BookType);
            this.panel1.Controls.Add(this.btn_bookManagement);
            this.panel1.Controls.Add(this.btn_Account);
            this.panel1.Controls.Add(this.btn_Reader);
            this.panel1.Controls.Add(this.btn_bookTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(770, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 668);
            this.panel1.TabIndex = 34;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::ILib.Properties.Resources.landscape_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 668);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private System.Windows.Forms.Button btn_bookTicket;
        private System.Windows.Forms.Button btn_Reader;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_bookManagement;
        private System.Windows.Forms.Button btn_BookType;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_Author;
        public System.Windows.Forms.Panel panel1;
    }
}