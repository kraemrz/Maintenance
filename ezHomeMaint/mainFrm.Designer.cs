namespace ezHomeMaint
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.menuLbl = new System.Windows.Forms.Label();
            this.createJobBtn = new System.Windows.Forms.Button();
            this.viewJobBtn = new System.Windows.Forms.Button();
            this.createSpareBtn = new System.Windows.Forms.Button();
            this.viewSparesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(12, 9);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(66, 25);
            this.menuLbl.TabIndex = 0;
            this.menuLbl.Text = "Menu";
            // 
            // createJobBtn
            // 
            this.createJobBtn.Location = new System.Drawing.Point(17, 46);
            this.createJobBtn.Name = "createJobBtn";
            this.createJobBtn.Size = new System.Drawing.Size(112, 24);
            this.createJobBtn.TabIndex = 5;
            this.createJobBtn.Text = "Create job";
            this.createJobBtn.UseVisualStyleBackColor = true;
            this.createJobBtn.Click += new System.EventHandler(this.createJobBtn_Click);
            // 
            // viewJobBtn
            // 
            this.viewJobBtn.Location = new System.Drawing.Point(17, 76);
            this.viewJobBtn.Name = "viewJobBtn";
            this.viewJobBtn.Size = new System.Drawing.Size(112, 24);
            this.viewJobBtn.TabIndex = 6;
            this.viewJobBtn.Text = "View jobs";
            this.viewJobBtn.UseVisualStyleBackColor = true;
            this.viewJobBtn.Click += new System.EventHandler(this.viewJobBtn_Click);
            // 
            // createSpareBtn
            // 
            this.createSpareBtn.Location = new System.Drawing.Point(17, 104);
            this.createSpareBtn.Name = "createSpareBtn";
            this.createSpareBtn.Size = new System.Drawing.Size(112, 24);
            this.createSpareBtn.TabIndex = 7;
            this.createSpareBtn.Text = "Create sparepart";
            this.createSpareBtn.UseVisualStyleBackColor = true;
            this.createSpareBtn.Click += new System.EventHandler(this.createSpareBtn_Click);
            // 
            // viewSparesBtn
            // 
            this.viewSparesBtn.Location = new System.Drawing.Point(17, 134);
            this.viewSparesBtn.Name = "viewSparesBtn";
            this.viewSparesBtn.Size = new System.Drawing.Size(112, 24);
            this.viewSparesBtn.TabIndex = 8;
            this.viewSparesBtn.Text = "View spareparts";
            this.viewSparesBtn.UseVisualStyleBackColor = true;
            this.viewSparesBtn.Click += new System.EventHandler(this.viewSparesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(17, 225);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(694, 260);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewSparesBtn);
            this.Controls.Add(this.createSpareBtn);
            this.Controls.Add(this.viewJobBtn);
            this.Controls.Add(this.createJobBtn);
            this.Controls.Add(this.menuLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFrm";
            this.Text = "Easy House Maint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.Button createJobBtn;
        private System.Windows.Forms.Button viewJobBtn;
        private System.Windows.Forms.Button createSpareBtn;
        private System.Windows.Forms.Button viewSparesBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

