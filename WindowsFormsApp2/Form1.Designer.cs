namespace WindowsFormsApp2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.txtdistination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtticketdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "RESERVE NEW TICKET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "origin";
            // 
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(115, 49);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(100, 22);
            this.txtorigin.TabIndex = 2;
            this.txtorigin.TextChanged += new System.EventHandler(this.txtorigin_TextChanged);
            // 
            // txtdistination
            // 
            this.txtdistination.Location = new System.Drawing.Point(115, 90);
            this.txtdistination.Name = "txtdistination";
            this.txtdistination.Size = new System.Drawing.Size(100, 22);
            this.txtdistination.TabIndex = 9;
            this.txtdistination.TextChanged += new System.EventHandler(this.txtdistination_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "distination";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtticketdate
            // 
            this.txtticketdate.Location = new System.Drawing.Point(115, 128);
            this.txtticketdate.Name = "txtticketdate";
            this.txtticketdate.Size = new System.Drawing.Size(100, 22);
            this.txtticketdate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ticket date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 280);
            this.Controls.Add(this.txtticketdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdistination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtorigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "user page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.TextBox txtdistination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtticketdate;
        private System.Windows.Forms.Label label5;
    }
}

