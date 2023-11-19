namespace ILib
{
    partial class BorrowTicketManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowTicketManagement));
            this.title_borrowTicket = new System.Windows.Forms.Label();
            this.grp_bookDetail = new System.Windows.Forms.GroupBox();
            this.txt_brwTicketBook = new System.Windows.Forms.TextBox();
            this.lbl_brwTicketBook = new System.Windows.Forms.Label();
            this.lbl_brwTicketStartDate = new System.Windows.Forms.Label();
            this.txt_brwTicketStatus = new System.Windows.Forms.TextBox();
            this.lbl_brwTicketStatus = new System.Windows.Forms.Label();
            this.txt_brwTicketId = new System.Windows.Forms.TextBox();
            this.lbl_brwTicketId = new System.Windows.Forms.Label();
            this.lbl_brwTicketUReturnDate = new System.Windows.Forms.Label();
            this.txt_brwTicketUser = new System.Windows.Forms.TextBox();
            this.lbl_brwTicketUser = new System.Windows.Forms.Label();
            this.lst_brwTicket = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grp_bookDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_borrowTicket
            // 
            this.title_borrowTicket.AutoSize = true;
            this.title_borrowTicket.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.title_borrowTicket.Location = new System.Drawing.Point(172, 18);
            this.title_borrowTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_borrowTicket.Name = "title_borrowTicket";
            this.title_borrowTicket.Size = new System.Drawing.Size(258, 36);
            this.title_borrowTicket.TabIndex = 0;
            this.title_borrowTicket.Text = "Quản Lý Vé Mượn";
            // 
            // grp_bookDetail
            // 
            this.grp_bookDetail.Controls.Add(this.dateTimePicker2);
            this.grp_bookDetail.Controls.Add(this.lst_brwTicket);
            this.grp_bookDetail.Controls.Add(this.dateTimePicker1);
            this.grp_bookDetail.Controls.Add(this.txt_brwTicketBook);
            this.grp_bookDetail.Controls.Add(this.lbl_brwTicketBook);
            this.grp_bookDetail.Controls.Add(this.lbl_brwTicketStartDate);
            this.grp_bookDetail.Controls.Add(this.txt_brwTicketStatus);
            this.grp_bookDetail.Controls.Add(this.lbl_brwTicketStatus);
            this.grp_bookDetail.Controls.Add(this.txt_brwTicketId);
            this.grp_bookDetail.Controls.Add(this.lbl_brwTicketId);
            this.grp_bookDetail.Controls.Add(this.lbl_brwTicketUReturnDate);
            this.grp_bookDetail.Controls.Add(this.txt_brwTicketUser);
            this.grp_bookDetail.Controls.Add(this.lbl_brwTicketUser);
            this.grp_bookDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grp_bookDetail.Location = new System.Drawing.Point(9, 69);
            this.grp_bookDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_bookDetail.Name = "grp_bookDetail";
            this.grp_bookDetail.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_bookDetail.Size = new System.Drawing.Size(568, 171);
            this.grp_bookDetail.TabIndex = 4;
            this.grp_bookDetail.TabStop = false;
            this.grp_bookDetail.Text = "Thông tin chi tiết";
            // 
            // txt_brwTicketBook
            // 
            this.txt_brwTicketBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_brwTicketBook.Location = new System.Drawing.Point(280, 64);
            this.txt_brwTicketBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_brwTicketBook.Name = "txt_brwTicketBook";
            this.txt_brwTicketBook.Size = new System.Drawing.Size(92, 24);
            this.txt_brwTicketBook.TabIndex = 16;
            // 
            // lbl_brwTicketBook
            // 
            this.lbl_brwTicketBook.AutoSize = true;
            this.lbl_brwTicketBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_brwTicketBook.Location = new System.Drawing.Point(212, 67);
            this.lbl_brwTicketBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brwTicketBook.Name = "lbl_brwTicketBook";
            this.lbl_brwTicketBook.Size = new System.Drawing.Size(69, 18);
            this.lbl_brwTicketBook.TabIndex = 15;
            this.lbl_brwTicketBook.Text = "Mã sách:";
            // 
            // lbl_brwTicketStartDate
            // 
            this.lbl_brwTicketStartDate.AutoSize = true;
            this.lbl_brwTicketStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_brwTicketStartDate.Location = new System.Drawing.Point(10, 99);
            this.lbl_brwTicketStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brwTicketStartDate.Name = "lbl_brwTicketStartDate";
            this.lbl_brwTicketStartDate.Size = new System.Drawing.Size(88, 18);
            this.lbl_brwTicketStartDate.TabIndex = 7;
            this.lbl_brwTicketStartDate.Text = "Ngày mượn:";
            // 
            // txt_brwTicketStatus
            // 
            this.txt_brwTicketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_brwTicketStatus.Location = new System.Drawing.Point(458, 64);
            this.txt_brwTicketStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_brwTicketStatus.Name = "txt_brwTicketStatus";
            this.txt_brwTicketStatus.Size = new System.Drawing.Size(107, 24);
            this.txt_brwTicketStatus.TabIndex = 6;
            // 
            // lbl_brwTicketStatus
            // 
            this.lbl_brwTicketStatus.AutoSize = true;
            this.lbl_brwTicketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_brwTicketStatus.Location = new System.Drawing.Point(380, 64);
            this.lbl_brwTicketStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brwTicketStatus.Name = "lbl_brwTicketStatus";
            this.lbl_brwTicketStatus.Size = new System.Drawing.Size(77, 18);
            this.lbl_brwTicketStatus.TabIndex = 5;
            this.lbl_brwTicketStatus.Text = "Trạng thái:";
            // 
            // txt_brwTicketId
            // 
            this.txt_brwTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_brwTicketId.Location = new System.Drawing.Point(99, 64);
            this.txt_brwTicketId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_brwTicketId.Name = "txt_brwTicketId";
            this.txt_brwTicketId.Size = new System.Drawing.Size(108, 24);
            this.txt_brwTicketId.TabIndex = 4;
            // 
            // lbl_brwTicketId
            // 
            this.lbl_brwTicketId.AutoSize = true;
            this.lbl_brwTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_brwTicketId.Location = new System.Drawing.Point(10, 67);
            this.lbl_brwTicketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brwTicketId.Name = "lbl_brwTicketId";
            this.lbl_brwTicketId.Size = new System.Drawing.Size(52, 18);
            this.lbl_brwTicketId.TabIndex = 3;
            this.lbl_brwTicketId.Text = "Mã vé:";
            // 
            // lbl_brwTicketUReturnDate
            // 
            this.lbl_brwTicketUReturnDate.AutoSize = true;
            this.lbl_brwTicketUReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_brwTicketUReturnDate.Location = new System.Drawing.Point(308, 99);
            this.lbl_brwTicketUReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brwTicketUReturnDate.Name = "lbl_brwTicketUReturnDate";
            this.lbl_brwTicketUReturnDate.Size = new System.Drawing.Size(67, 18);
            this.lbl_brwTicketUReturnDate.TabIndex = 11;
            this.lbl_brwTicketUReturnDate.Text = "Ngày trả:";
            // 
            // txt_brwTicketUser
            // 
            this.txt_brwTicketUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_brwTicketUser.Location = new System.Drawing.Point(99, 31);
            this.txt_brwTicketUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_brwTicketUser.Name = "txt_brwTicketUser";
            this.txt_brwTicketUser.Size = new System.Drawing.Size(466, 24);
            this.txt_brwTicketUser.TabIndex = 2;
            // 
            // lbl_brwTicketUser
            // 
            this.lbl_brwTicketUser.AutoSize = true;
            this.lbl_brwTicketUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_brwTicketUser.Location = new System.Drawing.Point(10, 34);
            this.lbl_brwTicketUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_brwTicketUser.Name = "lbl_brwTicketUser";
            this.lbl_brwTicketUser.Size = new System.Drawing.Size(63, 18);
            this.lbl_brwTicketUser.TabIndex = 1;
            this.lbl_brwTicketUser.Text = "Độc giả:";
            // 
            // lst_brwTicket
            // 
            this.lst_brwTicket.HideSelection = false;
            this.lst_brwTicket.Location = new System.Drawing.Point(0, 129);
            this.lst_brwTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_brwTicket.Name = "lst_brwTicket";
            this.lst_brwTicket.Size = new System.Drawing.Size(565, 116);
            this.lst_brwTicket.TabIndex = 5;
            this.lst_brwTicket.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 29);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(99, 95);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(204, 29);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(120, 332);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(74, 24);
            this.simpleButton4.TabIndex = 22;
            this.simpleButton4.Text = "Sửa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(215, 332);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 24);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "Xoá";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(24, 332);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 24);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Thêm";
            // 
            // BorrowTicketManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grp_bookDetail);
            this.Controls.Add(this.title_borrowTicket);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BorrowTicketManagement";
            this.Text = "BorrowTicketManagement";
            this.grp_bookDetail.ResumeLayout(false);
            this.grp_bookDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_borrowTicket;
        private System.Windows.Forms.GroupBox grp_bookDetail;
        private System.Windows.Forms.Label lbl_brwTicketStartDate;
        private System.Windows.Forms.TextBox txt_brwTicketStatus;
        private System.Windows.Forms.Label lbl_brwTicketStatus;
        private System.Windows.Forms.TextBox txt_brwTicketId;
        private System.Windows.Forms.Label lbl_brwTicketId;
        private System.Windows.Forms.Label lbl_brwTicketUReturnDate;
        private System.Windows.Forms.TextBox txt_brwTicketUser;
        private System.Windows.Forms.Label lbl_brwTicketUser;
        private System.Windows.Forms.TextBox txt_brwTicketBook;
        private System.Windows.Forms.Label lbl_brwTicketBook;
        private System.Windows.Forms.ListView lst_brwTicket;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}