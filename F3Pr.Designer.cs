
namespace IMS_
{
    partial class F3Pr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCc = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbInv = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbInv = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbProdT = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbPart = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.dgvProdParts = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCc
            // 
            this.btCc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCc.Location = new System.Drawing.Point(497, 12);
            this.btCc.Name = "btCc";
            this.btCc.Size = new System.Drawing.Size(75, 23);
            this.btCc.TabIndex = 14;
            this.btCc.Text = "Cancel";
            this.btCc.UseVisualStyleBackColor = true;
            this.btCc.Click += new System.EventHandler(this.btCc_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(497, 422);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(472, 202);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 6;
            this.tbMax.Text = "2";
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(472, 176);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 5;
            this.tbMin.Text = "1";
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(472, 150);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.Text = "1";
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbInv
            // 
            this.tbInv.Location = new System.Drawing.Point(472, 124);
            this.tbInv.Name = "tbInv";
            this.tbInv.Size = new System.Drawing.Size(100, 20);
            this.tbInv.TabIndex = 3;
            this.tbInv.Text = "1";
            this.tbInv.TextChanged += new System.EventHandler(this.tbInv_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(472, 98);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "Product";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(472, 72);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 1;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(427, 209);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(30, 13);
            this.lbMax.TabIndex = 13;
            this.lbMax.Text = "Max.";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(427, 183);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(27, 13);
            this.lbMin.TabIndex = 12;
            this.lbMin.Text = "Min.";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(427, 157);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Price";
            // 
            // lbInv
            // 
            this.lbInv.AutoSize = true;
            this.lbInv.Location = new System.Drawing.Point(427, 131);
            this.lbInv.Name = "lbInv";
            this.lbInv.Size = new System.Drawing.Size(25, 13);
            this.lbInv.TabIndex = 10;
            this.lbInv.Text = "Inv.";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(427, 105);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(427, 79);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "ID";
            // 
            // lbProdT
            // 
            this.lbProdT.AutoSize = true;
            this.lbProdT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdT.Location = new System.Drawing.Point(7, 9);
            this.lbProdT.Name = "lbProdT";
            this.lbProdT.Size = new System.Drawing.Size(49, 25);
            this.lbProdT.TabIndex = 5;
            this.lbProdT.Text = "Add";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(234, 43);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbPart
            // 
            this.lbPart.AutoSize = true;
            this.lbPart.Location = new System.Drawing.Point(9, 54);
            this.lbPart.Name = "lbPart";
            this.lbPart.Size = new System.Drawing.Size(73, 13);
            this.lbPart.TabIndex = 29;
            this.lbPart.Text = "Part Inventory";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(340, 41);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(340, 217);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvPart
            // 
            this.dgvPart.AllowUserToAddRows = false;
            this.dgvPart.AllowUserToDeleteRows = false;
            this.dgvPart.AllowUserToResizeColumns = false;
            this.dgvPart.AllowUserToResizeRows = false;
            this.dgvPart.AutoGenerateColumns = false;
            this.dgvPart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clName,
            this.clInv,
            this.clPrice,
            this.clMin,
            this.clMax});
            this.dgvPart.DataSource = this.partBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPart.Location = new System.Drawing.Point(12, 70);
            this.dgvPart.MultiSelect = false;
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.ReadOnly = true;
            this.dgvPart.RowHeadersVisible = false;
            this.dgvPart.RowHeadersWidth = 51;
            this.dgvPart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPart.Size = new System.Drawing.Size(403, 141);
            this.dgvPart.TabIndex = 10;
            this.dgvPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPart_CellClick);
            this.dgvPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPart_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Associated Parts";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(340, 422);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 11;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dgvProdParts
            // 
            this.dgvProdParts.AllowUserToAddRows = false;
            this.dgvProdParts.AllowUserToDeleteRows = false;
            this.dgvProdParts.AllowUserToResizeColumns = false;
            this.dgvProdParts.AllowUserToResizeRows = false;
            this.dgvProdParts.AutoGenerateColumns = false;
            this.dgvProdParts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProdParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProdParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.invDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.dgvProdParts.DataSource = this.partBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdParts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdParts.Location = new System.Drawing.Point(12, 275);
            this.dgvProdParts.MultiSelect = false;
            this.dgvProdParts.Name = "dgvProdParts";
            this.dgvProdParts.ReadOnly = true;
            this.dgvProdParts.RowHeadersVisible = false;
            this.dgvProdParts.RowHeadersWidth = 51;
            this.dgvProdParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProdParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdParts.Size = new System.Drawing.Size(403, 141);
            this.dgvProdParts.TabIndex = 12;
            this.dgvProdParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdParts_CellClick);
            this.dgvProdParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProdParts_DataBindingComplete);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // invDataGridViewTextBoxColumn
            // 
            this.invDataGridViewTextBoxColumn.DataPropertyName = "Inv";
            this.invDataGridViewTextBoxColumn.HeaderText = "Inv";
            this.invDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invDataGridViewTextBoxColumn.Name = "invDataGridViewTextBoxColumn";
            this.invDataGridViewTextBoxColumn.ReadOnly = true;
            this.invDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            this.minDataGridViewTextBoxColumn.Visible = false;
            this.minDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxDataGridViewTextBoxColumn.Visible = false;
            this.maxDataGridViewTextBoxColumn.Width = 125;
            // 
            // partBindingSource
            // 
            F3Pr f3Pr = this;
            f3Pr.partBindingSource.DataSource = typeof(IMS_.Part);
            // 
            // clID
            // 
            this.clID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Width = 43;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Name";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 125;
            // 
            // clInv
            // 
            this.clInv.DataPropertyName = "Inv";
            this.clInv.HeaderText = "Inv";
            this.clInv.MinimumWidth = 6;
            this.clInv.Name = "clInv";
            this.clInv.ReadOnly = true;
            this.clInv.Width = 125;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.clPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.clPrice.HeaderText = "Price";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 125;
            // 
            // clMin
            // 
            this.clMin.DataPropertyName = "Min";
            this.clMin.HeaderText = "Min";
            this.clMin.MinimumWidth = 6;
            this.clMin.Name = "clMin";
            this.clMin.ReadOnly = true;
            this.clMin.Visible = false;
            this.clMin.Width = 125;
            // 
            // clMax
            // 
            this.clMax.DataPropertyName = "Max";
            this.clMax.HeaderText = "Max";
            this.clMax.MinimumWidth = 6;
            this.clMax.Name = "clMax";
            this.clMax.ReadOnly = true;
            this.clMax.Visible = false;
            this.clMax.Width = 125;
            // 
            // F3Pr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.dgvProdParts);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbPart);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvPart);
            this.Controls.Add(this.btCc);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbInv);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbInv);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbProdT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F3Pr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Click += new System.EventHandler(this.F3Pr_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCc;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbInv;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbInv;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbPart;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDel;
        internal System.Windows.Forms.Label lbProdT;
        private System.Windows.Forms.DataGridView dgvPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridView dgvProdParts;
        internal System.Windows.Forms.BindingSource partBindingSource;
    }
}