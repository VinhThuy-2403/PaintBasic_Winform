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
            this.btnColor2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBrushType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoday)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.Window;
            this.plMain.Location = new System.Drawing.Point(5, 180);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1259, 503);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(717, 62);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(48, 45);
            this.btnColor2.TabIndex = 29;
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnColor2);
            this.panel2.Controls.Add(this.btnUnGroup);
            this.panel2.Controls.Add(this.btnGroup);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbBrushType);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(656, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Color";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnGroup.Location = new System.Drawing.Point(885, 63);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(121, 40);
            this.btnUnGroup.TabIndex = 28;
            this.btnUnGroup.Text = "UnGroup";
            this.btnUnGroup.UseVisualStyleBackColor = true;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(885, 9);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(121, 40);
            this.btnGroup.TabIndex = 27;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(885, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(656, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(503, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 49);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBrushType
            // 
            this.cbBrushType.FormattingEnabled = true;
            this.cbBrushType.Items.AddRange(new object[] {
            "Solid",
            "Hatch",
            "Gradient"});
            this.cbBrushType.Location = new System.Drawing.Point(717, 115);
            this.cbBrushType.Name = "cbBrushType";
            this.cbBrushType.Size = new System.Drawing.Size(132, 28);
            this.cbBrushType.TabIndex = 24;
            this.cbBrushType.SelectedIndexChanged += new System.EventHandler(this.cbBrushType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(855, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 164);
            this.label9.TabIndex = 23;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(719, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Brush";
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFillColor.BackgroundImage")));
            this.btnFillColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFillColor.Location = new System.Drawing.Point(717, 6);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(48, 50);
            this.btnFillColor.TabIndex = 21;
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 149);
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
            this.cmbPenType.Location = new System.Drawing.Point(503, 64);
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
            this.label3.Location = new System.Drawing.Point(330, 149);
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
            this.label1.Location = new System.Drawing.Point(86, 149);
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
            this.numDoday.Location = new System.Drawing.Point(503, 107);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "Paint";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBrushType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Label label12;
    }
}

