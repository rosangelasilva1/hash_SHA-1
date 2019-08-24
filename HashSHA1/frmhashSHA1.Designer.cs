namespace HashSHA1
{
    partial class frmhashSHA1
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnHashSHA1 = new System.Windows.Forms.Button();
            this.txthashSHA1 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblChaveHashSHA1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(12, 48);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(826, 69);
            this.txtpassword.TabIndex = 0;
            // 
            // btnHashSHA1
            // 
            this.btnHashSHA1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashSHA1.Location = new System.Drawing.Point(271, 134);
            this.btnHashSHA1.Name = "btnHashSHA1";
            this.btnHashSHA1.Size = new System.Drawing.Size(250, 35);
            this.btnHashSHA1.TabIndex = 1;
            this.btnHashSHA1.Text = "Gerar Hash SHA1";
            this.btnHashSHA1.UseVisualStyleBackColor = true;
            this.btnHashSHA1.Click += new System.EventHandler(this.btnHashSHA1_Click);
            // 
            // txthashSHA1
            // 
            this.txthashSHA1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthashSHA1.Location = new System.Drawing.Point(12, 215);
            this.txthashSHA1.Multiline = true;
            this.txthashSHA1.Name = "txthashSHA1";
            this.txthashSHA1.Size = new System.Drawing.Size(826, 51);
            this.txthashSHA1.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 27);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblChaveHashSHA1
            // 
            this.lblChaveHashSHA1.AutoSize = true;
            this.lblChaveHashSHA1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaveHashSHA1.Location = new System.Drawing.Point(12, 194);
            this.lblChaveHashSHA1.Name = "lblChaveHashSHA1";
            this.lblChaveHashSHA1.Size = new System.Drawing.Size(154, 18);
            this.lblChaveHashSHA1.TabIndex = 4;
            this.lblChaveHashSHA1.Text = "Chave Hash SHA1";
            this.lblChaveHashSHA1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmhashSHA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 295);
            this.Controls.Add(this.lblChaveHashSHA1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txthashSHA1);
            this.Controls.Add(this.btnHashSHA1);
            this.Controls.Add(this.txtpassword);
            this.Name = "frmhashSHA1";
            this.Text = "Gerar hash SHA1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnHashSHA1;
        private System.Windows.Forms.TextBox txthashSHA1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblChaveHashSHA1;
    }
}

