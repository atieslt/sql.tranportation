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
            this.label8 = new System.Windows.Forms.Label();
            this.txtidcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 327);
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
            this.txtorigin.Location = new System.Drawing.Point(100, 46);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(100, 22);
            this.txtorigin.TabIndex = 2;
            this.txtorigin.TextChanged += new System.EventHandler(this.txtorigin_TextChanged);
            // 
            // txtdistination
            // 
            this.txtdistination.Location = new System.Drawing.Point(100, 80);
            this.txtdistination.Name = "txtdistination";
            this.txtdistination.Size = new System.Drawing.Size(100, 22);
            this.txtdistination.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "distination";
            // 
            // txtticketdate
            // 
            this.txtticketdate.Location = new System.Drawing.Point(100, 108);
            this.txtticketdate.Name = "txtticketdate";
            this.txtticketdate.Size = new System.Drawing.Size(100, 22);
            this.txtticketdate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ticket date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID code";
            // 
            // txtidcode
            // 
            this.txtidcode.Location = new System.Drawing.Point(100, 146);
            this.txtidcode.Name = "txtidcode";
            this.txtidcode.Size = new System.Drawing.Size(100, 22);
            this.txtidcode.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidcode);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidcode;
    }
}

