
namespace IMS_
{
    partial class F1M
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.lbPart = new System.Windows.Forms.Label();
            this.lbProd = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbMainT = new System.Windows.Forms.Label();
            this.btSearch1 = new System.Windows.Forms.Button();
            this.btAdd1 = new System.Windows.Forms.Button();
            this.btMod1 = new System.Windows.Forms.Button();
            this.btDel1 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbSearch1 = new System.Windows.Forms.TextBox();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInv1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMin1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AllowUserToResizeColumns = false;
            this.dgvProd.AllowUserToResizeRows = false;
            this.dgvProd.AutoGenerateColumns = false;
            this.dgvProd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID1,
            this.clName1,
            this.clInv1,
            this.clPrice1,
            this.clMin1,
            this.clMax1});
            this.dgvProd.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProd.Location = new System.Drawing.Point(12, 275);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidth = 51;
            this.dgvProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(404, 141);
            this.dgvProd.TabIndex = 12;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
            this.dgvProd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProd_DataBindingComplete);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(421, 70);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(260, 217);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(75, 23);
            this.btMod.TabIndex = 4;
            this.btMod.Text = "Modify";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(341, 217);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 5;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // lbPart
            // 
            this.lbPart.AutoSize = true;
            this.lbPart.Location = new System.Drawing.Point(9, 54);
            this.lbPart.Name = "lbPart";
            this.lbPart.Size = new System.Drawing.Size(26, 13);
            this.lbPart.TabIndex = 3;
            this.lbPart.Text = "Part";
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Location = new System.Drawing.Point(9, 259);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(44, 13);
            this.lbProd.TabIndex = 3;
            this.lbProd.Text = "Product";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(341, 41);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(421, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbMainT
            // 
            this.lbMainT.AutoSize = true;
            this.lbMainT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainT.Location = new System.Drawing.Point(7, 8);
            this.lbMainT.Name = "lbMainT";
            this.lbMainT.Size = new System.Drawing.Size(57, 25);
            this.lbMainT.TabIndex = 3;
            this.lbMainT.Text = "Main";
            // 
            // btSearch1
            // 
            this.btSearch1.Location = new System.Drawing.Point(341, 246);
            this.btSearch1.Name = "btSearch1";
            this.btSearch1.Size = new System.Drawing.Size(75, 23);
            this.btSearch1.TabIndex = 8;
            this.btSearch1.Text = "Search";
            this.btSearch1.UseVisualStyleBackColor = true;
            this.btSearch1.Click += new System.EventHandler(this.btSearch1_Click);
            // 
            // btAdd1
            // 
            this.btAdd1.Location = new System.Drawing.Point(421, 275);
            this.btAdd1.Name = "btAdd1";
            this.btAdd1.Size = new System.Drawing.Size(75, 23);
            this.btAdd1.TabIndex = 9;
            this.btAdd1.Text = "Add";
            this.btAdd1.UseVisualStyleBackColor = true;
            this.btAdd1.Click += new System.EventHandler(this.btAdd1_Click);
            // 
            // btMod1
            // 
            this.btMod1.Location = new System.Drawing.Point(260, 422);
            this.btMod1.Name = "btMod1";
            this.btMod1.Size = new System.Drawing.Size(75, 23);
            this.btMod1.TabIndex = 10;
            this.btMod1.Text = "Modify";
            this.btMod1.UseVisualStyleBackColor = true;
            this.btMod1.Click += new System.EventHandler(this.btMod1_Click);
            // 
            // btDel1
            // 
            this.btDel1.Location = new System.Drawing.Point(341, 422);
            this.btDel1.Name = "btDel1";
            this.btDel1.Size = new System.Drawing.Size(75, 23);
            this.btDel1.TabIndex = 11;
            this.btDel1.Text = "Delete";
            this.btDel1.UseVisualStyleBackColor = true;
            this.btDel1.Click += new System.EventHandler(this.btDel1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(235, 43);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tbSearch1
            // 
            this.tbSearch1.Location = new System.Drawing.Point(235, 248);
            this.tbSearch1.Name = "tbSearch1";
            this.tbSearch1.Size = new System.Drawing.Size(100, 20);
            this.tbSearch1.TabIndex = 7;
            this.tbSearch1.TextChanged += new System.EventHandler(this.tbSearch1_TextChanged);
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
            this.clMax,
            this.clMach});
            this.dgvPart.DataSource = this.partBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPart.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPart.Location = new System.Drawing.Point(12, 70);
            this.dgvPart.MultiSelect = false;
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.ReadOnly = true;
            this.dgvPart.RowHeadersVisible = false;
            this.dgvPart.RowHeadersWidth = 51;
            this.dgvPart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPart.Size = new System.Drawing.Size(403, 141);
            this.dgvPart.TabIndex = 6;
            this.dgvPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPart_CellClick);
            this.dgvPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPart_DataBindinComplete);
            // 
            // partBindingSource
            // 
            this.partBindingSource.AllowNew = true;
            this.partBindingSource.DataSource = typeof(IMS_.Part);
            // 
            // clID1
            // 
            this.clID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clID1.DataPropertyName = "ID";
            this.clID1.HeaderText = "ID";
            this.clID1.MinimumWidth = 6;
            this.clID1.Name = "clID1";
            this.clID1.ReadOnly = true;
            this.clID1.Width = 43;
            // 
            // clName1
            // 
            this.clName1.DataPropertyName = "Name";
            this.clName1.HeaderText = "Name";
            this.clName1.MinimumWidth = 6;
            this.clName1.Name = "clName1";
            this.clName1.ReadOnly = true;
            this.clName1.Width = 125;
            // 
            // clInv1
            // 
            this.clInv1.DataPropertyName = "Inv";
            this.clInv1.HeaderText = "Inv.";
            this.clInv1.MinimumWidth = 6;
            this.clInv1.Name = "clInv1";
            this.clInv1.ReadOnly = true;
            this.clInv1.Width = 125;
            // 
            // clPrice1
            // 
            this.clPrice1.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.clPrice1.DefaultCellStyle = dataGridViewCellStyle1;
            this.clPrice1.HeaderText = "Price";
            this.clPrice1.MinimumWidth = 6;
            this.clPrice1.Name = "clPrice1";
            this.clPrice1.ReadOnly = true;
            this.clPrice1.Width = 125;
            // 
            // clMin1
            // 
            this.clMin1.DataPropertyName = "Min";
            this.clMin1.HeaderText = "Min.";
            this.clMin1.MinimumWidth = 6;
            this.clMin1.Name = "clMin1";
            this.clMin1.ReadOnly = true;
            this.clMin1.Visible = false;
            this.clMin1.Width = 125;
            // 
            // clMax1
            // 
            this.clMax1.DataPropertyName = "Max";
            this.clMax1.HeaderText = "Max.";
            this.clMax1.MinimumWidth = 6;
            this.clMax1.Name = "clMax1";
            this.clMax1.ReadOnly = true;
            this.clMax1.Visible = false;
            this.clMax1.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.AllowNew = true;
            this.productBindingSource.DataSource = typeof(IMS_.Product);
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
            this.clInv.HeaderText = "Inv.";
            this.clInv.MinimumWidth = 6;
            this.clInv.Name = "clInv";
            this.clInv.ReadOnly = true;
            this.clInv.Width = 125;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.clPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.clPrice.HeaderText = "Price";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 125;
            // 
            // clMin
            // 
            this.clMin.DataPropertyName = "Min";
            this.clMin.HeaderText = "Min.";
            this.clMin.MinimumWidth = 6;
            this.clMin.Name = "clMin";
            this.clMin.ReadOnly = true;
            this.clMin.Visible = false;
            this.clMin.Width = 125;
            // 
            // clMax
            // 
            this.clMax.DataPropertyName = "Max";
            this.clMax.HeaderText = "Max.";
            this.clMax.MinimumWidth = 6;
            this.clMax.Name = "clMax";
            this.clMax.ReadOnly = true;
            this.clMax.Visible = false;
            this.clMax.Width = 125;
            // 
            // clMach
            // 
            this.clMach.DataPropertyName = "ID";
            this.clMach.HeaderText = "Mach. ID";
            this.clMach.MinimumWidth = 6;
            this.clMach.Name = "clMach";
            this.clMach.ReadOnly = true;
            this.clMach.Visible = false;
            this.clMach.Width = 125;
            // 
            // F1M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(509, 461);
            this.Controls.Add(this.tbSearch1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.lbMainT);
            this.Controls.Add(this.lbPart);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSearch1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDel1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btMod1);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.btAdd1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvPart);
            this.Controls.Add(this.dgvProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F1M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System ";
            this.Click += new System.EventHandler(this.F1M_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label lbPart;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbMainT;
        private System.Windows.Forms.Button btSearch1;
        private System.Windows.Forms.Button btAdd1;
        private System.Windows.Forms.Button btMod1;
        private System.Windows.Forms.Button btDel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbSearch1;
        internal System.Windows.Forms.DataGridView dgvProd;
        internal System.Windows.Forms.BindingSource productBindingSource;
        internal System.Windows.Forms.BindingSource partBindingSource;
        internal System.Windows.Forms.DataGridView dgvPart;
        internal System.Windows.Forms.Button btMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMax1;
        internal System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMach;
    }
}

