namespace IP_to_Location
{
    partial class FrmIPAddrHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnFetchLocationDetails = new System.Windows.Forms.Button();
            this.txtIPLocationResult = new System.Windows.Forms.TextBox();
            this.btnFetchCurrentIPLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address: ";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(104, 50);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // btnFetchLocationDetails
            // 
            this.btnFetchLocationDetails.Location = new System.Drawing.Point(147, 95);
            this.btnFetchLocationDetails.Name = "btnFetchLocationDetails";
            this.btnFetchLocationDetails.Size = new System.Drawing.Size(109, 23);
            this.btnFetchLocationDetails.TabIndex = 2;
            this.btnFetchLocationDetails.Text = "Fetch Location";
            this.btnFetchLocationDetails.UseVisualStyleBackColor = true;
            this.btnFetchLocationDetails.Click += new System.EventHandler(this.btnFetchLocationDetails_Click);
            // 
            // txtIPLocationResult
            // 
            this.txtIPLocationResult.Location = new System.Drawing.Point(41, 137);
            this.txtIPLocationResult.Multiline = true;
            this.txtIPLocationResult.Name = "txtIPLocationResult";
            this.txtIPLocationResult.Size = new System.Drawing.Size(215, 112);
            this.txtIPLocationResult.TabIndex = 3;
            // 
            // btnFetchCurrentIPLocation
            // 
            this.btnFetchCurrentIPLocation.Location = new System.Drawing.Point(41, 95);
            this.btnFetchCurrentIPLocation.Name = "btnFetchCurrentIPLocation";
            this.btnFetchCurrentIPLocation.Size = new System.Drawing.Size(100, 23);
            this.btnFetchCurrentIPLocation.TabIndex = 4;
            this.btnFetchCurrentIPLocation.Text = "Fetch Current IP";
            this.btnFetchCurrentIPLocation.UseVisualStyleBackColor = true;
            this.btnFetchCurrentIPLocation.Click += new System.EventHandler(this.btnFetchCurrentIPLocation_Click);
            // 
            // FrmIPAddrHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFetchCurrentIPLocation);
            this.Controls.Add(this.txtIPLocationResult);
            this.Controls.Add(this.btnFetchLocationDetails);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Name = "FrmIPAddrHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track IP Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnFetchLocationDetails;
        private System.Windows.Forms.TextBox txtIPLocationResult;
        private System.Windows.Forms.Button btnFetchCurrentIPLocation;
    }
}

