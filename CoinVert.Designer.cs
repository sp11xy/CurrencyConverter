namespace CurrencyConverter
{
    partial class CoinVert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinVert));
            inputTxtBox = new TextBox();
            convertTxtBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            rBtnWon = new RadioButton();
            rBtnYen = new RadioButton();
            rBtnYuan = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            waitTxt = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // inputTxtBox
            // 
            inputTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTxtBox.Location = new Point(44, 213);
            inputTxtBox.Name = "inputTxtBox";
            inputTxtBox.Size = new Size(325, 43);
            inputTxtBox.TabIndex = 0;
            // 
            // convertTxtBox
            // 
            convertTxtBox.BackColor = SystemColors.Window;
            convertTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertTxtBox.Location = new Point(44, 385);
            convertTxtBox.Name = "convertTxtBox";
            convertTxtBox.ReadOnly = true;
            convertTxtBox.Size = new Size(316, 43);
            convertTxtBox.TabIndex = 1;
            convertTxtBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 171);
            label1.Name = "label1";
            label1.Size = new Size(429, 30);
            label1.TabIndex = 2;
            label1.Text = "Type the amount in € you want to convert";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(446, 371);
            button1.Name = "button1";
            button1.Size = new Size(158, 57);
            button1.TabIndex = 3;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Convert_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(610, 371);
            button2.Name = "button2";
            button2.Size = new Size(158, 57);
            button2.TabIndex = 4;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Reset_Click;
            // 
            // rBtnWon
            // 
            rBtnWon.AutoSize = true;
            rBtnWon.Checked = true;
            rBtnWon.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnWon.Location = new Point(44, 262);
            rBtnWon.Name = "rBtnWon";
            rBtnWon.Size = new Size(170, 41);
            rBtnWon.TabIndex = 5;
            rBtnWon.TabStop = true;
            rBtnWon.Text = "Won (KRW)";
            rBtnWon.UseVisualStyleBackColor = true;
            rBtnWon.CheckedChanged += RbtnWon_CheckedChanged;
            // 
            // rBtnYen
            // 
            rBtnYen.AutoSize = true;
            rBtnYen.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnYen.Location = new Point(220, 262);
            rBtnYen.Name = "rBtnYen";
            rBtnYen.Size = new Size(140, 41);
            rBtnYen.TabIndex = 6;
            rBtnYen.TabStop = true;
            rBtnYen.Text = "Yen (JPY)";
            rBtnYen.UseVisualStyleBackColor = true;
            rBtnYen.CheckedChanged += RbtnYen_CheckedChanged;
            // 
            // rBtnYuan
            // 
            rBtnYuan.AutoSize = true;
            rBtnYuan.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnYuan.Location = new Point(378, 262);
            rBtnYuan.Name = "rBtnYuan";
            rBtnYuan.Size = new Size(169, 41);
            rBtnYuan.TabIndex = 7;
            rBtnYuan.TabStop = true;
            rBtnYuan.Text = "Yuan (CNY)";
            rBtnYuan.UseVisualStyleBackColor = true;
            rBtnYuan.CheckedChanged += rBtnYuan_CheckedChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(375, 218);
            label2.Name = "label2";
            label2.Size = new Size(34, 33);
            label2.TabIndex = 8;
            label2.Text = "€";
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(44, 295);
            label3.Name = "label3";
            label3.Size = new Size(49, 87);
            label3.TabIndex = 9;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(375, -216);
            label4.Name = "label4";
            label4.Size = new Size(778, 978);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("ROG Fonts", 47.9999924F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 9);
            label5.Name = "label5";
            label5.Size = new Size(460, 77);
            label5.TabIndex = 11;
            label5.Text = "Coinvert";
            // 
            // waitTxt
            // 
            waitTxt.AutoSize = true;
            waitTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            waitTxt.Location = new Point(44, 431);
            waitTxt.Name = "waitTxt";
            waitTxt.Size = new Size(0, 30);
            waitTxt.TabIndex = 12;
            // 
            // label6
            // 
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(32, -1);
            label6.Name = "label6";
            label6.Size = new Size(197, 172);
            label6.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(260, 311);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 43);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(128, 311);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(126, 41);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Custom";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // CoinVert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 473);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(waitTxt);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rBtnYuan);
            Controls.Add(rBtnYen);
            Controls.Add(rBtnWon);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(convertTxtBox);
            Controls.Add(inputTxtBox);
            Controls.Add(label4);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CoinVert";
            Text = "CoinVert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTxtBox;
        private TextBox convertTxtBox;
        private Label label1;
        private Button button1;
        private Button button2;
        private RadioButton rBtnWon;
        private RadioButton rBtnYen;
        private RadioButton rBtnYuan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label waitTxt;
        private Label label6;
        private TextBox textBox1;
        private RadioButton radioButton1;
    }
}
