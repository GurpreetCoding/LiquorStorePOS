﻿namespace LiquorStorePOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalProfitPanel = new System.Windows.Forms.Panel();
            this.avgMarginPanel = new System.Windows.Forms.Panel();
            this.totalSalesPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 23);
            this.textBox1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(270, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(270, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 96);
            this.panel1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(17, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 53);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(333, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 53);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(169, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 53);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Complete Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.totalProfitPanel);
            this.panel5.Controls.Add(this.avgMarginPanel);
            this.panel5.Controls.Add(this.totalSalesPanel);
            this.panel5.Location = new System.Drawing.Point(804, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 331);
            this.panel5.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Run Stats";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Analytics";
            // 
            // totalProfitPanel
            // 
            this.totalProfitPanel.BackColor = System.Drawing.Color.OliveDrab;
            this.totalProfitPanel.Location = new System.Drawing.Point(3, 182);
            this.totalProfitPanel.Name = "totalProfitPanel";
            this.totalProfitPanel.Size = new System.Drawing.Size(194, 61);
            this.totalProfitPanel.TabIndex = 2;
            // 
            // avgMarginPanel
            // 
            this.avgMarginPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.avgMarginPanel.Location = new System.Drawing.Point(3, 115);
            this.avgMarginPanel.Name = "avgMarginPanel";
            this.avgMarginPanel.Size = new System.Drawing.Size(194, 61);
            this.avgMarginPanel.TabIndex = 1;
            // 
            // totalSalesPanel
            // 
            this.totalSalesPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.totalSalesPanel.Location = new System.Drawing.Point(3, 48);
            this.totalSalesPanel.Name = "totalSalesPanel";
            this.totalSalesPanel.Size = new System.Drawing.Size(194, 61);
            this.totalSalesPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-3, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 751);
            this.panel6.TabIndex = 23;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button5);
            this.panel10.Location = new System.Drawing.Point(15, 252);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(157, 46);
            this.panel10.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Analytics";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button4);
            this.panel9.Location = new System.Drawing.Point(15, 185);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(157, 46);
            this.panel9.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Item Creation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Location = new System.Drawing.Point(15, 118);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(157, 46);
            this.panel8.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "POS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "LiquorPOS";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Location = new System.Drawing.Point(184, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 751);
            this.panel7.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 746);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Panel panel5;
        private Button button2;
        private Label label1;
        private Panel totalProfitPanel;
        private Panel avgMarginPanel;
        private Panel totalSalesPanel;
        private Panel panel6;
        private Panel panel7;
        private Panel panel10;
        private Button button5;
        private Panel panel9;
        private Button button4;
        private Panel panel8;
        private Button button3;
        private Label label2;
    }
}