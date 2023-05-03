namespace StokApp
{
    partial class ContractForm
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
            textBoxLicenseDate = new TextBox();
            textBoxLicenseNo = new TextBox();
            textBoxTelNo = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxTc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label13 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxLicenseDate);
            groupBox1.Controls.Add(textBoxLicenseNo);
            groupBox1.Controls.Add(textBoxTelNo);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxTc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Bilgileri";
            // 
            // textBoxLicenseDate
            // 
            textBoxLicenseDate.Location = new Point(126, 178);
            textBoxLicenseDate.Name = "textBoxLicenseDate";
            textBoxLicenseDate.Size = new Size(100, 25);
            textBoxLicenseDate.TabIndex = 11;
            // 
            // textBoxLicenseNo
            // 
            textBoxLicenseNo.Location = new Point(126, 148);
            textBoxLicenseNo.Name = "textBoxLicenseNo";
            textBoxLicenseNo.Size = new Size(100, 25);
            textBoxLicenseNo.TabIndex = 10;
            // 
            // textBoxTelNo
            // 
            textBoxTelNo.Location = new Point(126, 118);
            textBoxTelNo.Name = "textBoxTelNo";
            textBoxTelNo.Size = new Size(100, 25);
            textBoxTelNo.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(126, 88);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 25);
            textBoxSurname.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(126, 58);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 25);
            textBoxName.TabIndex = 7;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(126, 28);
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(100, 25);
            textBoxTc.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 180);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 5;
            label6.Text = "Ehliyet Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 150);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 4;
            label5.Text = "Ehliyet No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(48, 120);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 90);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 60);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 30);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 0;
            label1.Text = "TC:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(277, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sözleşme";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(127, 178);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 25);
            dateTimePicker2.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(11, 180);
            label13.Name = "label13";
            label13.Size = new Size(110, 21);
            label13.TabIndex = 10;
            label13.Text = "Dönüş Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(24, 150);
            label12.Name = "label12";
            label12.Size = new Size(97, 21);
            label12.TabIndex = 8;
            label12.Text = "Çıkış Tarihi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(66, 120);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 6;
            label11.Text = "Ücret:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(127, 90);
            label10.Name = "label10";
            label10.Size = new Size(39, 21);
            label10.TabIndex = 5;
            label10.Text = "Gün";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(15, 90);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 4;
            label9.Text = "Toplam Gün:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(127, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(105, 25);
            comboBox2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(39, 60);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 2;
            label8.Text = "Kira Türü:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 25);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(73, 30);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 0;
            label7.Text = "Araç:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(361, 133);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 13;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(361, 170);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 14;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(826, 494);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Araçlar";
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 744);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ContractForm";
            Text = "ContractForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxLicenseDate;
        private TextBox textBoxLicenseNo;
        private TextBox textBoxTelNo;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxTc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private TextBox textBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox3;
    }
}