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
            label4 = new Label();
            label5 = new Label();
            waitTxt = new Label();
            customTxtBox = new TextBox();
            rBtnCustom = new RadioButton();
            label7 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // inputTxtBox
            // 
            inputTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTxtBox.Location = new Point(44, 158);
            inputTxtBox.Name = "inputTxtBox";
            inputTxtBox.Size = new Size(325, 43);
            inputTxtBox.TabIndex = 0;
            // 
            // convertTxtBox
            // 
            convertTxtBox.BackColor = SystemColors.Window;
            convertTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertTxtBox.Location = new Point(41, 404);
            convertTxtBox.Name = "convertTxtBox";
            convertTxtBox.ReadOnly = true;
            convertTxtBox.Size = new Size(316, 43);
            convertTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 116);
            label1.Name = "label1";
            label1.Size = new Size(503, 32);
            label1.TabIndex = 2;
            label1.Text = "Type the amount in € you want to convert:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(466, 404);
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
            button2.Location = new Point(630, 404);
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
            rBtnWon.Location = new Point(41, 199);
            rBtnWon.Name = "rBtnWon";
            rBtnWon.Size = new Size(170, 41);
            rBtnWon.TabIndex = 5;
            rBtnWon.TabStop = true;
            rBtnWon.Text = "Won (KRW)";
            rBtnWon.UseVisualStyleBackColor = true;
            // 
            // rBtnYen
            // 
            rBtnYen.AutoSize = true;
            rBtnYen.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnYen.Location = new Point(217, 199);
            rBtnYen.Name = "rBtnYen";
            rBtnYen.Size = new Size(140, 41);
            rBtnYen.TabIndex = 6;
            rBtnYen.TabStop = true;
            rBtnYen.Text = "Yen (JPY)";
            rBtnYen.UseVisualStyleBackColor = true;
            // 
            // rBtnYuan
            // 
            rBtnYuan.AutoSize = true;
            rBtnYuan.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnYuan.Location = new Point(375, 199);
            rBtnYuan.Name = "rBtnYuan";
            rBtnYuan.Size = new Size(169, 41);
            rBtnYuan.TabIndex = 7;
            rBtnYuan.TabStop = true;
            rBtnYuan.Text = "Yuan (CNY)";
            rBtnYuan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 157);
            label2.Name = "label2";
            label2.Size = new Size(34, 48);
            label2.TabIndex = 8;
            label2.Text = "€";
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
            label5.Location = new Point(41, 25);
            label5.Name = "label5";
            label5.Size = new Size(460, 77);
            label5.TabIndex = 11;
            label5.Text = "Coinvert";
            // 
            // waitTxt
            // 
            waitTxt.AutoSize = true;
            waitTxt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            waitTxt.Location = new Point(41, 450);
            waitTxt.Name = "waitTxt";
            waitTxt.Size = new Size(0, 30);
            waitTxt.TabIndex = 12;
            // 
            // customTxtBox
            // 
            customTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTxtBox.Location = new Point(168, 253);
            customTxtBox.Name = "customTxtBox";
            customTxtBox.Size = new Size(81, 43);
            customTxtBox.TabIndex = 14;
            customTxtBox.Text = "USD";
            customTxtBox.TextAlign = HorizontalAlignment.Center;
            customTxtBox.TextChanged += CustomTxtBox_TextChanged;
            // 
            // rBtnCustom
            // 
            rBtnCustom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rBtnCustom.Location = new Point(44, 253);
            rBtnCustom.Name = "rBtnCustom";
            rBtnCustom.Size = new Size(159, 41);
            rBtnCustom.TabIndex = 15;
            rBtnCustom.Text = "Custom:";
            rBtnCustom.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 297);
            label7.Name = "label7";
            label7.Size = new Size(268, 30);
            label7.TabIndex = 16;
            label7.Text = "162 Currencies supported!";
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(255, 253);
            label3.Name = "label3";
            label3.Size = new Size(38, 44);
            label3.TabIndex = 17;
            label3.Click += label3_Click_1;
            // 
            // CoinVert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 483);
            Controls.Add(label3);
            Controls.Add(waitTxt);
            Controls.Add(label2);
            Controls.Add(convertTxtBox);
            Controls.Add(inputTxtBox);
            Controls.Add(customTxtBox);
            Controls.Add(label7);
            Controls.Add(rBtnCustom);
            Controls.Add(label5);
            Controls.Add(rBtnYuan);
            Controls.Add(rBtnYen);
            Controls.Add(rBtnWon);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label4;
        private Label label5;
        private Label waitTxt;
        private TextBox customTxtBox;
        private RadioButton rBtnCustom;
        private Label label7;
        private Label label3;
    }
}
