namespace WindowsFormsApp2
{
    partial class manager
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
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.labale2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttickettime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbranchid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtticketid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(79, 14);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(100, 22);
            this.txtcapacity.TabIndex = 7;
            // 
            // labale2
            // 
            this.labale2.AutoSize = true;
            this.labale2.Location = new System.Drawing.Point(4, 17);
            this.labale2.Name = "labale2";
            this.labale2.Size = new System.Drawing.Size(60, 17);
            this.labale2.TabIndex = 6;
            this.labale2.Text = "capacity";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(79, 86);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 22);
            this.txtprice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txttickettime
            // 
            this.txttickettime.Location = new System.Drawing.Point(79, 50);
            this.txttickettime.Name = "txttickettime";
            this.txttickettime.Size = new System.Drawing.Size(100, 22);
            this.txttickettime.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ticket time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "branch ID";
            // 
            // txtbranchid
            // 
            this.txtbranchid.Location = new System.Drawing.Point(79, 156);
            this.txtbranchid.Name = "txtbranchid";
            this.txtbranchid.Size = new System.Drawing.Size(100, 22);
            this.txtbranchid.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "ticket ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtticketid
            // 
            this.txtticketid.Location = new System.Drawing.Point(79, 123);
            this.txtticketid.Name = "txtticketid";
            this.txtticketid.Size = new System.Drawing.Size(100, 22);
            this.txtticketid.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbranchid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtticketid);
            this.Controls.Add(this.txttickettime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.labale2);
            this.Name = "manager";
            this.Text = "manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.Label labale2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttickettime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbranchid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtticketid;
        private System.Windows.Forms.Button button1;
    }
}