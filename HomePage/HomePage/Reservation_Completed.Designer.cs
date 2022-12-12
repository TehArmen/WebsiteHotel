namespace HomePage
{
    partial class Reservation_Completed
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.codeConf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(350, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Resend Email";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thank you for booking with us! We sent email confirmation to the email below.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(350, 145);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 15);
            this.email.TabIndex = 2;
            this.email.Text = "label2";
            this.email.Click += new System.EventHandler(this.label2_Click);
            // 
            // codeConf
            // 
            this.codeConf.AutoSize = true;
            this.codeConf.Location = new System.Drawing.Point(356, 108);
            this.codeConf.Name = "codeConf";
            this.codeConf.Size = new System.Drawing.Size(38, 15);
            this.codeConf.TabIndex = 3;
            this.codeConf.Text = "label3";
            this.codeConf.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Reservation_Completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codeConf);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Reservation_Completed";
            this.Text = "Reservation_Completed";
            this.Load += new System.EventHandler(this.Reservation_Completed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private Label email;
        private Label codeConf;
    }
}