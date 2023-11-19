namespace Task_1
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
            label1 = new Label();
            PasswordLengthNumericUpDown = new NumericUpDown();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            label5 = new Label();
            GenerateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Длина:";
            // 
            // PasswordLengthNumericUpDown
            // 
            PasswordLengthNumericUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLengthNumericUpDown.Location = new Point(12, 48);
            PasswordLengthNumericUpDown.Name = "PasswordLengthNumericUpDown";
            PasswordLengthNumericUpDown.Size = new Size(309, 30);
            PasswordLengthNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(374, 9);
            label2.Name = "label2";
            label2.Size = new Size(277, 25);
            label2.TabIndex = 2;
            label2.Text = "Нажмите чтобы скопировать:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(374, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(409, 384);
            listBox1.TabIndex = 3;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 4;
            label3.Text = "4 - 32 символа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(255, 25);
            label4.TabIndex = 5;
            label4.Text = "Генерировать из символов:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 31);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(12, 265);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(84, 26);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Цифры";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(12, 295);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(160, 26);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Маленькие буквы";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(12, 325);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(158, 26);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Заглавные буквы";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(12, 355);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(200, 26);
            checkBox5.TabIndex = 11;
            checkBox5.Text = "Специальные символы";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox6.Location = new Point(12, 385);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(245, 26);
            checkBox6.TabIndex = 12;
            checkBox6.Text = "Исключать похожие символы";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(255, 25);
            label5.TabIndex = 13;
            label5.Text = "Генерировать из символов:";
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.Orange;
            GenerateButton.FlatAppearance.BorderSize = 0;
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(12, 431);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(232, 41);
            GenerateButton.TabIndex = 14;
            GenerateButton.Text = "Сгенерировать";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(GenerateButton);
            Controls.Add(label5);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(PasswordLengthNumericUpDown);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PasswordLengthNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown PasswordLengthNumericUpDown;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label5;
        private Button GenerateButton;
    }
}