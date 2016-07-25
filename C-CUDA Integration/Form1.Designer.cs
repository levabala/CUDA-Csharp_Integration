namespace C_CUDA_Integration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinInaccuracy = new System.Windows.Forms.TextBox();
            this.MaxInaccuracy = new System.Windows.Forms.TextBox();
            this.TypeOfInaccuracy = new System.Windows.Forms.GroupBox();
            this.AverageInac = new System.Windows.Forms.RadioButton();
            this.AbsoluteInac = new System.Windows.Forms.RadioButton();
            this.CUDA_C = new System.Windows.Forms.TextBox();
            this.CSharp_CUDA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CSharp_C = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CUDAAverage = new System.Windows.Forms.TextBox();
            this.CAverage = new System.Windows.Forms.TextBox();
            this.CSharpAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CUDA = new System.Windows.Forms.ListBox();
            this.C = new System.Windows.Forms.ListBox();
            this.CSharp = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ArrayLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CalcCount = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SpendingTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.OutputValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ShowBiggestInac = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.TypeOfInaccuracy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.MinInaccuracy);
            this.panel1.Controls.Add(this.MaxInaccuracy);
            this.panel1.Controls.Add(this.TypeOfInaccuracy);
            this.panel1.Controls.Add(this.CUDA_C);
            this.panel1.Controls.Add(this.CSharp_CUDA);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CSharp_C);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CUDAAverage);
            this.panel1.Controls.Add(this.CAverage);
            this.panel1.Controls.Add(this.CSharpAverage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CUDA);
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.CSharp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ArrayLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CalcCount);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SpendingTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 656);
            this.panel1.TabIndex = 31;
            // 
            // MinInaccuracy
            // 
            this.MinInaccuracy.Location = new System.Drawing.Point(679, 593);
            this.MinInaccuracy.Name = "MinInaccuracy";
            this.MinInaccuracy.Size = new System.Drawing.Size(178, 22);
            this.MinInaccuracy.TabIndex = 63;
            // 
            // MaxInaccuracy
            // 
            this.MaxInaccuracy.Location = new System.Drawing.Point(679, 556);
            this.MaxInaccuracy.Name = "MaxInaccuracy";
            this.MaxInaccuracy.Size = new System.Drawing.Size(178, 22);
            this.MaxInaccuracy.TabIndex = 61;
            this.MaxInaccuracy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TypeOfInaccuracy
            // 
            this.TypeOfInaccuracy.BackColor = System.Drawing.Color.Khaki;
            this.TypeOfInaccuracy.Controls.Add(this.AverageInac);
            this.TypeOfInaccuracy.Controls.Add(this.AbsoluteInac);
            this.TypeOfInaccuracy.Location = new System.Drawing.Point(683, 407);
            this.TypeOfInaccuracy.Name = "TypeOfInaccuracy";
            this.TypeOfInaccuracy.Size = new System.Drawing.Size(178, 138);
            this.TypeOfInaccuracy.TabIndex = 60;
            this.TypeOfInaccuracy.TabStop = false;
            this.TypeOfInaccuracy.Text = "Inaccuracy type";
            // 
            // AverageInac
            // 
            this.AverageInac.AutoSize = true;
            this.AverageInac.Location = new System.Drawing.Point(9, 89);
            this.AverageInac.Name = "AverageInac";
            this.AverageInac.Size = new System.Drawing.Size(156, 21);
            this.AverageInac.TabIndex = 1;
            this.AverageInac.Text = "Absolute Inaccuracy";
            this.AverageInac.UseVisualStyleBackColor = true;
            // 
            // AbsoluteInac
            // 
            this.AbsoluteInac.AutoSize = true;
            this.AbsoluteInac.Checked = true;
            this.AbsoluteInac.Location = new System.Drawing.Point(9, 46);
            this.AbsoluteInac.Name = "AbsoluteInac";
            this.AbsoluteInac.Size = new System.Drawing.Size(154, 21);
            this.AbsoluteInac.TabIndex = 0;
            this.AbsoluteInac.TabStop = true;
            this.AbsoluteInac.Text = "Average Inaccuracy";
            this.AbsoluteInac.UseVisualStyleBackColor = true;
            // 
            // CUDA_C
            // 
            this.CUDA_C.Location = new System.Drawing.Point(511, 407);
            this.CUDA_C.Multiline = true;
            this.CUDA_C.Name = "CUDA_C";
            this.CUDA_C.Size = new System.Drawing.Size(165, 138);
            this.CUDA_C.TabIndex = 59;
            // 
            // CSharp_CUDA
            // 
            this.CSharp_CUDA.Location = new System.Drawing.Point(340, 407);
            this.CSharp_CUDA.Multiline = true;
            this.CSharp_CUDA.Name = "CSharp_CUDA";
            this.CSharp_CUDA.Size = new System.Drawing.Size(165, 138);
            this.CSharp_CUDA.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "CUDA-C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "CSharp-CUDA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "CSharp-C";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 551);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 32);
            this.button3.TabIndex = 54;
            this.button3.Text = "Inaccuracy test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Inaccuracy box";
            // 
            // CSharp_C
            // 
            this.CSharp_C.Location = new System.Drawing.Point(169, 407);
            this.CSharp_C.Multiline = true;
            this.CSharp_C.Name = "CSharp_C";
            this.CSharp_C.Size = new System.Drawing.Size(165, 138);
            this.CSharp_C.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(762, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Average";
            // 
            // CUDAAverage
            // 
            this.CUDAAverage.Location = new System.Drawing.Point(646, 301);
            this.CUDAAverage.Name = "CUDAAverage";
            this.CUDAAverage.Size = new System.Drawing.Size(99, 22);
            this.CUDAAverage.TabIndex = 50;
            this.CUDAAverage.Text = "NaN";
            // 
            // CAverage
            // 
            this.CAverage.Location = new System.Drawing.Point(463, 301);
            this.CAverage.Name = "CAverage";
            this.CAverage.Size = new System.Drawing.Size(99, 22);
            this.CAverage.TabIndex = 49;
            this.CAverage.Text = "NaN";
            // 
            // CSharpAverage
            // 
            this.CSharpAverage.Location = new System.Drawing.Point(280, 300);
            this.CSharpAverage.Name = "CSharpAverage";
            this.CSharpAverage.Size = new System.Drawing.Size(99, 22);
            this.CSharpAverage.TabIndex = 48;
            this.CSharpAverage.Text = "NaN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "CUDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "CSharp";
            // 
            // CUDA
            // 
            this.CUDA.FormattingEnabled = true;
            this.CUDA.ItemHeight = 16;
            this.CUDA.Location = new System.Drawing.Point(646, 83);
            this.CUDA.Name = "CUDA";
            this.CUDA.Size = new System.Drawing.Size(177, 212);
            this.CUDA.TabIndex = 44;
            // 
            // C
            // 
            this.C.FormattingEnabled = true;
            this.C.ItemHeight = 16;
            this.C.Location = new System.Drawing.Point(463, 83);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(177, 212);
            this.C.TabIndex = 43;
            // 
            // CSharp
            // 
            this.CSharp.FormattingEnabled = true;
            this.CSharp.ItemHeight = 16;
            this.CSharp.Location = new System.Drawing.Point(280, 83);
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(177, 212);
            this.CSharp.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Array length:";
            // 
            // ArrayLength
            // 
            this.ArrayLength.Location = new System.Drawing.Point(159, 231);
            this.ArrayLength.Name = "ArrayLength";
            this.ArrayLength.Size = new System.Drawing.Size(114, 22);
            this.ArrayLength.TabIndex = 40;
            this.ArrayLength.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Calc count:";
            // 
            // CalcCount
            // 
            this.CalcCount.Location = new System.Drawing.Point(159, 259);
            this.CalcCount.Name = "CalcCount";
            this.CalcCount.Size = new System.Drawing.Size(114, 22);
            this.CalcCount.TabIndex = 38;
            this.CalcCount.Text = "10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 35);
            this.button2.TabIndex = 37;
            this.button2.Text = "Start test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpendingTime
            // 
            this.SpendingTime.Location = new System.Drawing.Point(159, 135);
            this.SpendingTime.Name = "SpendingTime";
            this.SpendingTime.ReadOnly = true;
            this.SpendingTime.Size = new System.Drawing.Size(115, 22);
            this.SpendingTime.TabIndex = 34;
            this.SpendingTime.TabStop = false;
            this.SpendingTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Timing:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Output value:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.OutputValue);
            this.groupBox2.Location = new System.Drawing.Point(19, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 343);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time spending calculation";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(43, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 51);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choosing type of calculation";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(138, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CUDA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "C#";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // OutputValue
            // 
            this.OutputValue.Location = new System.Drawing.Point(139, 85);
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.ReadOnly = true;
            this.OutputValue.Size = new System.Drawing.Size(115, 22);
            this.OutputValue.TabIndex = 31;
            this.OutputValue.TabStop = false;
            this.OutputValue.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.ShowBiggestInac);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(21, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 270);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inaccuracy detection";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(547, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 17);
            this.label14.TabIndex = 64;
            this.label14.Text = "Min inaccuracy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(547, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 62;
            this.label13.Text = "Max inaccuracy";
            // 
            // ShowBiggestInac
            // 
            this.ShowBiggestInac.AutoSize = true;
            this.ShowBiggestInac.Enabled = false;
            this.ShowBiggestInac.Location = new System.Drawing.Point(21, 228);
            this.ShowBiggestInac.Name = "ShowBiggestInac";
            this.ShowBiggestInac.Size = new System.Drawing.Size(225, 21);
            this.ShowBiggestInac.TabIndex = 65;
            this.ShowBiggestInac.Text = "Show the biggest inaccuracies ";
            this.ShowBiggestInac.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Items.AddRange(new object[] {
            "30% from MAX",
            "40% from MAX",
            "50% from MAX"});
            this.comboBox1.Location = new System.Drawing.Point(21, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "C - CUDA Integration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TypeOfInaccuracy.ResumeLayout(false);
            this.TypeOfInaccuracy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CSharp_C;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CUDAAverage;
        private System.Windows.Forms.TextBox CAverage;
        private System.Windows.Forms.TextBox CSharpAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CUDA;
        private System.Windows.Forms.ListBox C;
        private System.Windows.Forms.ListBox CSharp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ArrayLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CalcCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox SpendingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CUDA_C;
        private System.Windows.Forms.TextBox CSharp_CUDA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox TypeOfInaccuracy;
        private System.Windows.Forms.RadioButton AverageInac;
        private System.Windows.Forms.RadioButton AbsoluteInac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MaxInaccuracy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MinInaccuracy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ShowBiggestInac;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

