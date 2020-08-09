namespace StockUpdater
{
    partial class StockUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUpdater));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpStockFileLocation = new System.Windows.Forms.GroupBox();
            this.txtStockFileLocation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChangeFileLocation = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpStockFileLocation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 4;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(693, 540);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpStockFileLocation
            // 
            this.grpStockFileLocation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpStockFileLocation.Controls.Add(this.btnBrowse);
            this.grpStockFileLocation.Controls.Add(this.btnChangeFileLocation);
            this.grpStockFileLocation.Controls.Add(this.txtStockFileLocation);
            this.grpStockFileLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.grpStockFileLocation.Location = new System.Drawing.Point(66, 65);
            this.grpStockFileLocation.Name = "grpStockFileLocation";
            this.grpStockFileLocation.Size = new System.Drawing.Size(729, 83);
            this.grpStockFileLocation.TabIndex = 2;
            this.grpStockFileLocation.TabStop = false;
            this.grpStockFileLocation.Text = "Stock File Location";
            // 
            // txtStockFileLocation
            // 
            this.txtStockFileLocation.Enabled = false;
            this.txtStockFileLocation.Location = new System.Drawing.Point(8, 16);
            this.txtStockFileLocation.Name = "txtStockFileLocation";
            this.txtStockFileLocation.Size = new System.Drawing.Size(606, 20);
            this.txtStockFileLocation.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(66, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock File Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnChangeFileLocation
            // 
            this.btnChangeFileLocation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeFileLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangeFileLocation.Location = new System.Drawing.Point(627, 47);
            this.btnChangeFileLocation.Name = "btnChangeFileLocation";
            this.btnChangeFileLocation.Size = new System.Drawing.Size(93, 23);
            this.btnChangeFileLocation.TabIndex = 1;
            this.btnChangeFileLocation.Text = "Change";
            this.btnChangeFileLocation.UseVisualStyleBackColor = false;
            this.btnChangeFileLocation.Click += new System.EventHandler(this.btnChangeFileLocation_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Location = new System.Drawing.Point(627, 14);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Select";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 4;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(578, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StockUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StockUpdater.Properties.Resources.Black_0037;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 597);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStockFileLocation);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Updater";
            this.grpStockFileLocation.ResumeLayout(false);
            this.grpStockFileLocation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpStockFileLocation;
        private System.Windows.Forms.TextBox txtStockFileLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChangeFileLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
    }
}

