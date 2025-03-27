namespace Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPenType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.numDoday = new System.Windows.Forms.NumericUpDown();
            this.btnDaGiac = new System.Windows.Forms.Button();
            this.btnDuongCong = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoday)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.Window;
            this.plMain.Location = new System.Drawing.Point(5, 180);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1259, 493);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnFillColor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbPenType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnSquare);
            this.panel2.Controls.Add(this.btnRec);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Controls.Add(this.numDoday);
            this.panel2.Controls.Add(this.btnDaGiac);
            this.panel2.Controls.Add(this.btnDuongCong);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.btnEllipse);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 182);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pen";
            // 
            // cmbPenType
            // 
            this.cmbPenType.FormattingEnabled = true;
            this.cmbPenType.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cmbPenType.Location = new System.Drawing.Point(503, 26);
            this.cmbPenType.Name = "cmbPenType";
            this.cmbPenType.Size = new System.Drawing.Size(128, 28);
            this.cmbPenType.TabIndex = 16;
            this.cmbPenType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(438, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 164);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(287, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 164);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shapes";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(91, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 41);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSquare.BackgroundImage")));
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSquare.Location = new System.Drawing.Point(25, 88);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(45, 41);
            this.btnSquare.TabIndex = 11;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click_1);
            // 
            // btnRec
            // 
            this.btnRec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRec.BackgroundImage")));
            this.btnRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRec.Location = new System.Drawing.Point(91, 26);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(45, 41);
            this.btnRec.TabIndex = 10;
            this.btnRec.UseVisualStyleBackColor = false;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click_1);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.Location = new System.Drawing.Point(25, 26);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(45, 41);
            this.btnLine.TabIndex = 9;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click_1);
            // 
            // numDoday
            // 
            this.numDoday.Location = new System.Drawing.Point(503, 88);
            this.numDoday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDoday.Name = "numDoday";
            this.numDoday.Size = new System.Drawing.Size(52, 26);
            this.numDoday.TabIndex = 8;
            this.numDoday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDoday.ValueChanged += new System.EventHandler(this.numDoday_ValueChanged);
            // 
            // btnDaGiac
            // 
            this.btnDaGiac.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDaGiac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDaGiac.BackgroundImage")));
            this.btnDaGiac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDaGiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaGiac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDaGiac.Location = new System.Drawing.Point(154, 88);
            this.btnDaGiac.Name = "btnDaGiac";
            this.btnDaGiac.Size = new System.Drawing.Size(50, 45);
            this.btnDaGiac.TabIndex = 7;
            this.btnDaGiac.UseVisualStyleBackColor = false;
            this.btnDaGiac.Click += new System.EventHandler(this.btnDaGiac_Click);
            // 
            // btnDuongCong
            // 
            this.btnDuongCong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDuongCong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDuongCong.BackgroundImage")));
            this.btnDuongCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDuongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuongCong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDuongCong.Location = new System.Drawing.Point(222, 26);
            this.btnDuongCong.Name = "btnDuongCong";
            this.btnDuongCong.Size = new System.Drawing.Size(46, 41);
            this.btnDuongCong.TabIndex = 6;
            this.btnDuongCong.UseVisualStyleBackColor = false;
            this.btnDuongCong.Click += new System.EventHandler(this.btnDuongCong_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(335, 52);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(56, 51);
            this.btnColor.TabIndex = 2;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.BackgroundImage")));
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEllipse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEllipse.Location = new System.Drawing.Point(154, 26);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(50, 41);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(648, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 164);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(694, 35);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(47, 32);
            this.btnFillColor.TabIndex = 21;
            this.btnFillColor.Text = "Fill";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnDaGiac;
        private System.Windows.Forms.Button btnDuongCong;
        private System.Windows.Forms.NumericUpDown numDoday;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPenType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label label8;
    }
}

