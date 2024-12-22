namespace LiquorStorePOS
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
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(500, 23);
            textBox1.TabIndex = 14;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(12, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 583);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(500, 96);
            panel1.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Location = new Point(17, 22);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(146, 53);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(333, 22);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(164, 53);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(169, 22);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(158, 53);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(345, 698);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(167, 23);
            button1.TabIndex = 21;
            button1.Text = "Complete Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1370, 746);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
    }
}