
namespace IMS_
{
    partial class F2Pa
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
            this.lbPartT = new System.Windows.Forms.Label();
            this.rdIn = new System.Windows.Forms.RadioButton();
            this.rdOut = new System.Windows.Forms.RadioButton();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbInv = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbSrc = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInv = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCc = new System.Windows.Forms.Button();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPartT
            // 
            this.lbPartT.AutoSize = true;
            this.lbPartT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartT.Location = new System.Drawing.Point(10, 12);
            this.lbPartT.Name = "lbPartT";
            this.lbPartT.Size = new System.Drawing.Size(49, 25);
            this.lbPartT.TabIndex = 0;
            this.lbPartT.Text = "Add";
            // 
            // rdIn
            // 
            this.rdIn.AutoSize = true;
            this.rdIn.Location = new System.Drawing.Point(12, 64);
            this.rdIn.Name = "rdIn";
            this.rdIn.Size = new System.Drawing.Size(68, 17);
            this.rdIn.TabIndex = 1;
            this.rdIn.Text = "In-House";
            this.rdIn.UseVisualStyleBackColor = true;
            this.rdIn.CheckedChanged += new System.EventHandler(this.rdIn_CheckedChanged);
            // 
            // rdOut
            // 
            this.rdOut.AutoSize = true;
            this.rdOut.Location = new System.Drawing.Point(86, 64);
            this.rdOut.Name = "rdOut";
            this.rdOut.Size = new System.Drawing.Size(74, 17);
            this.rdOut.TabIndex = 2;
            this.rdOut.Text = "Outsource";
            this.rdOut.UseVisualStyleBackColor = true;
            this.rdOut.CheckedChanged += new System.EventHandler(this.rdOut_CheckedChanged);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(11, 90);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(11, 116);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbInv
            // 
            this.lbInv.AutoSize = true;
            this.lbInv.Location = new System.Drawing.Point(11, 142);
            this.lbInv.Name = "lbInv";
            this.lbInv.Size = new System.Drawing.Size(25, 13);
            this.lbInv.TabIndex = 2;
            this.lbInv.Text = "Inv.";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(11, 168);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(11, 194);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(27, 13);
            this.lbMin.TabIndex = 2;
            this.lbMin.Text = "Min.";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(11, 220);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(30, 13);
            this.lbMax.TabIndex = 2;
            this.lbMax.Text = "Max.";
            // 
            // lbSrc
            // 
            this.lbSrc.AutoSize = true;
            this.lbSrc.Location = new System.Drawing.Point(11, 246);
            this.lbSrc.Name = "lbSrc";
            this.lbSrc.Size = new System.Drawing.Size(41, 13);
            this.lbSrc.TabIndex = 2;
            this.lbSrc.Text = "Source";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(69, 87);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 3;
            this.tbID.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(69, 113);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Part";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbInv
            // 
            this.tbInv.Location = new System.Drawing.Point(69, 139);
            this.tbInv.Name = "tbInv";
            this.tbInv.Size = new System.Drawing.Size(100, 20);
            this.tbInv.TabIndex = 5;
            this.tbInv.Text = "1";
            this.tbInv.TextChanged += new System.EventHandler(this.tbInv_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(69, 165);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 6;
            this.tbPrice.Text = "1";
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(69, 191);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 7;
            this.tbMin.Text = "1";
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(69, 217);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 8;
            this.tbMax.Text = "2";
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // tbSrc
            // 
            this.tbSrc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSrc.Location = new System.Drawing.Point(69, 243);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(100, 20);
            this.tbSrc.TabIndex = 9;
            this.tbSrc.TextChanged += new System.EventHandler(this.tbSrc_TextChanged);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(123, 279);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCc
            // 
            this.btCc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCc.Location = new System.Drawing.Point(123, 12);
            this.btCc.Name = "btCc";
            this.btCc.Size = new System.Drawing.Size(75, 23);
            this.btCc.TabIndex = 11;
            this.btCc.Text = "Cancel";
            this.btCc.UseVisualStyleBackColor = true;
            this.btCc.Click += new System.EventHandler(this.btCc_Click);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(IMS_.Part);
            // 
            // F2Pa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(210, 314);
            this.Controls.Add(this.btCc);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbInv);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbSrc);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbInv);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.rdOut);
            this.Controls.Add(this.rdIn);
            this.Controls.Add(this.lbPartT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F2Pa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.Load += new System.EventHandler(this.F2Pa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdIn;
        private System.Windows.Forms.RadioButton rdOut;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbInv;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Button btCc;
        private System.Windows.Forms.Label lbSrc;
        internal System.Windows.Forms.Label lbPartT;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbInv;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbSrc;
        internal System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.TextBox tbName;
    }
}