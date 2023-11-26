namespace ILib
{
    partial class TypeofBookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeofBookManagement));
            this.title_typeOfBook = new System.Windows.Forms.Label();
            this.grp_typeOfBookDetail = new System.Windows.Forms.GroupBox();
            this.txt_typeOfBookStatus = new System.Windows.Forms.TextBox();
            this.lbl_typeOfBookStatus = new System.Windows.Forms.Label();
            this.txt_typeOfBookId = new System.Windows.Forms.TextBox();
            this.lbl_typeOfBookId = new System.Windows.Forms.Label();
            this.txt_typeOfBookName = new System.Windows.Forms.TextBox();
            this.lbl_typeOfBookName = new System.Windows.Forms.Label();
            this.lst_typeOfBook = new System.Windows.Forms.ListView();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grp_typeOfBookDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_typeOfBook
            // 
            this.title_typeOfBook.AutoSize = true;
            this.title_typeOfBook.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.title_typeOfBook.Location = new System.Drawing.Point(196, 42);
            this.title_typeOfBook.Name = "title_typeOfBook";
            this.title_typeOfBook.Size = new System.Drawing.Size(322, 43);
            this.title_typeOfBook.TabIndex = 0;
            this.title_typeOfBook.Text = "Quản Lý Loại Sách";
            // 
            // grp_typeOfBookDetail
            // 
            this.grp_typeOfBookDetail.Controls.Add(this.txt_typeOfBookStatus);
            this.grp_typeOfBookDetail.Controls.Add(this.lbl_typeOfBookStatus);
            this.grp_typeOfBookDetail.Controls.Add(this.txt_typeOfBookId);
            this.grp_typeOfBookDetail.Controls.Add(this.lbl_typeOfBookId);
            this.grp_typeOfBookDetail.Controls.Add(this.txt_typeOfBookName);
            this.grp_typeOfBookDetail.Controls.Add(this.lbl_typeOfBookName);
            this.grp_typeOfBookDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grp_typeOfBookDetail.Location = new System.Drawing.Point(12, 105);
            this.grp_typeOfBookDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_typeOfBookDetail.Name = "grp_typeOfBookDetail";
            this.grp_typeOfBookDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_typeOfBookDetail.Size = new System.Drawing.Size(563, 124);
            this.grp_typeOfBookDetail.TabIndex = 4;
            this.grp_typeOfBookDetail.TabStop = false;
            this.grp_typeOfBookDetail.Text = "Thông tin chi tiết";
            // 
            // txt_typeOfBookStatus
            // 
            this.txt_typeOfBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_typeOfBookStatus.Location = new System.Drawing.Point(379, 78);
            this.txt_typeOfBookStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_typeOfBookStatus.Name = "txt_typeOfBookStatus";
            this.txt_typeOfBookStatus.Size = new System.Drawing.Size(177, 28);
            this.txt_typeOfBookStatus.TabIndex = 6;
            this.txt_typeOfBookStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_typeOfBookStatus
            // 
            this.lbl_typeOfBookStatus.AutoSize = true;
            this.lbl_typeOfBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_typeOfBookStatus.Location = new System.Drawing.Point(273, 81);
            this.lbl_typeOfBookStatus.Name = "lbl_typeOfBookStatus";
            this.lbl_typeOfBookStatus.Size = new System.Drawing.Size(99, 24);
            this.lbl_typeOfBookStatus.TabIndex = 5;
            this.lbl_typeOfBookStatus.Text = "Trạng thái:";
            this.lbl_typeOfBookStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_typeOfBookId
            // 
            this.txt_typeOfBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_typeOfBookId.Location = new System.Drawing.Point(141, 78);
            this.txt_typeOfBookId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_typeOfBookId.Name = "txt_typeOfBookId";
            this.txt_typeOfBookId.Size = new System.Drawing.Size(127, 28);
            this.txt_typeOfBookId.TabIndex = 4;
            // 
            // lbl_typeOfBookId
            // 
            this.lbl_typeOfBookId.AutoSize = true;
            this.lbl_typeOfBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_typeOfBookId.Location = new System.Drawing.Point(15, 81);
            this.lbl_typeOfBookId.Name = "lbl_typeOfBookId";
            this.lbl_typeOfBookId.Size = new System.Drawing.Size(120, 24);
            this.lbl_typeOfBookId.TabIndex = 3;
            this.lbl_typeOfBookId.Text = "Mã loại sách:";
            // 
            // txt_typeOfBookName
            // 
            this.txt_typeOfBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_typeOfBookName.Location = new System.Drawing.Point(141, 38);
            this.txt_typeOfBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_typeOfBookName.Name = "txt_typeOfBookName";
            this.txt_typeOfBookName.Size = new System.Drawing.Size(415, 28);
            this.txt_typeOfBookName.TabIndex = 2;
            // 
            // lbl_typeOfBookName
            // 
            this.lbl_typeOfBookName.AutoSize = true;
            this.lbl_typeOfBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_typeOfBookName.Location = new System.Drawing.Point(13, 42);
            this.lbl_typeOfBookName.Name = "lbl_typeOfBookName";
            this.lbl_typeOfBookName.Size = new System.Drawing.Size(83, 24);
            this.lbl_typeOfBookName.TabIndex = 1;
            this.lbl_typeOfBookName.Text = "Tên loại:";
            // 
            // lst_typeOfBook
            // 
            this.lst_typeOfBook.HideSelection = false;
            this.lst_typeOfBook.Location = new System.Drawing.Point(12, 235);
            this.lst_typeOfBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_typeOfBook.Name = "lst_typeOfBook";
            this.lst_typeOfBook.Size = new System.Drawing.Size(708, 176);
            this.lst_typeOfBook.TabIndex = 9;
            this.lst_typeOfBook.UseCompatibleStateImageBehavior = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(581, 154);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(135, 30);
            this.simpleButton4.TabIndex = 20;
            this.simpleButton4.Text = "Sửa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(581, 191);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(135, 30);
            this.simpleButton3.TabIndex = 19;
            this.simpleButton3.Text = "Xoá";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(581, 117);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 30);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Thêm";
            // 
            // TypeofBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lst_typeOfBook);
            this.Controls.Add(this.grp_typeOfBookDetail);
            this.Controls.Add(this.title_typeOfBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TypeofBookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeofBookManagement";
            this.grp_typeOfBookDetail.ResumeLayout(false);
            this.grp_typeOfBookDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_typeOfBook;
        private System.Windows.Forms.GroupBox grp_typeOfBookDetail;
        private System.Windows.Forms.TextBox txt_typeOfBookId;
        private System.Windows.Forms.Label lbl_typeOfBookId;
        private System.Windows.Forms.TextBox txt_typeOfBookName;
        private System.Windows.Forms.Label lbl_typeOfBookName;
        private System.Windows.Forms.ListView lst_typeOfBook;
        private System.Windows.Forms.TextBox txt_typeOfBookStatus;
        private System.Windows.Forms.Label lbl_typeOfBookStatus;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}