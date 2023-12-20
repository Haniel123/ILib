namespace ILib
{
    partial class BookManagement
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.dtpkPublished = new System.Windows.Forms.DateTimePicker();
            this.cbbAuthor = new System.Windows.Forms.ComboBox();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLibDataSet1 = new ILib.ELibDataSet1();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.bookTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLibDataSet = new ILib.ELibDataSet();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeTableAdapter = new ILib.ELibDataSetTableAdapters.BookTypeTableAdapter();
            this.authorTableAdapter = new ILib.ELibDataSet1TableAdapters.AuthorTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(754, 70);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản Lý Sách";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.cbbStatus);
            this.grpBox.Controls.Add(this.dtpkPublished);
            this.grpBox.Controls.Add(this.cbbAuthor);
            this.grpBox.Controls.Add(this.txtName);
            this.grpBox.Controls.Add(this.lblStatus);
            this.grpBox.Controls.Add(this.numQuantity);
            this.grpBox.Controls.Add(this.lblQuantity);
            this.grpBox.Controls.Add(this.numPrice);
            this.grpBox.Controls.Add(this.lblPrice);
            this.grpBox.Controls.Add(this.lblPublished);
            this.grpBox.Controls.Add(this.cbbType);
            this.grpBox.Controls.Add(this.lblType);
            this.grpBox.Controls.Add(this.lblAuthor);
            this.grpBox.Controls.Add(this.lblName);
            this.grpBox.Controls.Add(this.txtID);
            this.grpBox.Controls.Add(this.lblCode);
            this.grpBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.grpBox.Location = new System.Drawing.Point(9, 72);
            this.grpBox.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox.Name = "grpBox";
            this.grpBox.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox.Size = new System.Drawing.Size(734, 202);
            this.grpBox.TabIndex = 2;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Thông tin";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Arial", 14F);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(486, 156);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(241, 30);
            this.cbbStatus.TabIndex = 18;
            this.cbbStatus.Click += new System.EventHandler(this.cbbStatus_Click);
            // 
            // dtpkPublished
            // 
            this.dtpkPublished.Font = new System.Drawing.Font("Arial", 13F);
            this.dtpkPublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkPublished.Location = new System.Drawing.Point(99, 116);
            this.dtpkPublished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkPublished.Name = "dtpkPublished";
            this.dtpkPublished.Size = new System.Drawing.Size(245, 27);
            this.dtpkPublished.TabIndex = 21;
            // 
            // cbbAuthor
            // 
            this.cbbAuthor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.authorBindingSource, "Name", true));
            this.cbbAuthor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.authorBindingSource, "Name", true));
            this.cbbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAuthor.Font = new System.Drawing.Font("Arial", 14F);
            this.cbbAuthor.FormattingEnabled = true;
            this.cbbAuthor.Location = new System.Drawing.Point(99, 76);
            this.cbbAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.cbbAuthor.Name = "cbbAuthor";
            this.cbbAuthor.Size = new System.Drawing.Size(245, 30);
            this.cbbAuthor.TabIndex = 20;
            this.cbbAuthor.Click += new System.EventHandler(this.cbbAuthor_Click);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.eLibDataSet1;
            // 
            // eLibDataSet1
            // 
            this.eLibDataSet1.DataSetName = "ELibDataSet1";
            this.eLibDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 14F);
            this.txtName.Location = new System.Drawing.Point(96, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 29);
            this.txtName.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(384, 161);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 21);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Trạng thái";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Arial", 14F);
            this.numQuantity.Location = new System.Drawing.Point(99, 157);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(245, 29);
            this.numQuantity.TabIndex = 16;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(4, 161);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(91, 21);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Số lượng";
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Arial", 14F);
            this.numPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(486, 118);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(241, 29);
            this.numPrice.TabIndex = 14;
            this.numPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(384, 122);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 21);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Giá";
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblPublished.Location = new System.Drawing.Point(4, 122);
            this.lblPublished.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(86, 21);
            this.lblPublished.TabIndex = 11;
            this.lblPublished.Text = "Xuất bản";
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Arial", 14F);
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(486, 76);
            this.cbbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(241, 30);
            this.cbbType.TabIndex = 10;
            this.cbbType.Click += new System.EventHandler(this.ccbType_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(384, 81);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 21);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Loại";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.Location = new System.Drawing.Point(4, 81);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 21);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Tác giả";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(4, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên sách";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 14F);
            this.txtID.Location = new System.Drawing.Point(486, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(241, 29);
            this.txtID.TabIndex = 6;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblCode.Location = new System.Drawing.Point(384, 42);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(81, 21);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Mã sách";
            // 
            // bookTypeBindingSource
            // 
            this.bookTypeBindingSource.DataMember = "BookType";
            this.bookTypeBindingSource.DataSource = this.eLibDataSet;
            // 
            // eLibDataSet
            // 
            this.eLibDataSet.DataSetName = "ELibDataSet";
            this.eLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBook.Location = new System.Drawing.Point(0, 354);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.Size = new System.Drawing.Size(754, 296);
            this.dgvBook.TabIndex = 25;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            this.dgvBook.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBook_CellFormatting);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Id";
            this.Column8.HeaderText = "Mã";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdAuthor";
            this.Column2.HeaderText = "Tác giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IdType";
            this.Column3.HeaderText = "Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 95;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Publisher";
            this.Column4.HeaderText = "Xuất bản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Price";
            this.Column6.HeaderText = "Giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 20;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Status";
            this.Column7.HeaderText = "Trạng thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // bookTypeTableAdapter
            // 
            this.bookTypeTableAdapter.ClearBeforeFill = true;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = global::ILib.Properties.Resources.icons8_search_48;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(362, 284);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSearch.Size = new System.Drawing.Size(150, 54);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = global::ILib.Properties.Resources.icons8_cancel_48;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(631, 284);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 54);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Đóng";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Image = global::ILib.Properties.Resources.icons8_repair_48;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(244, 284);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUpdate.Size = new System.Drawing.Size(112, 54);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = global::ILib.Properties.Resources.icons8_delete_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(127, 284);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDelete.Size = new System.Drawing.Size(112, 54);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::ILib.Properties.Resources.icons8_plus_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(9, 284);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 54);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(516, 284);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRefresh.Size = new System.Drawing.Size(108, 54);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 8);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.BookManagement_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPublished;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DateTimePicker dtpkPublished;
        private System.Windows.Forms.ComboBox cbbAuthor;
        private System.Windows.Forms.TextBox txtName;
        private ELibDataSet eLibDataSet;
        private System.Windows.Forms.BindingSource bookTypeBindingSource;
        private ELibDataSetTableAdapters.BookTypeTableAdapter bookTypeTableAdapter;
        private ELibDataSet1 eLibDataSet1;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private ELibDataSet1TableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}