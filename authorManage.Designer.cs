namespace ILib
{
    partial class authorManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorManage));
            this.txtAuhorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.saveAuto = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAuthor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAuhorname
            // 
            this.txtAuhorname.Location = new System.Drawing.Point(285, 78);
            this.txtAuhorname.Name = "txtAuhorname";
            this.txtAuhorname.Size = new System.Drawing.Size(192, 20);
            this.txtAuhorname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(192, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên tác giả";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot (210).png");
            this.imageList1.Images.SetKeyName(1, "Screenshot (211).png");
            this.imageList1.Images.SetKeyName(2, "Screenshot (212).png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 22F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(209, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh Mục Tác Giả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.status});
            this.dgvAuthor.Location = new System.Drawing.Point(24, 116);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.Size = new System.Drawing.Size(610, 244);
            this.dgvAuthor.TabIndex = 32;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "Họ và tên";
            this.fullname.Name = "fullname";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(559, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEditAuthor.Appearance.Options.UseFont = true;
            this.btnEditAuthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnEditAuthor.Location = new System.Drawing.Point(118, 366);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(74, 23);
            this.btnEditAuthor.TabIndex = 5;
            this.btnEditAuthor.Text = "Sửa";
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteAuthor.Appearance.Options.UseFont = true;
            this.btnDeleteAuthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnDeleteAuthor.Location = new System.Drawing.Point(215, 366);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAuthor.TabIndex = 4;
            this.btnDeleteAuthor.Text = "Xoá";
            // 
            // saveAuto
            // 
            this.saveAuto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.saveAuto.Appearance.Options.UseFont = true;
            this.saveAuto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.saveAuto.Location = new System.Drawing.Point(314, 366);
            this.saveAuto.Name = "saveAuto";
            this.saveAuto.Size = new System.Drawing.Size(75, 23);
            this.saveAuto.TabIndex = 3;
            this.saveAuto.Text = "Lưu";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddAuthor.Appearance.Options.UseFont = true;
            this.btnAddAuthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAddAuthor.Location = new System.Drawing.Point(24, 366);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Thêm";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // authorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 407);
            this.Controls.Add(this.dgvAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuhorname);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditAuthor);
            this.Controls.Add(this.btnDeleteAuthor);
            this.Controls.Add(this.saveAuto);
            this.Controls.Add(this.btnAddAuthor);
            this.Name = "authorManage";
            this.Text = "Danh mục tác giả";
            this.Load += new System.EventHandler(this.authorManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddAuthor;
        private DevExpress.XtraEditors.SimpleButton saveAuto;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAuthor;
        private DevExpress.XtraEditors.SimpleButton btnEditAuthor;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.TextBox txtAuhorname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}