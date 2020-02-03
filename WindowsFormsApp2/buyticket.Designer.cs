namespace WindowsFormsApp2
{
    partial class buyticket
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
            this.txtticketdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdistination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtticketdate
            // 
            this.txtticketdate.Location = new System.Drawing.Point(136, 105);
            this.txtticketdate.Name = "txtticketdate";
            this.txtticketdate.Size = new System.Drawing.Size(100, 22);
            this.txtticketdate.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "ticket date";
            // 
            // txtdistination
            // 
            this.txtdistination.Location = new System.Drawing.Point(136, 67);
            this.txtdistination.Name = "txtdistination";
            this.txtdistination.Size = new System.Drawing.Size(100, 22);
            this.txtdistination.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "distination";
            // 
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(136, 26);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(100, 22);
            this.txtorigin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "origin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "RESERVE NEW TICKET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buyticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtticketdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdistination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "buyticket";
            this.Text = "buyticket";
            this.Load += new System.EventHandler(this.buyticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtticketdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdistination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}