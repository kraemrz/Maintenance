namespace ezHomeMaint
{
    partial class createSpare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createSpare));
            this.artLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.artTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.locTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // artLbl
            // 
            this.artLbl.AutoSize = true;
            this.artLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artLbl.Location = new System.Drawing.Point(12, 80);
            this.artLbl.Name = "artLbl";
            this.artLbl.Size = new System.Drawing.Size(78, 16);
            this.artLbl.TabIndex = 0;
            this.artLbl.Text = "Art.Number:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 107);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(48, 16);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name:";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.Location = new System.Drawing.Point(12, 134);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(62, 16);
            this.locationLbl.TabIndex = 2;
            this.locationLbl.Text = "Location:";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(12, 164);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(59, 16);
            this.quantityLbl.TabIndex = 3;
            this.quantityLbl.Text = "Quantity:";
            // 
            // artTxt
            // 
            this.artTxt.Location = new System.Drawing.Point(96, 76);
            this.artTxt.Name = "artTxt";
            this.artTxt.Size = new System.Drawing.Size(100, 20);
            this.artTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(96, 103);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 5;
            // 
            // locTxt
            // 
            this.locTxt.Location = new System.Drawing.Point(96, 130);
            this.locTxt.Name = "locTxt";
            this.locTxt.Size = new System.Drawing.Size(100, 20);
            this.locTxt.TabIndex = 6;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(96, 157);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(100, 20);
            this.quantityTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add new sparepart";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(121, 200);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(18, 200);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // createSpare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(213, 235);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.locTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.artTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.artLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createSpare";
            this.Text = "Create Spare";
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label artLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox artTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox locTxt;
        private System.Windows.Forms.NumericUpDown quantityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}