namespace StokApp
{
    partial class ListCarForm
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
            groupBox4 = new GroupBox();
            button5 = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(932, 737);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(3, 687);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(716, 47);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(3, 13);
            button5.Name = "button5";
            button5.Size = new Size(70, 28);
            button5.TabIndex = 2;
            button5.Text = "Geri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(719, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(210, 715);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(6, 172);
            button4.Name = "button4";
            button4.Size = new Size(190, 44);
            button4.TabIndex = 3;
            button4.Text = "Araç Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(6, 122);
            button3.Name = "button3";
            button3.Size = new Size(190, 44);
            button3.TabIndex = 2;
            button3.Text = "Kiralanabilir Araçları Listele";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(6, 72);
            button2.Name = "button2";
            button2.Size = new Size(190, 44);
            button2.TabIndex = 1;
            button2.Text = "Kiralanmış Araçları Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(190, 44);
            button1.TabIndex = 0;
            button1.Text = "Tüm Araçları Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(listView2);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(710, 662);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Araçlar";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView2.Dock = DockStyle.Fill;
            listView2.Location = new Point(3, 23);
            listView2.Name = "listView2";
            listView2.Size = new Size(704, 636);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.ColumnClick += listView2_ColumnClick;
            listView2.MouseDown += listView2_MouseDown;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Seri No";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Vites";
            columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Marka";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Model";
            columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Yıl";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Plaka";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Günlük Ücret";
            columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Haftalık Ücret";
            columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Aylık Ücret";
            columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Altı Aylık Ücret";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Yıllık Ücret";
            columnHeader11.Width = 110;
            // 
            // ListCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 737);
            Controls.Add(groupBox1);
            Name = "ListCarForm";
            Text = "ListCarForm";
            Load += ListCarForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private ListView listView2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private GroupBox groupBox4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}