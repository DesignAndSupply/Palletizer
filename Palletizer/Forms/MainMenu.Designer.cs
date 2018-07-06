namespace Palletizer
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.txtDoorNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgVisual = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVisualDoor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.palletIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtySameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorMassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cviewpalletizervisualdoorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new Palletizer.order_databaseDataSet();
            this.palletIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palletMassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cviewpalletizervisualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_palletizer_visualTableAdapter = new Palletizer.order_databaseDataSetTableAdapters.c_view_palletizer_visualTableAdapter();
            this.c_view_palletizer_visual_doorTableAdapter = new Palletizer.order_databaseDataSetTableAdapters.c_view_palletizer_visual_doorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpalletizervisualdoorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpalletizervisualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoorNumber
            // 
            this.txtDoorNumber.Location = new System.Drawing.Point(91, 27);
            this.txtDoorNumber.Name = "txtDoorNumber";
            this.txtDoorNumber.Size = new System.Drawing.Size(66, 20);
            this.txtDoorNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Door Number:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Weld",
            "Buff",
            "Paint"});
            this.cmbDepartment.Location = new System.Drawing.Point(91, 54);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(157, 21);
            this.cmbDepartment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(254, 53);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgVisual
            // 
            this.dgVisual.AllowUserToAddRows = false;
            this.dgVisual.AllowUserToDeleteRows = false;
            this.dgVisual.AllowUserToResizeColumns = false;
            this.dgVisual.AllowUserToResizeRows = false;
            this.dgVisual.AutoGenerateColumns = false;
            this.dgVisual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palletIDDataGridViewTextBoxColumn,
            this.freeDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.palletMassDataGridViewTextBoxColumn});
            this.dgVisual.DataSource = this.cviewpalletizervisualBindingSource;
            this.dgVisual.Location = new System.Drawing.Point(12, 120);
            this.dgVisual.Name = "dgVisual";
            this.dgVisual.RowHeadersVisible = false;
            this.dgVisual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisual.Size = new System.Drawing.Size(446, 487);
            this.dgVisual.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Pallet ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dgVisualDoor
            // 
            this.dgVisualDoor.AllowUserToAddRows = false;
            this.dgVisualDoor.AllowUserToDeleteRows = false;
            this.dgVisualDoor.AllowUserToOrderColumns = true;
            this.dgVisualDoor.AutoGenerateColumns = false;
            this.dgVisualDoor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisualDoor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgVisualDoor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualDoor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palletIDDataGridViewTextBoxColumn1,
            this.orderIDDataGridViewTextBoxColumn,
            this.doorIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.qtySameDataGridViewTextBoxColumn,
            this.doorTypeDataGridViewTextBoxColumn,
            this.doorMassDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn1});
            this.dgVisualDoor.DataSource = this.cviewpalletizervisualdoorBindingSource;
            this.dgVisualDoor.Location = new System.Drawing.Point(464, 120);
            this.dgVisualDoor.Name = "dgVisualDoor";
            this.dgVisualDoor.RowHeadersVisible = false;
            this.dgVisualDoor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisualDoor.Size = new System.Drawing.Size(828, 487);
            this.dgVisualDoor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pallet Load:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Door information:";
            // 
            // palletIDDataGridViewTextBoxColumn1
            // 
            this.palletIDDataGridViewTextBoxColumn1.DataPropertyName = "Pallet ID";
            this.palletIDDataGridViewTextBoxColumn1.HeaderText = "Pallet ID";
            this.palletIDDataGridViewTextBoxColumn1.Name = "palletIDDataGridViewTextBoxColumn1";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // doorIDDataGridViewTextBoxColumn
            // 
            this.doorIDDataGridViewTextBoxColumn.DataPropertyName = "Door ID";
            this.doorIDDataGridViewTextBoxColumn.HeaderText = "Door ID";
            this.doorIDDataGridViewTextBoxColumn.Name = "doorIDDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // qtySameDataGridViewTextBoxColumn
            // 
            this.qtySameDataGridViewTextBoxColumn.DataPropertyName = "Qty Same";
            this.qtySameDataGridViewTextBoxColumn.HeaderText = "Qty Same";
            this.qtySameDataGridViewTextBoxColumn.Name = "qtySameDataGridViewTextBoxColumn";
            // 
            // doorTypeDataGridViewTextBoxColumn
            // 
            this.doorTypeDataGridViewTextBoxColumn.DataPropertyName = "Door Type";
            this.doorTypeDataGridViewTextBoxColumn.HeaderText = "Door Type";
            this.doorTypeDataGridViewTextBoxColumn.Name = "doorTypeDataGridViewTextBoxColumn";
            // 
            // doorMassDataGridViewTextBoxColumn
            // 
            this.doorMassDataGridViewTextBoxColumn.DataPropertyName = "Door Mass";
            this.doorMassDataGridViewTextBoxColumn.HeaderText = "Door Mass";
            this.doorMassDataGridViewTextBoxColumn.Name = "doorMassDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            // 
            // cviewpalletizervisualdoorBindingSource
            // 
            this.cviewpalletizervisualdoorBindingSource.DataMember = "c_view_palletizer_visual_door";
            this.cviewpalletizervisualdoorBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palletIDDataGridViewTextBoxColumn
            // 
            this.palletIDDataGridViewTextBoxColumn.DataPropertyName = "Pallet ID";
            this.palletIDDataGridViewTextBoxColumn.HeaderText = "Pallet ID";
            this.palletIDDataGridViewTextBoxColumn.Name = "palletIDDataGridViewTextBoxColumn";
            // 
            // freeDataGridViewTextBoxColumn
            // 
            this.freeDataGridViewTextBoxColumn.DataPropertyName = "Free";
            this.freeDataGridViewTextBoxColumn.HeaderText = "Free";
            this.freeDataGridViewTextBoxColumn.Name = "freeDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // palletMassDataGridViewTextBoxColumn
            // 
            this.palletMassDataGridViewTextBoxColumn.DataPropertyName = "Pallet Mass";
            this.palletMassDataGridViewTextBoxColumn.HeaderText = "Pallet Mass";
            this.palletMassDataGridViewTextBoxColumn.Name = "palletMassDataGridViewTextBoxColumn";
            // 
            // cviewpalletizervisualBindingSource
            // 
            this.cviewpalletizervisualBindingSource.DataMember = "c_view_palletizer_visual";
            this.cviewpalletizervisualBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // c_view_palletizer_visualTableAdapter
            // 
            this.c_view_palletizer_visualTableAdapter.ClearBeforeFill = true;
            // 
            // c_view_palletizer_visual_doorTableAdapter
            // 
            this.c_view_palletizer_visual_doorTableAdapter.ClearBeforeFill = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 622);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgVisualDoor);
            this.Controls.Add(this.dgVisual);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoorNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palletizer";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpalletizervisualdoorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewpalletizervisualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoorNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgVisual;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource cviewpalletizervisualBindingSource;
        private order_databaseDataSetTableAdapters.c_view_palletizer_visualTableAdapter c_view_palletizer_visualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn palletIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palletMassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cviewpalletizervisualdoorBindingSource;
        private order_databaseDataSetTableAdapters.c_view_palletizer_visual_doorTableAdapter c_view_palletizer_visual_doorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgVisualDoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn palletIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtySameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorMassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

