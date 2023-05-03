namespace StokApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfoForm));
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1 = new GroupBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonBack = new Button();
            textBoxPlate = new TextBox();
            textBoxGear = new TextBox();
            textBoxYear = new TextBox();
            textBoxModel = new TextBox();
            textBoxBrand = new TextBox();
            checkBoxNo = new CheckBox();
            checkBoxYes = new CheckBox();
            labelRented = new Label();
            labelPlate = new Label();
            labelGear = new Label();
            labelYear = new Label();
            labelModel = new Label();
            labelBrand = new Label();
            txtSeriNo = new Label();
            labelSeriNo = new Label();
            labelDailyPrice = new Label();
            textBoxDailyPrice = new TextBox();
            textBoxWeeklyPrice = new TextBox();
            labelWeeklyPrice = new Label();
            textBoxMonthlyPrice = new TextBox();
            labelMonthlyPrice = new Label();
            textBoxSixMonthPrice = new TextBox();
            labelsixMonthPrice = new Label();
            textBoxAnnualPrice = new TextBox();
            labelAnnualPrice = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxAnnualPrice);
            groupBox1.Controls.Add(labelAnnualPrice);
            groupBox1.Controls.Add(textBoxSixMonthPrice);
            groupBox1.Controls.Add(labelsixMonthPrice);
            groupBox1.Controls.Add(textBoxMonthlyPrice);
            groupBox1.Controls.Add(labelMonthlyPrice);
            groupBox1.Controls.Add(textBoxWeeklyPrice);
            groupBox1.Controls.Add(labelWeeklyPrice);
            groupBox1.Controls.Add(textBoxDailyPrice);
            groupBox1.Controls.Add(labelDailyPrice);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(textBoxPlate);
            groupBox1.Controls.Add(textBoxGear);
            groupBox1.Controls.Add(textBoxYear);
            groupBox1.Controls.Add(textBoxModel);
            groupBox1.Controls.Add(textBoxBrand);
            groupBox1.Controls.Add(checkBoxNo);
            groupBox1.Controls.Add(checkBoxYes);
            groupBox1.Controls.Add(labelRented);
            groupBox1.Controls.Add(labelPlate);
            groupBox1.Controls.Add(labelGear);
            groupBox1.Controls.Add(labelYear);
            groupBox1.Controls.Add(labelModel);
            groupBox1.Controls.Add(labelBrand);
            groupBox1.Controls.Add(txtSeriNo);
            groupBox1.Controls.Add(labelSeriNo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(697, 444);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(461, 251);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 31);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(360, 251);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(96, 31);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 407);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(86, 31);
            buttonBack.TabIndex = 18;
            buttonBack.Text = "Geri";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxPlate
            // 
            textBoxPlate.Anchor = AnchorStyles.None;
            textBoxPlate.Location = new Point(207, 249);
            textBoxPlate.Name = "textBoxPlate";
            textBoxPlate.Size = new Size(100, 23);
            textBoxPlate.TabIndex = 14;
            // 
            // textBoxGear
            // 
            textBoxGear.Anchor = AnchorStyles.None;
            textBoxGear.Location = new Point(207, 209);
            textBoxGear.Name = "textBoxGear";
            textBoxGear.Size = new Size(100, 23);
            textBoxGear.TabIndex = 13;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.None;
            textBoxYear.Location = new Point(207, 169);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 12;
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.None;
            textBoxModel.Location = new Point(207, 129);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 11;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Anchor = AnchorStyles.None;
            textBoxBrand.Location = new Point(207, 89);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(100, 23);
            textBoxBrand.TabIndex = 10;
            // 
            // checkBoxNo
            // 
            checkBoxNo.Anchor = AnchorStyles.None;
            checkBoxNo.AutoSize = true;
            checkBoxNo.Location = new Point(261, 293);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(54, 19);
            checkBoxNo.TabIndex = 9;
            checkBoxNo.Text = "Hayır";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // checkBoxYes
            // 
            checkBoxYes.Anchor = AnchorStyles.None;
            checkBoxYes.AutoSize = true;
            checkBoxYes.Location = new Point(207, 293);
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.Size = new Size(48, 19);
            checkBoxYes.TabIndex = 8;
            checkBoxYes.Text = "Evet";
            checkBoxYes.UseVisualStyleBackColor = true;
            checkBoxYes.CheckedChanged += checkBoxYes_CheckedChanged;
            // 
            // labelRented
            // 
            labelRented.Anchor = AnchorStyles.None;
            labelRented.AutoSize = true;
            labelRented.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRented.Location = new Point(94, 291);
            labelRented.Name = "labelRented";
            labelRented.Size = new Size(107, 21);
            labelRented.TabIndex = 7;
            labelRented.Text = "Kiralandı mı:";
            // 
            // labelPlate
            // 
            labelPlate.Anchor = AnchorStyles.None;
            labelPlate.AutoSize = true;
            labelPlate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlate.Location = new Point(145, 251);
            labelPlate.Name = "labelPlate";
            labelPlate.Size = new Size(56, 21);
            labelPlate.TabIndex = 6;
            labelPlate.Text = "Plaka:";
            // 
            // labelGear
            // 
            labelGear.Anchor = AnchorStyles.None;
            labelGear.AutoSize = true;
            labelGear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGear.Location = new Point(149, 211);
            labelGear.Name = "labelGear";
            labelGear.Size = new Size(52, 21);
            labelGear.TabIndex = 5;
            labelGear.Text = "Vites:";
            // 
            // labelYear
            // 
            labelYear.Anchor = AnchorStyles.None;
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(167, 171);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(34, 21);
            labelYear.TabIndex = 4;
            labelYear.Text = "Yıl:";
            // 
            // labelModel
            // 
            labelModel.Anchor = AnchorStyles.None;
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(138, 131);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(63, 21);
            labelModel.TabIndex = 3;
            labelModel.Text = "Model:";
            // 
            // labelBrand
            // 
            labelBrand.Anchor = AnchorStyles.None;
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrand.Location = new Point(139, 91);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(62, 21);
            labelBrand.TabIndex = 2;
            labelBrand.Text = "Marka:";
            // 
            // txtSeriNo
            // 
            txtSeriNo.Anchor = AnchorStyles.None;
            txtSeriNo.AutoSize = true;
            txtSeriNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSeriNo.Location = new Point(207, 51);
            txtSeriNo.Name = "txtSeriNo";
            txtSeriNo.Size = new Size(0, 21);
            txtSeriNo.TabIndex = 1;
            // 
            // labelSeriNo
            // 
            labelSeriNo.Anchor = AnchorStyles.None;
            labelSeriNo.AutoSize = true;
            labelSeriNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeriNo.Location = new Point(131, 51);
            labelSeriNo.Name = "labelSeriNo";
            labelSeriNo.Size = new Size(70, 21);
            labelSeriNo.TabIndex = 0;
            labelSeriNo.Text = "Seri No:";
            // 
            // labelDailyPrice
            // 
            labelDailyPrice.AutoSize = true;
            labelDailyPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDailyPrice.Location = new Point(344, 51);
            labelDailyPrice.Name = "labelDailyPrice";
            labelDailyPrice.Size = new Size(114, 21);
            labelDailyPrice.TabIndex = 19;
            labelDailyPrice.Text = "Günlük Ücret:";
            // 
            // textBoxDailyPrice
            // 
            textBoxDailyPrice.Location = new Point(464, 49);
            textBoxDailyPrice.Name = "textBoxDailyPrice";
            textBoxDailyPrice.Size = new Size(100, 23);
            textBoxDailyPrice.TabIndex = 20;
            // 
            // textBoxWeeklyPrice
            // 
            textBoxWeeklyPrice.Location = new Point(464, 89);
            textBoxWeeklyPrice.Name = "textBoxWeeklyPrice";
            textBoxWeeklyPrice.Size = new Size(100, 23);
            textBoxWeeklyPrice.TabIndex = 22;
            // 
            // labelWeeklyPrice
            // 
            labelWeeklyPrice.AutoSize = true;
            labelWeeklyPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWeeklyPrice.Location = new Point(338, 91);
            labelWeeklyPrice.Name = "labelWeeklyPrice";
            labelWeeklyPrice.Size = new Size(120, 21);
            labelWeeklyPrice.TabIndex = 21;
            labelWeeklyPrice.Text = "Haftalık Ücret:";
            // 
            // textBoxMonthlyPrice
            // 
            textBoxMonthlyPrice.Location = new Point(464, 129);
            textBoxMonthlyPrice.Name = "textBoxMonthlyPrice";
            textBoxMonthlyPrice.Size = new Size(100, 23);
            textBoxMonthlyPrice.TabIndex = 24;
            // 
            // labelMonthlyPrice
            // 
            labelMonthlyPrice.AutoSize = true;
            labelMonthlyPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonthlyPrice.Location = new Point(360, 131);
            labelMonthlyPrice.Name = "labelMonthlyPrice";
            labelMonthlyPrice.Size = new Size(98, 21);
            labelMonthlyPrice.TabIndex = 23;
            labelMonthlyPrice.Text = "Aylık Ücret:";
            // 
            // textBoxSixMonthPrice
            // 
            textBoxSixMonthPrice.Location = new Point(464, 169);
            textBoxSixMonthPrice.Name = "textBoxSixMonthPrice";
            textBoxSixMonthPrice.Size = new Size(100, 23);
            textBoxSixMonthPrice.TabIndex = 26;
            // 
            // labelsixMonthPrice
            // 
            labelsixMonthPrice.AutoSize = true;
            labelsixMonthPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelsixMonthPrice.Location = new Point(347, 171);
            labelsixMonthPrice.Name = "labelsixMonthPrice";
            labelsixMonthPrice.Size = new Size(111, 21);
            labelsixMonthPrice.TabIndex = 25;
            labelsixMonthPrice.Text = "6 Aylık Ücret:";
            // 
            // textBoxAnnualPrice
            // 
            textBoxAnnualPrice.Location = new Point(464, 209);
            textBoxAnnualPrice.Name = "textBoxAnnualPrice";
            textBoxAnnualPrice.Size = new Size(100, 23);
            textBoxAnnualPrice.TabIndex = 28;
            // 
            // labelAnnualPrice
            // 
            labelAnnualPrice.AutoSize = true;
            labelAnnualPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnnualPrice.Location = new Point(360, 211);
            labelAnnualPrice.Name = "labelAnnualPrice";
            labelAnnualPrice.Size = new Size(98, 21);
            labelAnnualPrice.TabIndex = 27;
            labelAnnualPrice.Text = "Yıllık Ücret:";
            // 
            // CarInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 444);
            Controls.Add(groupBox1);
            Name = "CarInfoForm";
            Text = "CarInfoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PrintPreviewDialog printPreviewDialog1;
        private GroupBox groupBox1;
        private TextBox textBoxPlate;
        private TextBox textBoxGear;
        private TextBox textBoxYear;
        private TextBox textBoxModel;
        private TextBox textBoxBrand;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxYes;
        private Label labelRented;
        private Label labelPlate;
        private Label labelGear;
        private Label labelYear;
        private Label labelModel;
        private Label labelBrand;
        private Label txtSeriNo;
        private Label labelSeriNo;
        private Button buttonBack;
        private Button buttonDelete;
        private Button buttonUpdate;
        private TextBox textBoxAnnualPrice;
        private Label labelAnnualPrice;
        private TextBox textBoxSixMonthPrice;
        private Label labelsixMonthPrice;
        private TextBox textBoxMonthlyPrice;
        private Label labelMonthlyPrice;
        private TextBox textBoxWeeklyPrice;
        private Label labelWeeklyPrice;
        private TextBox textBoxDailyPrice;
        private Label labelDailyPrice;
    }
}