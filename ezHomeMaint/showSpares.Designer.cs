namespace ezHomeMaint
{
    partial class showSpares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showSpares));
            this.spareDataGrid = new System.Windows.Forms.DataGridView();
            this.ezMaintdbDataSet = new ezHomeMaint.ezMaintdbDataSet();
            this.sparesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sparesTableAdapter = new ezHomeMaint.ezMaintdbDataSetTableAdapters.sparesTableAdapter();
            this.editQuantity = new System.Windows.Forms.Button();
            this.deleteSpare = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newQty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spareDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezMaintdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newQty)).BeginInit();
            this.SuspendLayout();
            // 
            // spareDataGrid
            // 
            this.spareDataGrid.AllowUserToAddRows = false;
            this.spareDataGrid.AllowUserToDeleteRows = false;
            this.spareDataGrid.AutoGenerateColumns = false;
            this.spareDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.spareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spareDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.spareNumberDataGridViewTextBoxColumn,
            this.spareNameDataGridViewTextBoxColumn,
            this.sparePlaceDataGridViewTextBoxColumn,
            this.spareQtyDataGridViewTextBoxColumn});
            this.spareDataGrid.DataSource = this.sparesBindingSource;
            this.spareDataGrid.Location = new System.Drawing.Point(13, 13);
            this.spareDataGrid.Name = "spareDataGrid";
            this.spareDataGrid.Size = new System.Drawing.Size(896, 422);
            this.spareDataGrid.TabIndex = 0;
            // 
            // ezMaintdbDataSet
            // 
            this.ezMaintdbDataSet.DataSetName = "ezMaintdbDataSet";
            this.ezMaintdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sparesBindingSource
            // 
            this.sparesBindingSource.DataMember = "spares";
            this.sparesBindingSource.DataSource = this.ezMaintdbDataSet;
            // 
            // sparesTableAdapter
            // 
            this.sparesTableAdapter.ClearBeforeFill = true;
            // 
            // editQuantity
            // 
            this.editQuantity.Location = new System.Drawing.Point(694, 451);
            this.editQuantity.Name = "editQuantity";
            this.editQuantity.Size = new System.Drawing.Size(101, 23);
            this.editQuantity.TabIndex = 1;
            this.editQuantity.Text = "Update quantity";
            this.editQuantity.UseVisualStyleBackColor = true;
            this.editQuantity.Click += new System.EventHandler(this.editQuantity_Click);
            // 
            // deleteSpare
            // 
            this.deleteSpare.Location = new System.Drawing.Point(801, 451);
            this.deleteSpare.Name = "deleteSpare";
            this.deleteSpare.Size = new System.Drawing.Size(101, 23);
            this.deleteSpare.TabIndex = 2;
            this.deleteSpare.Text = "Delete spare part";
            this.deleteSpare.UseVisualStyleBackColor = true;
            this.deleteSpare.Click += new System.EventHandler(this.deleteSpare_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 451);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spareNumberDataGridViewTextBoxColumn
            // 
            this.spareNumberDataGridViewTextBoxColumn.DataPropertyName = "spareNumber";
            this.spareNumberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.spareNumberDataGridViewTextBoxColumn.Name = "spareNumberDataGridViewTextBoxColumn";
            this.spareNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // spareNameDataGridViewTextBoxColumn
            // 
            this.spareNameDataGridViewTextBoxColumn.DataPropertyName = "spareName";
            this.spareNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.spareNameDataGridViewTextBoxColumn.Name = "spareNameDataGridViewTextBoxColumn";
            this.spareNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // sparePlaceDataGridViewTextBoxColumn
            // 
            this.sparePlaceDataGridViewTextBoxColumn.DataPropertyName = "sparePlace";
            this.sparePlaceDataGridViewTextBoxColumn.HeaderText = "Place";
            this.sparePlaceDataGridViewTextBoxColumn.Name = "sparePlaceDataGridViewTextBoxColumn";
            this.sparePlaceDataGridViewTextBoxColumn.Width = 200;
            // 
            // spareQtyDataGridViewTextBoxColumn
            // 
            this.spareQtyDataGridViewTextBoxColumn.DataPropertyName = "spareQty";
            this.spareQtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.spareQtyDataGridViewTextBoxColumn.Name = "spareQtyDataGridViewTextBoxColumn";
            // 
            // newQty
            // 
            this.newQty.Location = new System.Drawing.Point(568, 453);
            this.newQty.Name = "newQty";
            this.newQty.Size = new System.Drawing.Size(120, 20);
            this.newQty.TabIndex = 4;
            // 
            // showSpares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 486);
            this.Controls.Add(this.newQty);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteSpare);
            this.Controls.Add(this.editQuantity);
            this.Controls.Add(this.spareDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showSpares";
            this.Text = "Show Spare parts";
            this.Load += new System.EventHandler(this.showSpares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spareDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezMaintdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView spareDataGrid;
        private ezMaintdbDataSet ezMaintdbDataSet;
        private System.Windows.Forms.BindingSource sparesBindingSource;
        private ezMaintdbDataSetTableAdapters.sparesTableAdapter sparesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editQuantity;
        private System.Windows.Forms.Button deleteSpare;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.NumericUpDown newQty;
    }
}