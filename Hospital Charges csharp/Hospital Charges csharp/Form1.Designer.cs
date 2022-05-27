
namespace Hospital_Charges_csharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxdays = new System.Windows.Forms.TextBox();
            this.textBoxmeds = new System.Windows.Forms.TextBox();
            this.textBoxsurg = new System.Windows.Forms.TextBox();
            this.textBoxlab = new System.Windows.Forms.TextBox();
            this.textBoxrehab = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelfinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication Charges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physical Rehab Charges";
            // 
            // textBoxdays
            // 
            this.textBoxdays.Location = new System.Drawing.Point(137, 126);
            this.textBoxdays.Name = "textBoxdays";
            this.textBoxdays.Size = new System.Drawing.Size(100, 20);
            this.textBoxdays.TabIndex = 5;
            // 
            // textBoxmeds
            // 
            this.textBoxmeds.Location = new System.Drawing.Point(137, 152);
            this.textBoxmeds.Name = "textBoxmeds";
            this.textBoxmeds.Size = new System.Drawing.Size(100, 20);
            this.textBoxmeds.TabIndex = 6;
            // 
            // textBoxsurg
            // 
            this.textBoxsurg.Location = new System.Drawing.Point(137, 178);
            this.textBoxsurg.Name = "textBoxsurg";
            this.textBoxsurg.Size = new System.Drawing.Size(100, 20);
            this.textBoxsurg.TabIndex = 7;
            // 
            // textBoxlab
            // 
            this.textBoxlab.Location = new System.Drawing.Point(137, 204);
            this.textBoxlab.Name = "textBoxlab";
            this.textBoxlab.Size = new System.Drawing.Size(100, 20);
            this.textBoxlab.TabIndex = 8;
            // 
            // textBoxrehab
            // 
            this.textBoxrehab.Location = new System.Drawing.Point(137, 230);
            this.textBoxrehab.Name = "textBoxrehab";
            this.textBoxrehab.Size = new System.Drawing.Size(100, 20);
            this.textBoxrehab.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelfinal);
            this.groupBox1.Location = new System.Drawing.Point(50, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 62);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final Cost";
            // 
            // labelfinal
            // 
            this.labelfinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelfinal.Location = new System.Drawing.Point(32, 25);
            this.labelfinal.Name = "labelfinal";
            this.labelfinal.Size = new System.Drawing.Size(100, 23);
            this.labelfinal.TabIndex = 0;
            this.labelfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hospital Charges";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 317);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxrehab);
            this.Controls.Add(this.textBoxlab);
            this.Controls.Add(this.textBoxsurg);
            this.Controls.Add(this.textBoxmeds);
            this.Controls.Add(this.textBoxdays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxdays;
        private System.Windows.Forms.TextBox textBoxmeds;
        private System.Windows.Forms.TextBox textBoxsurg;
        private System.Windows.Forms.TextBox textBoxlab;
        private System.Windows.Forms.TextBox textBoxrehab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelfinal;
        private System.Windows.Forms.Label label7;
    }
}

