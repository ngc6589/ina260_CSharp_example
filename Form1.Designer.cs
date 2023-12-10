namespace ina260
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            listBox2 = new ListBox();
            buttonStart = new Button();
            buttonStop = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBoxVolt = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            textBoxCurrent = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            textBoxPower = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            formsPlot1 = new ScottPlot.FormsPlot();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxVMAX = new TextBox();
            textBoxVMIN = new TextBox();
            textBoxIMAX = new TextBox();
            textBoxIMIN = new TextBox();
            groupBox4 = new GroupBox();
            textBoxMemo = new TextBox();
            label11 = new Label();
            textBoxMAH = new TextBox();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(12, 32);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(300, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "FTDI ADAPTER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "I2C ADDRESS";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 18;
            listBox2.Location = new Point(327, 32);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(100, 94);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonStart.Location = new Point(437, 32);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(64, 40);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buttonStop.Location = new Point(437, 86);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(64, 40);
            buttonStop.TabIndex = 7;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxVolt);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 60);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Voltage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 25);
            label4.Name = "label4";
            label4.Size = new Size(20, 22);
            label4.TabIndex = 1;
            label4.Text = "V";
            // 
            // textBoxVolt
            // 
            textBoxVolt.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVolt.Location = new Point(6, 22);
            textBoxVolt.Name = "textBoxVolt";
            textBoxVolt.ReadOnly = true;
            textBoxVolt.Size = new Size(100, 30);
            textBoxVolt.TabIndex = 0;
            textBoxVolt.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxCurrent);
            groupBox2.Location = new Point(158, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 60);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 25);
            label5.Name = "label5";
            label5.Size = new Size(30, 22);
            label5.TabIndex = 1;
            label5.Text = "mA";
            // 
            // textBoxCurrent
            // 
            textBoxCurrent.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCurrent.Location = new Point(6, 22);
            textBoxCurrent.Name = "textBoxCurrent";
            textBoxCurrent.ReadOnly = true;
            textBoxCurrent.Size = new Size(100, 30);
            textBoxCurrent.TabIndex = 0;
            textBoxCurrent.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxPower);
            groupBox3.Location = new Point(306, 140);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(140, 60);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Power";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(112, 25);
            label6.Name = "label6";
            label6.Size = new Size(20, 22);
            label6.TabIndex = 1;
            label6.Text = "W";
            // 
            // textBoxPower
            // 
            textBoxPower.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPower.Location = new Point(6, 22);
            textBoxPower.Name = "textBoxPower";
            textBoxPower.ReadOnly = true;
            textBoxPower.Size = new Size(100, 30);
            textBoxPower.TabIndex = 0;
            textBoxPower.TextAlign = HorizontalAlignment.Right;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.Location = new Point(12, 247);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(600, 342);
            formsPlot1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(513, 35);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 12;
            label7.Text = "VMAX";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(516, 64);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 13;
            label8.Text = "VMIN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(517, 93);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 14;
            label9.Text = "IMAX";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(520, 122);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 15;
            label10.Text = "IMIN";
            // 
            // textBoxVMAX
            // 
            textBoxVMAX.Location = new Point(559, 32);
            textBoxVMAX.Name = "textBoxVMAX";
            textBoxVMAX.Size = new Size(47, 23);
            textBoxVMAX.TabIndex = 16;
            textBoxVMAX.Text = "10";
            textBoxVMAX.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVMIN
            // 
            textBoxVMIN.Location = new Point(559, 61);
            textBoxVMIN.Name = "textBoxVMIN";
            textBoxVMIN.Size = new Size(47, 23);
            textBoxVMIN.TabIndex = 17;
            textBoxVMIN.Text = "0";
            textBoxVMIN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIMAX
            // 
            textBoxIMAX.Location = new Point(559, 90);
            textBoxIMAX.Name = "textBoxIMAX";
            textBoxIMAX.Size = new Size(47, 23);
            textBoxIMAX.TabIndex = 18;
            textBoxIMAX.Text = "500";
            textBoxIMAX.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxIMIN
            // 
            textBoxIMIN.Location = new Point(559, 119);
            textBoxIMIN.Name = "textBoxIMIN";
            textBoxIMIN.Size = new Size(47, 23);
            textBoxIMIN.TabIndex = 19;
            textBoxIMIN.Text = "0";
            textBoxIMIN.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textBoxMemo);
            groupBox4.Location = new Point(12, 199);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(594, 47);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "メモ";
            // 
            // textBoxMemo
            // 
            textBoxMemo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMemo.Location = new Point(54, 18);
            textBoxMemo.Name = "textBoxMemo";
            textBoxMemo.Size = new Size(522, 23);
            textBoxMemo.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(112, 25);
            label11.Name = "label11";
            label11.Size = new Size(40, 22);
            label11.TabIndex = 1;
            label11.Text = "mAh";
            // 
            // textBoxMAH
            // 
            textBoxMAH.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMAH.Location = new Point(6, 22);
            textBoxMAH.Name = "textBoxMAH";
            textBoxMAH.ReadOnly = true;
            textBoxMAH.Size = new Size(100, 30);
            textBoxMAH.TabIndex = 0;
            textBoxMAH.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(textBoxMAH);
            groupBox5.Location = new Point(452, 140);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(154, 60);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Capacity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 601);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(textBoxIMIN);
            Controls.Add(textBoxIMAX);
            Controls.Add(textBoxVMIN);
            Controls.Add(textBoxVMAX);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(formsPlot1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "INA260";
            Load += Form1_Load;
            Shown += Form1_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Label label2;
        private Label label1;
        private ListBox listBox2;
        private Button buttonStart;
        private Button buttonStop;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBoxVolt;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox textBoxCurrent;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox textBoxPower;
        private System.Windows.Forms.Timer timer1;
        private ScottPlot.FormsPlot formsPlot1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxVMAX;
        private TextBox textBoxVMIN;
        private TextBox textBoxIMAX;
        private TextBox textBoxIMIN;
        private GroupBox groupBox4;
        private TextBox textBoxMemo;
        private Label label11;
        private TextBox textBoxMAH;
        private GroupBox groupBox5;
    }
}
