namespace WindowsFormsApp2
{
    partial class type_of_ticket
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Taxi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Freight Train";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "Domwstic Flight";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "Freight Ship";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(230, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 67);
            this.button6.TabIndex = 5;
            this.button6.Text = "International Fight";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(230, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 59);
            this.button7.TabIndex = 6;
            this.button7.Text = "Passenger Train";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(230, 311);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 59);
            this.button8.TabIndex = 7;
            this.button8.Text = "Passenger Ship";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // type_of_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 382);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "type_of_ticket";
            this.Text = "type_of_ticket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}