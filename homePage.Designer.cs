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
            this.components = new System.ComponentModel.Container();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.navButton1 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.btn_bookManagement = new System.Windows.Forms.Button();
            this.btn_bookTicket = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_Author = new System.Windows.Forms.Button();
            this.btn_BookType = new System.Windows.Forms.Button();
            this.btn_Reader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 90);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(982, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 753);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(982, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 90);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 663);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(982, 90);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 663);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
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
            // btn_bookManagement
            // 
            this.btn_bookManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_bookManagement.Location = new System.Drawing.Point(100, 12);
            this.btn_bookManagement.Name = "btn_bookManagement";
            this.btn_bookManagement.Size = new System.Drawing.Size(120, 62);
            this.btn_bookManagement.TabIndex = 11;
            this.btn_bookManagement.Text = "Quản lý sách";
            this.btn_bookManagement.UseVisualStyleBackColor = true;
            this.btn_bookManagement.Click += new System.EventHandler(this.btn_bookManagement_Click);
            // 
            // btn_bookTicket
            // 
            this.btn_bookTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_bookTicket.Location = new System.Drawing.Point(604, 12);
            this.btn_bookTicket.Name = "btn_bookTicket";
            this.btn_bookTicket.Size = new System.Drawing.Size(120, 62);
            this.btn_bookTicket.TabIndex = 12;
            this.btn_bookTicket.Text = "Quản lý vé mượn";
            this.btn_bookTicket.UseVisualStyleBackColor = true;
            this.btn_bookTicket.Click += new System.EventHandler(this.btn_bookTicket_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Account.Location = new System.Drawing.Point(730, 12);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(120, 62);
            this.btn_Account.TabIndex = 18;
            this.btn_Account.Text = "Quản lý tài khoản";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Author
            // 
            this.btn_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Author.Location = new System.Drawing.Point(226, 12);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Size = new System.Drawing.Size(120, 62);
            this.btn_Author.TabIndex = 19;
            this.btn_Author.Text = "Quản lý tác giả";
            this.btn_Author.UseVisualStyleBackColor = true;
            this.btn_Author.Click += new System.EventHandler(this.btn_Author_Click);
            // 
            // btn_BookType
            // 
            this.btn_BookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_BookType.Location = new System.Drawing.Point(352, 12);
            this.btn_BookType.Name = "btn_BookType";
            this.btn_BookType.Size = new System.Drawing.Size(120, 62);
            this.btn_BookType.TabIndex = 20;
            this.btn_BookType.Text = "Quản lý loại sách";
            this.btn_BookType.UseVisualStyleBackColor = true;
            this.btn_BookType.Click += new System.EventHandler(this.btn_BookType_Click);
            // 
            // btn_Reader
            // 
            this.btn_Reader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Reader.Location = new System.Drawing.Point(478, 12);
            this.btn_Reader.Name = "btn_Reader";
            this.btn_Reader.Size = new System.Drawing.Size(120, 62);
            this.btn_Reader.TabIndex = 21;
            this.btn_Reader.Text = "Quản lý bạn đọc";
            this.btn_Reader.UseVisualStyleBackColor = true;
            this.btn_Reader.Click += new System.EventHandler(this.btn_Reader_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btn_Reader);
            this.Controls.Add(this.btn_BookType);
            this.Controls.Add(this.btn_Author);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.btn_bookTicket);
            this.Controls.Add(this.btn_bookManagement);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "homePage";
            this.Padding = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.homePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Navigation.NavButton navButton1;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private System.Windows.Forms.Button btn_bookManagement;
        private System.Windows.Forms.Button btn_bookTicket;
        private System.Windows.Forms.Button btn_Reader;
        private System.Windows.Forms.Button btn_BookType;
        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Button btn_Account;
    }
}