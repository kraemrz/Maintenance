namespace ezHomeMaint
{
    partial class createJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createJob));
            this.nameLbl = new System.Windows.Forms.Label();
            this.roomTxt = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.jobStatusTxt = new System.Windows.Forms.ComboBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addJobBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(13, 13);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(96, 16);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name of room:";
            // 
            // roomTxt
            // 
            this.roomTxt.Location = new System.Drawing.Point(115, 13);
            this.roomTxt.Name = "roomTxt";
            this.roomTxt.Size = new System.Drawing.Size(177, 20);
            this.roomTxt.TabIndex = 1;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(13, 55);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(88, 16);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "Todays date:";
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(115, 51);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(177, 20);
            this.dateTxt.TabIndex = 3;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.Location = new System.Drawing.Point(13, 92);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(79, 16);
            this.descriptionlbl.TabIndex = 4;
            this.descriptionlbl.Text = "Description:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(115, 91);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(177, 96);
            this.descriptionTxt.TabIndex = 5;
            this.descriptionTxt.Text = "";
            // 
            // jobStatusTxt
            // 
            this.jobStatusTxt.FormattingEnabled = true;
            this.jobStatusTxt.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Waiting on spares"});
            this.jobStatusTxt.Location = new System.Drawing.Point(115, 194);
            this.jobStatusTxt.Name = "jobStatusTxt";
            this.jobStatusTxt.Size = new System.Drawing.Size(177, 21);
            this.jobStatusTxt.TabIndex = 6;
            this.jobStatusTxt.Text = "Open";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(13, 199);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(45, 16);
            this.statusLbl.TabIndex = 7;
            this.statusLbl.Text = "Status";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(16, 259);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addJobBtn
            // 
            this.addJobBtn.Location = new System.Drawing.Point(209, 259);
            this.addJobBtn.Name = "addJobBtn";
            this.addJobBtn.Size = new System.Drawing.Size(75, 23);
            this.addJobBtn.TabIndex = 9;
            this.addJobBtn.Text = "Add job";
            this.addJobBtn.UseVisualStyleBackColor = true;
            this.addJobBtn.Click += new System.EventHandler(this.addJobBtn_Click);
            // 
            // createJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 294);
            this.Controls.Add(this.addJobBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.jobStatusTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.roomTxt);
            this.Controls.Add(this.nameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createJob";
            this.Text = "Create job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox roomTxt;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.RichTextBox descriptionTxt;
        private System.Windows.Forms.ComboBox jobStatusTxt;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button addJobBtn;
    }
}