namespace DoAn
{
    partial class Login_Interface
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
            this.logpassGP = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.passt = new System.Windows.Forms.TextBox();
            this.usernamet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userName_LB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logpassGP.SuspendLayout();
            this.SuspendLayout();
            // 
            // logpassGP
            // 
            this.logpassGP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(55)))), ((int)(((byte)(103)))));
            this.logpassGP.Controls.Add(this.button1);
            this.logpassGP.Controls.Add(this.Cancel);
            this.logpassGP.Controls.Add(this.Login);
            this.logpassGP.Controls.Add(this.passt);
            this.logpassGP.Controls.Add(this.usernamet);
            this.logpassGP.Controls.Add(this.label2);
            this.logpassGP.Controls.Add(this.userName_LB);
            this.logpassGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpassGP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logpassGP.Location = new System.Drawing.Point(58, 65);
            this.logpassGP.Name = "logpassGP";
            this.logpassGP.Size = new System.Drawing.Size(352, 147);
            this.logpassGP.TabIndex = 0;
            this.logpassGP.TabStop = false;
            this.logpassGP.Text = "Login";
            // 
            // Cancel
            // 
            this.Cancel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Cancel.Image = global::DoAn.Properties.Resources.OIP__2_q;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(225, 107);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(102, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Login.Image = global::DoAn.Properties.Resources.loginitemqqq;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(109, 107);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(97, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // passt
            // 
            this.passt.Location = new System.Drawing.Point(94, 62);
            this.passt.Name = "passt";
            this.passt.Size = new System.Drawing.Size(233, 22);
            this.passt.TabIndex = 3;
            // 
            // usernamet
            // 
            this.usernamet.Location = new System.Drawing.Point(94, 32);
            this.usernamet.Name = "usernamet";
            this.usernamet.Size = new System.Drawing.Size(233, 22);
            this.usernamet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // userName_LB
            // 
            this.userName_LB.AutoSize = true;
            this.userName_LB.BackColor = System.Drawing.Color.Transparent;
            this.userName_LB.Location = new System.Drawing.Point(6, 32);
            this.userName_LB.Name = "userName_LB";
            this.userName_LB.Size = new System.Drawing.Size(82, 16);
            this.userName_LB.TabIndex = 0;
            this.userName_LB.Text = "Username:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(13, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn.Properties.Resources.OIP__1_;
            this.ClientSize = new System.Drawing.Size(477, 290);
            this.Controls.Add(this.logpassGP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Interface";
            this.Text = "Login_Interface";
            this.logpassGP.ResumeLayout(false);
            this.logpassGP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logpassGP;
        private System.Windows.Forms.TextBox passt;
        private System.Windows.Forms.TextBox usernamet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userName_LB;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button button1;
    }
}

