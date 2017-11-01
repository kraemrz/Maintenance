namespace ezHomeMaint
{
    partial class showJobFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showJobFrm));
            this.jobDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ezMaintdbDataSet = new ezHomeMaint.ezMaintdbDataSet();
            this.ezMaintdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTableAdapter = new ezHomeMaint.ezMaintdbDataSetTableAdapters.workTableAdapter();
            this.updateJobBtn = new System.Windows.Forms.Button();
            this.deleteJobBtn = new System.Windows.Forms.Button();
            this.jobStatus = new System.Windows.Forms.GroupBox();
            this.waitRdBtn = new System.Windows.Forms.RadioButton();
            this.closedRdBtn = new System.Windows.Forms.RadioButton();
            this.openRdBtn = new System.Windows.Forms.RadioButton();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezMaintdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezMaintdbDataSetBindingSource)).BeginInit();
            this.jobStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobDataGrid
            // 
            this.jobDataGrid.AllowUserToAddRows = false;
            this.jobDataGrid.AllowUserToDeleteRows = false;
            this.jobDataGrid.AutoGenerateColumns = false;
            this.jobDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.jobDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.jobDataGrid.DataSource = this.workBindingSource;
            this.jobDataGrid.Location = new System.Drawing.Point(12, 12);
            this.jobDataGrid.Name = "jobDataGrid";
            this.jobDataGrid.Size = new System.Drawing.Size(896, 422);
            this.jobDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 450;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataMember = "work";
            this.workBindingSource.DataSource = this.ezMaintdbDataSet;
            // 
            // ezMaintdbDataSet
            // 
            this.ezMaintdbDataSet.DataSetName = "ezMaintdbDataSet";
            this.ezMaintdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ezMaintdbDataSetBindingSource
            // 
            this.ezMaintdbDataSetBindingSource.DataSource = this.ezMaintdbDataSet;
            this.ezMaintdbDataSetBindingSource.Position = 0;
            // 
            // workTableAdapter
            // 
            this.workTableAdapter.ClearBeforeFill = true;
            // 
            // updateJobBtn
            // 
            this.updateJobBtn.Location = new System.Drawing.Point(678, 452);
            this.updateJobBtn.Name = "updateJobBtn";
            this.updateJobBtn.Size = new System.Drawing.Size(112, 23);
            this.updateJobBtn.TabIndex = 1;
            this.updateJobBtn.Text = "Update status";
            this.updateJobBtn.UseVisualStyleBackColor = true;
            this.updateJobBtn.Click += new System.EventHandler(this.updateJobBtn_Click);
            // 
            // deleteJobBtn
            // 
            this.deleteJobBtn.Location = new System.Drawing.Point(796, 452);
            this.deleteJobBtn.Name = "deleteJobBtn";
            this.deleteJobBtn.Size = new System.Drawing.Size(112, 23);
            this.deleteJobBtn.TabIndex = 2;
            this.deleteJobBtn.Text = "Delete selected job";
            this.deleteJobBtn.UseVisualStyleBackColor = true;
            this.deleteJobBtn.Click += new System.EventHandler(this.deleteJobBtn_Click);
            // 
            // jobStatus
            // 
            this.jobStatus.Controls.Add(this.waitRdBtn);
            this.jobStatus.Controls.Add(this.closedRdBtn);
            this.jobStatus.Controls.Add(this.openRdBtn);
            this.jobStatus.Location = new System.Drawing.Point(429, 440);
            this.jobStatus.Name = "jobStatus";
            this.jobStatus.Size = new System.Drawing.Size(243, 41);
            this.jobStatus.TabIndex = 3;
            this.jobStatus.TabStop = false;
            this.jobStatus.Text = "Change status of work";
            // 
            // waitRdBtn
            // 
            this.waitRdBtn.AutoSize = true;
            this.waitRdBtn.Location = new System.Drawing.Point(126, 18);
            this.waitRdBtn.Name = "waitRdBtn";
            this.waitRdBtn.Size = new System.Drawing.Size(110, 17);
            this.waitRdBtn.TabIndex = 2;
            this.waitRdBtn.TabStop = true;
            this.waitRdBtn.Text = "Waiting on spares";
            this.waitRdBtn.UseVisualStyleBackColor = true;
            // 
            // closedRdBtn
            // 
            this.closedRdBtn.AutoSize = true;
            this.closedRdBtn.Location = new System.Drawing.Point(63, 18);
            this.closedRdBtn.Name = "closedRdBtn";
            this.closedRdBtn.Size = new System.Drawing.Size(57, 17);
            this.closedRdBtn.TabIndex = 1;
            this.closedRdBtn.TabStop = true;
            this.closedRdBtn.Text = "Closed";
            this.closedRdBtn.UseVisualStyleBackColor = true;
            // 
            // openRdBtn
            // 
            this.openRdBtn.AutoSize = true;
            this.openRdBtn.Location = new System.Drawing.Point(6, 18);
            this.openRdBtn.Name = "openRdBtn";
            this.openRdBtn.Size = new System.Drawing.Size(51, 17);
            this.openRdBtn.TabIndex = 0;
            this.openRdBtn.TabStop = true;
            this.openRdBtn.Text = "Open";
            this.openRdBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(13, 451);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // showJobFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 486);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.jobStatus);
            this.Controls.Add(this.deleteJobBtn);
            this.Controls.Add(this.updateJobBtn);
            this.Controls.Add(this.jobDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showJobFrm";
            this.Text = "Show all job";
            this.Load += new System.EventHandler(this.showJobFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezMaintdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezMaintdbDataSetBindingSource)).EndInit();
            this.jobStatus.ResumeLayout(false);
            this.jobStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView jobDataGrid;
        private System.Windows.Forms.BindingSource ezMaintdbDataSetBindingSource;
        private ezMaintdbDataSet ezMaintdbDataSet;
        private System.Windows.Forms.BindingSource workBindingSource;
        private ezMaintdbDataSetTableAdapters.workTableAdapter workTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateJobBtn;
        private System.Windows.Forms.Button deleteJobBtn;
        private System.Windows.Forms.GroupBox jobStatus;
        private System.Windows.Forms.RadioButton waitRdBtn;
        private System.Windows.Forms.RadioButton closedRdBtn;
        private System.Windows.Forms.RadioButton openRdBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}