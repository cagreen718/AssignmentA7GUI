namespace A7GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            txtAverage = new TextBox();
            txtElectric = new TextBox();
            txtMost = new TextBox();
            button1 = new Button();
            txtMonthDialog = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 266);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(576, 38);
            label1.Name = "label1";
            label1.Size = new Size(379, 96);
            label1.TabIndex = 1;
            label1.Text = "          Smart Home \r\n          Electric Savings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(592, 361);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtAverage
            // 
            txtAverage.BackColor = Color.NavajoWhite;
            txtAverage.Location = new Point(285, 670);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(577, 31);
            txtAverage.TabIndex = 3;
            txtAverage.TextChanged += txtAverage_TextChanged;
            // 
            // txtElectric
            // 
            txtElectric.BackColor = Color.NavajoWhite;
            txtElectric.Location = new Point(285, 513);
            txtElectric.Name = "txtElectric";
            txtElectric.Size = new Size(577, 31);
            txtElectric.TabIndex = 4;
            txtElectric.TextChanged += txtElectric_TextChanged;
            // 
            // txtMost
            // 
            txtMost.BackColor = Color.NavajoWhite;
            txtMost.Location = new Point(285, 769);
            txtMost.Name = "txtMost";
            txtMost.Size = new Size(577, 31);
            txtMost.TabIndex = 5;
            txtMost.TextChanged += txtMost_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(444, 587);
            button1.Name = "button1";
            button1.Size = new Size(188, 41);
            button1.TabIndex = 6;
            button1.Text = "Display Statistics";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtMonthDialog
            // 
            txtMonthDialog.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1128, 870);
            Controls.Add(button1);
            Controls.Add(txtMost);
            Controls.Add(txtElectric);
            Controls.Add(txtAverage);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox txtAverage;
        private TextBox txtElectric;
        private TextBox txtMost;
        private Button button1;
        private OpenFileDialog txtMonthDialog;
        private OpenFileDialog openFileDialog1;
    }
}
