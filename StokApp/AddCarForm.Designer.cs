namespace StokApp
{
    partial class AddCarForm
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
            textBoxPlate = new TextBox();
            textBoxGear = new TextBox();
            textBoxYear = new TextBox();
            labelPlate = new Label();
            labelGear = new Label();
            labelYear = new Label();
            buttonBack = new Button();
            checkBoxNo = new CheckBox();
            checkBoxYes = new CheckBox();
            buttonSave = new Button();
            textBoxModel = new TextBox();
            textBoxBrand = new TextBox();
            textBoxSeriNo = new TextBox();
            labelIsRented = new Label();
            labelModel = new Label();
            labelBrand = new Label();
            labelSeriNo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPlate);
            groupBox1.Controls.Add(textBoxGear);
            groupBox1.Controls.Add(textBoxYear);
            groupBox1.Controls.Add(labelPlate);
            groupBox1.Controls.Add(labelGear);
            groupBox1.Controls.Add(labelYear);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(checkBoxNo);
            groupBox1.Controls.Add(checkBoxYes);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(textBoxModel);
            groupBox1.Controls.Add(textBoxBrand);
            groupBox1.Controls.Add(textBoxSeriNo);
            groupBox1.Controls.Add(labelIsRented);
            groupBox1.Controls.Add(labelModel);
            groupBox1.Controls.Add(labelBrand);
            groupBox1.Controls.Add(labelSeriNo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 565);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxPlate
            // 
            textBoxPlate.Anchor = AnchorStyles.None;
            textBoxPlate.Location = new Point(237, 251);
            textBoxPlate.Name = "textBoxPlate";
            textBoxPlate.Size = new Size(100, 23);
            textBoxPlate.TabIndex = 35;
            // 
            // textBoxGear
            // 
            textBoxGear.Anchor = AnchorStyles.None;
            textBoxGear.Location = new Point(237, 221);
            textBoxGear.Name = "textBoxGear";
            textBoxGear.Size = new Size(100, 23);
            textBoxGear.TabIndex = 34;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.None;
            textBoxYear.Location = new Point(237, 191);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 33;
            // 
            // labelPlate
            // 
            labelPlate.Anchor = AnchorStyles.None;
            labelPlate.AutoSize = true;
            labelPlate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlate.Location = new Point(175, 251);
            labelPlate.Name = "labelPlate";
            labelPlate.Size = new Size(56, 21);
            labelPlate.TabIndex = 32;
            labelPlate.Text = "Plaka:";
            // 
            // labelGear
            // 
            labelGear.Anchor = AnchorStyles.None;
            labelGear.AutoSize = true;
            labelGear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGear.Location = new Point(179, 221);
            labelGear.Name = "labelGear";
            labelGear.Size = new Size(52, 21);
            labelGear.TabIndex = 31;
            labelGear.Text = "Vites:";
            // 
            // labelYear
            // 
            labelYear.Anchor = AnchorStyles.None;
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelYear.Location = new Point(197, 191);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(34, 21);
            labelYear.TabIndex = 30;
            labelYear.Text = "Yıl:";
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBack.Location = new Point(6, 529);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(85, 30);
            buttonBack.TabIndex = 29;
            buttonBack.Text = "Geri";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxNo
            // 
            checkBoxNo.Anchor = AnchorStyles.None;
            checkBoxNo.AutoSize = true;
            checkBoxNo.Location = new Point(283, 283);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(54, 19);
            checkBoxNo.TabIndex = 28;
            checkBoxNo.Text = "Hayır";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // checkBoxYes
            // 
            checkBoxYes.Anchor = AnchorStyles.None;
            checkBoxYes.AutoSize = true;
            checkBoxYes.Location = new Point(237, 283);
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.Size = new Size(48, 19);
            checkBoxYes.TabIndex = 27;
            checkBoxYes.Text = "Evet";
            checkBoxYes.UseVisualStyleBackColor = true;
            checkBoxYes.CheckedChanged += checkBoxYes_CheckedChanged;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(237, 321);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 31);
            buttonSave.TabIndex = 26;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.None;
            textBoxModel.Location = new Point(237, 161);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 25;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Anchor = AnchorStyles.None;
            textBoxBrand.Location = new Point(237, 131);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(100, 23);
            textBoxBrand.TabIndex = 24;
            // 
            // textBoxSeriNo
            // 
            textBoxSeriNo.Anchor = AnchorStyles.None;
            textBoxSeriNo.Location = new Point(237, 101);
            textBoxSeriNo.Name = "textBoxSeriNo";
            textBoxSeriNo.Size = new Size(100, 23);
            textBoxSeriNo.TabIndex = 23;
            // 
            // labelIsRented
            // 
            labelIsRented.Anchor = AnchorStyles.None;
            labelIsRented.AutoSize = true;
            labelIsRented.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIsRented.Location = new Point(124, 281);
            labelIsRented.Name = "labelIsRented";
            labelIsRented.Size = new Size(107, 21);
            labelIsRented.TabIndex = 22;
            labelIsRented.Text = "Kiralandı Mı:";
            // 
            // labelModel
            // 
            labelModel.Anchor = AnchorStyles.None;
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(168, 161);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(63, 21);
            labelModel.TabIndex = 21;
            labelModel.Text = "Model:";
            // 
            // labelBrand
            // 
            labelBrand.Anchor = AnchorStyles.None;
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrand.Location = new Point(169, 131);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(62, 21);
            labelBrand.TabIndex = 20;
            labelBrand.Text = "Marka:";
            // 
            // labelSeriNo
            // 
            labelSeriNo.Anchor = AnchorStyles.None;
            labelSeriNo.AutoSize = true;
            labelSeriNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeriNo.Location = new Point(161, 101);
            labelSeriNo.Name = "labelSeriNo";
            labelSeriNo.Size = new Size(70, 21);
            labelSeriNo.TabIndex = 19;
            labelSeriNo.Text = "Seri No:";
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 565);
            Controls.Add(groupBox1);
            Name = "AddCarForm";
            Text = "AddCarForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPlate;
        private TextBox textBoxGear;
        private TextBox textBoxYear;
        private Label labelPlate;
        private Label labelGear;
        private Label labelYear;
        private Button buttonBack;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxYes;
        private Button buttonSave;
        private TextBox textBoxModel;
        private TextBox textBoxBrand;
        private TextBox textBoxSeriNo;
        private Label labelIsRented;
        private Label labelModel;
        private Label labelBrand;
        private Label labelSeriNo;
    }
}