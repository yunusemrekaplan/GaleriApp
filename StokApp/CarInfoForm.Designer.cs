﻿namespace StokApp
{
    partial class CarInfoForm
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
            groupBox1 = new GroupBox();
            falseCheckBox = new CheckBox();
            trueCheckBox = new CheckBox();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(falseCheckBox);
            groupBox1.Controls.Add(trueCheckBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // falseCheckBox
            // 
            falseCheckBox.AutoSize = true;
            falseCheckBox.Location = new Point(234, 202);
            falseCheckBox.Name = "falseCheckBox";
            falseCheckBox.Size = new Size(54, 19);
            falseCheckBox.TabIndex = 15;
            falseCheckBox.Text = "Hayır";
            falseCheckBox.UseVisualStyleBackColor = true;
            falseCheckBox.CheckedChanged += falseCheckBox_CheckedChanged;
            // 
            // trueCheckBox
            // 
            trueCheckBox.AutoSize = true;
            trueCheckBox.Location = new Point(188, 202);
            trueCheckBox.Name = "trueCheckBox";
            trueCheckBox.Size = new Size(48, 19);
            trueCheckBox.TabIndex = 14;
            trueCheckBox.Text = "Evet";
            trueCheckBox.UseVisualStyleBackColor = true;
            trueCheckBox.CheckedChanged += trueCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(75, 200);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 13;
            label4.Text = "Kiralandı Mı:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 408);
            button3.Name = "button3";
            button3.Size = new Size(89, 30);
            button3.TabIndex = 12;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(294, 238);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 11;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(188, 238);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 8;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(188, 110);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 4;
            label6.Text = "11111";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(122, 170);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 2;
            label3.Text = "Plaka: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(115, 140);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Model: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 110);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Seri No: ";
            // 
            // CarInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CarInfoForm";
            Text = "CarInfoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Button button1;
        private Button button3;
        private Button button2;
        private CheckBox falseCheckBox;
        private CheckBox trueCheckBox;
        private Label label4;
    }
}