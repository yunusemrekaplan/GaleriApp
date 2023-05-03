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
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(797, 592);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(462, 432);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(98, 41);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(346, 432);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(110, 41);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(7, 543);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(98, 41);
            buttonBack.TabIndex = 18;
            buttonBack.Text = "Geri";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxPlate
            // 
            textBoxPlate.Anchor = AnchorStyles.None;
            textBoxPlate.Location = new Point(346, 340);
            textBoxPlate.Margin = new Padding(3, 4, 3, 4);
            textBoxPlate.Name = "textBoxPlate";
            textBoxPlate.Size = new Size(114, 27);
            textBoxPlate.TabIndex = 14;
            // 
            // textBoxGear
            // 
            textBoxGear.Anchor = AnchorStyles.None;
            textBoxGear.Location = new Point(346, 287);
            textBoxGear.Margin = new Padding(3, 4, 3, 4);
            textBoxGear.Name = "textBoxGear";
            textBoxGear.Size = new Size(114, 27);
            textBoxGear.TabIndex = 13;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.None;
            textBoxYear.Location = new Point(346, 233);
            textBoxYear.Margin = new Padding(3, 4, 3, 4);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(114, 27);
            textBoxYear.TabIndex = 12;
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.None;
            textBoxModel.Location = new Point(346, 180);
            textBoxModel.Margin = new Padding(3, 4, 3, 4);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(114, 27);
            textBoxModel.TabIndex = 11;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Anchor = AnchorStyles.None;
            textBoxBrand.Location = new Point(346, 127);
            textBoxBrand.Margin = new Padding(3, 4, 3, 4);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(114, 27);
            textBoxBrand.TabIndex = 10;
            // 
            // checkBoxNo
            // 
            checkBoxNo.Anchor = AnchorStyles.None;
            checkBoxNo.AutoSize = true;
            checkBoxNo.Location = new Point(408, 399);
            checkBoxNo.Margin = new Padding(3, 4, 3, 4);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(66, 24);
            checkBoxNo.TabIndex = 9;
            checkBoxNo.Text = "Hayır";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // checkBoxYes
            // 
            checkBoxYes.Anchor = AnchorStyles.None;
            checkBoxYes.AutoSize = true;
            checkBoxYes.Location = new Point(346, 399);
            checkBoxYes.Margin = new Padding(3, 4, 3, 4);
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.Size = new Size(59, 24);
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
            labelRented.Location = new Point(217, 396);
            labelRented.Name = "labelRented";
            labelRented.Size = new Size(132, 28);
            labelRented.TabIndex = 7;
            labelRented.Text = "Kiralandı mı:";
            // 
            // labelPlate
            // 
            labelPlate.Anchor = AnchorStyles.None;
            labelPlate.AutoSize = true;
            labelPlate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlate.Location = new Point(275, 343);
            labelPlate.Name = "labelPlate";
            labelPlate.Size = new Size(68, 28);
            labelPlate.TabIndex = 6;
            labelPlate.Text = "Plaka:";
            // 
            // labelGear
            // 
            labelGear.Anchor = AnchorStyles.None;
            labelGear.AutoSize = true;
            labelGear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGear.Location = new Point(280, 289);
            labelGear.Name = "labelGear";
            labelGear.Size = new Size(64, 28);
            labelGear.TabIndex = 5;
            labelGear.Text = "Vites:";
            // 
            // labelYear
            // 
            labelYear.Anchor = AnchorStyles.None;
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(301, 236);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(41, 28);
            labelYear.TabIndex = 4;
            labelYear.Text = "Yıl:";
            // 
            // labelModel
            // 
            labelModel.Anchor = AnchorStyles.None;
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(267, 183);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(77, 28);
            labelModel.TabIndex = 3;
            labelModel.Text = "Model:";
            // 
            // labelBrand
            // 
            labelBrand.Anchor = AnchorStyles.None;
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrand.Location = new Point(269, 129);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(77, 28);
            labelBrand.TabIndex = 2;
            labelBrand.Text = "Marka:";
            // 
            // txtSeriNo
            // 
            txtSeriNo.Anchor = AnchorStyles.None;
            txtSeriNo.AutoSize = true;
            txtSeriNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSeriNo.Location = new Point(346, 76);
            txtSeriNo.Name = "txtSeriNo";
            txtSeriNo.Size = new Size(0, 28);
            txtSeriNo.TabIndex = 1;
            // 
            // labelSeriNo
            // 
            labelSeriNo.Anchor = AnchorStyles.None;
            labelSeriNo.AutoSize = true;
            labelSeriNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeriNo.Location = new Point(259, 76);
            labelSeriNo.Name = "labelSeriNo";
            labelSeriNo.Size = new Size(87, 28);
            labelSeriNo.TabIndex = 0;
            labelSeriNo.Text = "Seri No:";
            // 
            // CarInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 592);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}