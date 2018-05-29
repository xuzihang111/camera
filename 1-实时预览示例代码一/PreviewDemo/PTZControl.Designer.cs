namespace PreviewDemo
{
    partial class PTZControl
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnAmplification = new System.Windows.Forms.Button();
            this.btnNarrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.checkBoxPreview = new System.Windows.Forms.CheckBox();
            this.button_setport = new System.Windows.Forms.Button();
            this.button_turnto = new System.Windows.Forms.Button();
            this.button_port1 = new System.Windows.Forms.Button();
            this.button_port3 = new System.Windows.Forms.Button();
            this.button_port5 = new System.Windows.Forms.Button();
            this.button_potr7 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_port2 = new System.Windows.Forms.Button();
            this.button_port4 = new System.Windows.Forms.Button();
            this.button_port10 = new System.Windows.Forms.Button();
            this.button_port8 = new System.Windows.Forms.Button();
            this.button_port6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(21, 105);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(69, 41);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(176, 105);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(69, 41);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(99, 54);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(69, 41);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(99, 151);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(69, 41);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(99, 104);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(69, 41);
            this.btnAuto.TabIndex = 5;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnAmplification
            // 
            this.btnAmplification.Location = new System.Drawing.Point(176, 200);
            this.btnAmplification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAmplification.Name = "btnAmplification";
            this.btnAmplification.Size = new System.Drawing.Size(69, 28);
            this.btnAmplification.TabIndex = 10;
            this.btnAmplification.Text = "放大";
            this.btnAmplification.UseVisualStyleBackColor = true;
            this.btnAmplification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAmplification_MouseDown);
            this.btnAmplification.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAmplification_MouseUp);
            // 
            // btnNarrow
            // 
            this.btnNarrow.Location = new System.Drawing.Point(21, 200);
            this.btnNarrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNarrow.Name = "btnNarrow";
            this.btnNarrow.Size = new System.Drawing.Size(69, 28);
            this.btnNarrow.TabIndex = 11;
            this.btnNarrow.Text = "缩小";
            this.btnNarrow.UseVisualStyleBackColor = true;
            this.btnNarrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNarrow_MouseDown);
            this.btnNarrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnNarrow_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "缩放";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "云台速度";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(106, 276);
            this.comboBoxSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(139, 23);
            this.comboBoxSpeed.TabIndex = 1;
            this.comboBoxSpeed.TabStop = false;
            // 
            // checkBoxPreview
            // 
            this.checkBoxPreview.AutoSize = true;
            this.checkBoxPreview.Enabled = false;
            this.checkBoxPreview.Location = new System.Drawing.Point(16, 16);
            this.checkBoxPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPreview.Name = "checkBoxPreview";
            this.checkBoxPreview.Size = new System.Drawing.Size(239, 19);
            this.checkBoxPreview.TabIndex = 0;
            this.checkBoxPreview.Text = "预览是否启动 Preview or not";
            this.checkBoxPreview.UseVisualStyleBackColor = true;
            // 
            // button_setport
            // 
            this.button_setport.Location = new System.Drawing.Point(269, 72);
            this.button_setport.Name = "button_setport";
            this.button_setport.Size = new System.Drawing.Size(128, 23);
            this.button_setport.TabIndex = 12;
            this.button_setport.Text = "保存预置点";
            this.button_setport.UseVisualStyleBackColor = true;
            this.button_setport.Click += new System.EventHandler(this.button_setport_Click);
            // 
            // button_turnto
            // 
            this.button_turnto.Location = new System.Drawing.Point(269, 102);
            this.button_turnto.Name = "button_turnto";
            this.button_turnto.Size = new System.Drawing.Size(128, 23);
            this.button_turnto.TabIndex = 13;
            this.button_turnto.Text = "转到预置点";
            this.button_turnto.UseVisualStyleBackColor = true;
            this.button_turnto.Click += new System.EventHandler(this.button_turnto_Click);
            // 
            // button_port1
            // 
            this.button_port1.Location = new System.Drawing.Point(269, 162);
            this.button_port1.Name = "button_port1";
            this.button_port1.Size = new System.Drawing.Size(62, 23);
            this.button_port1.TabIndex = 15;
            this.button_port1.Text = "点1";
            this.button_port1.UseVisualStyleBackColor = true;
            this.button_port1.Click += new System.EventHandler(this.button_port1_Click);
            // 
            // button_port3
            // 
            this.button_port3.Location = new System.Drawing.Point(269, 192);
            this.button_port3.Name = "button_port3";
            this.button_port3.Size = new System.Drawing.Size(62, 23);
            this.button_port3.TabIndex = 16;
            this.button_port3.Text = "点3";
            this.button_port3.UseVisualStyleBackColor = true;
            this.button_port3.Click += new System.EventHandler(this.button_port3_Click);
            // 
            // button_port5
            // 
            this.button_port5.Location = new System.Drawing.Point(269, 223);
            this.button_port5.Name = "button_port5";
            this.button_port5.Size = new System.Drawing.Size(62, 23);
            this.button_port5.TabIndex = 17;
            this.button_port5.Text = "点5";
            this.button_port5.UseVisualStyleBackColor = true;
            this.button_port5.Click += new System.EventHandler(this.button_port5_Click);
            // 
            // button_potr7
            // 
            this.button_potr7.Location = new System.Drawing.Point(269, 252);
            this.button_potr7.Name = "button_potr7";
            this.button_potr7.Size = new System.Drawing.Size(62, 23);
            this.button_potr7.TabIndex = 18;
            this.button_potr7.Text = "点7";
            this.button_potr7.UseVisualStyleBackColor = true;
            this.button_potr7.Click += new System.EventHandler(this.button_potr7_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(269, 282);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(62, 23);
            this.button_9.TabIndex = 19;
            this.button_9.Text = "点9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 25);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "1";
            // 
            // button_port2
            // 
            this.button_port2.Location = new System.Drawing.Point(335, 161);
            this.button_port2.Name = "button_port2";
            this.button_port2.Size = new System.Drawing.Size(62, 23);
            this.button_port2.TabIndex = 21;
            this.button_port2.Text = "点2";
            this.button_port2.UseVisualStyleBackColor = true;
            this.button_port2.Click += new System.EventHandler(this.button_port2_Click);
            // 
            // button_port4
            // 
            this.button_port4.Location = new System.Drawing.Point(335, 192);
            this.button_port4.Name = "button_port4";
            this.button_port4.Size = new System.Drawing.Size(62, 23);
            this.button_port4.TabIndex = 22;
            this.button_port4.Text = "点4";
            this.button_port4.UseVisualStyleBackColor = true;
            this.button_port4.Click += new System.EventHandler(this.button_port4_Click);
            // 
            // button_port10
            // 
            this.button_port10.Location = new System.Drawing.Point(337, 282);
            this.button_port10.Name = "button_port10";
            this.button_port10.Size = new System.Drawing.Size(62, 23);
            this.button_port10.TabIndex = 25;
            this.button_port10.Text = "点10";
            this.button_port10.UseVisualStyleBackColor = true;
            this.button_port10.Click += new System.EventHandler(this.button_port10_Click);
            // 
            // button_port8
            // 
            this.button_port8.Location = new System.Drawing.Point(337, 252);
            this.button_port8.Name = "button_port8";
            this.button_port8.Size = new System.Drawing.Size(62, 23);
            this.button_port8.TabIndex = 24;
            this.button_port8.Text = "点8";
            this.button_port8.UseVisualStyleBackColor = true;
            this.button_port8.Click += new System.EventHandler(this.button_port8_Click);
            // 
            // button_port6
            // 
            this.button_port6.Location = new System.Drawing.Point(337, 223);
            this.button_port6.Name = "button_port6";
            this.button_port6.Size = new System.Drawing.Size(62, 23);
            this.button_port6.TabIndex = 23;
            this.button_port6.Text = "点6";
            this.button_port6.UseVisualStyleBackColor = true;
            this.button_port6.Click += new System.EventHandler(this.button_port6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "选择预置点";
            // 
            // PTZControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_port10);
            this.Controls.Add(this.button_port8);
            this.Controls.Add(this.button_port6);
            this.Controls.Add(this.button_port4);
            this.Controls.Add(this.button_port2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_potr7);
            this.Controls.Add(this.button_port5);
            this.Controls.Add(this.button_port3);
            this.Controls.Add(this.button_port1);
            this.Controls.Add(this.button_turnto);
            this.Controls.Add(this.button_setport);
            this.Controls.Add(this.checkBoxPreview);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnAmplification);
            this.Controls.Add(this.btnNarrow);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PTZControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PTZControl";
            this.Load += new System.EventHandler(this.PTZControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAmplification;
        private System.Windows.Forms.Button btnNarrow;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxPreview;
        private System.Windows.Forms.Button button_setport;
        private System.Windows.Forms.Button button_turnto;
        private System.Windows.Forms.Button button_port1;
        private System.Windows.Forms.Button button_port3;
        private System.Windows.Forms.Button button_port5;
        private System.Windows.Forms.Button button_potr7;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_port2;
        private System.Windows.Forms.Button button_port4;
        private System.Windows.Forms.Button button_port10;
        private System.Windows.Forms.Button button_port8;
        private System.Windows.Forms.Button button_port6;
        private System.Windows.Forms.Label label2;
    }
}