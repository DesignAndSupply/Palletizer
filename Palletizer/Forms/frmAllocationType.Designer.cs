namespace Palletizer.Forms
{
    partial class frmAllocationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllocationType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPalletID = new System.Windows.Forms.Label();
            this.cmbPalletID = new System.Windows.Forms.ComboBox();
            this.cviewpalletizervisualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new Palletizer.order_databaseDataSet();
            this.rdoManual = new System.Windows.Forms.RadioButton();
            this.rdoAuto = new System.Windows.Forms.RadioButton();
            this.c_view_palletizer_visualTableAdapter = new Palletizer.order_databaseDataSetTableAdapters.c_view_palletizer_visualTableAdapter();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpalletizervisualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPalletID);
            this.groupBox1.Controls.Add(this.cmbPalletID);
            this.groupBox1.Controls.Add(this.rdoManual);
            this.groupBox1.Controls.Add(this.rdoAuto);
            this.groupBox1.Location = new System.Drawing.Point(219, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection Method";
            // 
            // lblPalletID
            // 
            this.lblPalletID.AutoSize = true;
            this.lblPalletID.Location = new System.Drawing.Point(6, 82);
            this.lblPalletID.Name = "lblPalletID";
            this.lblPalletID.Size = new System.Drawing.Size(50, 13);
            this.lblPalletID.TabIndex = 3;
            this.lblPalletID.Text = "Pallet ID:";
            // 
            // cmbPalletID
            // 
            this.cmbPalletID.DataSource = this.cviewpalletizervisualBindingSource;
            this.cmbPalletID.DisplayMember = "Pallet ID";
            this.cmbPalletID.FormattingEnabled = true;
            this.cmbPalletID.Location = new System.Drawing.Point(8, 98);
            this.cmbPalletID.Name = "cmbPalletID";
            this.cmbPalletID.Size = new System.Drawing.Size(267, 21);
            this.cmbPalletID.TabIndex = 2;
            this.cmbPalletID.ValueMember = "Pallet ID";
            // 
            // cviewpalletizervisualBindingSource
            // 
            this.cviewpalletizervisualBindingSource.DataMember = "c_view_palletizer_visual";
            this.cviewpalletizervisualBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdoManual
            // 
            this.rdoManual.AutoSize = true;
            this.rdoManual.Location = new System.Drawing.Point(6, 50);
            this.rdoManual.Name = "rdoManual";
            this.rdoManual.Size = new System.Drawing.Size(60, 17);
            this.rdoManual.TabIndex = 1;
            this.rdoManual.TabStop = true;
            this.rdoManual.Text = "Manual";
            this.rdoManual.UseVisualStyleBackColor = true;
            this.rdoManual.CheckedChanged += new System.EventHandler(this.rdoManual_CheckedChanged);
            // 
            // rdoAuto
            // 
            this.rdoAuto.AutoSize = true;
            this.rdoAuto.Location = new System.Drawing.Point(6, 27);
            this.rdoAuto.Name = "rdoAuto";
            this.rdoAuto.Size = new System.Drawing.Size(72, 17);
            this.rdoAuto.TabIndex = 0;
            this.rdoAuto.TabStop = true;
            this.rdoAuto.Text = "Automatic";
            this.rdoAuto.UseVisualStyleBackColor = true;
            this.rdoAuto.CheckedChanged += new System.EventHandler(this.rdoAuto_CheckedChanged);
            // 
            // c_view_palletizer_visualTableAdapter
            // 
            this.c_view_palletizer_visualTableAdapter.ClearBeforeFill = true;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Location = new System.Drawing.Point(419, 213);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(75, 23);
            this.cmdSelect.TabIndex = 1;
            this.cmdSelect.Text = "Confirm";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotification.AutoSize = true;
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(36, 34);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 13);
            this.lblNotification.TabIndex = 2;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAllocationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 298);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllocationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Method";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAllocationType_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAllocationType_FormClosed);
            this.Load += new System.EventHandler(this.frmAllocationType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpalletizervisualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPalletID;
        private System.Windows.Forms.ComboBox cmbPalletID;
        private System.Windows.Forms.RadioButton rdoManual;
        private System.Windows.Forms.RadioButton rdoAuto;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource cviewpalletizervisualBindingSource;
        private order_databaseDataSetTableAdapters.c_view_palletizer_visualTableAdapter c_view_palletizer_visualTableAdapter;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.Label lblNotification;
    }
}