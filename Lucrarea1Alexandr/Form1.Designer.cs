namespace Lucrarea1Alexandr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.selectFrom = new System.Windows.Forms.TextBox();
            this.WriteTo = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afisarea datei";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "MouseHover leave";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_Leave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Button6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "change text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "change color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(43, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 28);
            this.button6.TabIndex = 8;
            this.button6.Text = "retieve";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(241, 241);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(174, 121);
            this.inputText.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(42, 431);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(177, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "convert to integer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(257, 436);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(78, 20);
            this.num1.TabIndex = 11;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(370, 439);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(78, 20);
            this.num2.TabIndex = 12;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(487, 439);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(174, 20);
            this.suma.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "num1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "num2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "num1 + num2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(41, 496);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 28);
            this.button8.TabIndex = 17;
            this.button8.Text = "selecting a text";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // selectFrom
            // 
            this.selectFrom.Location = new System.Drawing.Point(244, 504);
            this.selectFrom.Name = "selectFrom";
            this.selectFrom.Size = new System.Drawing.Size(171, 20);
            this.selectFrom.TabIndex = 18;
            // 
            // WriteTo
            // 
            this.WriteTo.Location = new System.Drawing.Point(452, 504);
            this.WriteTo.Name = "WriteTo";
            this.WriteTo.Size = new System.Drawing.Size(171, 20);
            this.WriteTo.TabIndex = 19;
            this.WriteTo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(546, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(177, 28);
            this.button9.TabIndex = 20;
            this.button9.Text = "Add";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(549, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 121);
            this.listBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.WriteTo);
            this.Controls.Add(this.selectFrom);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox selectFrom;
        private System.Windows.Forms.TextBox WriteTo;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.ListBox listBox1;
    }
}

