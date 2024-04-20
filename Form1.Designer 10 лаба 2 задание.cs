namespace Задание_2
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
            this.R1Mean = new System.Windows.Forms.TextBox();
            this.R2Mean = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PoslLabel = new System.Windows.Forms.Label();
            this.ParallLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // R1Mean
            // 
            this.R1Mean.Location = new System.Drawing.Point(29, 129);
            this.R1Mean.Name = "R1Mean";
            this.R1Mean.Size = new System.Drawing.Size(312, 22);
            this.R1Mean.TabIndex = 0;
            this.R1Mean.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // R2Mean
            // 
            this.R2Mean.Location = new System.Drawing.Point(441, 129);
            this.R2Mean.Name = "R2Mean";
            this.R2Mean.Size = new System.Drawing.Size(312, 22);
            this.R2Mean.TabIndex = 1;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(246, 67);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(312, 22);
            this.R.TabIndex = 2;
            this.R.TextChanged += new System.EventHandler(this.R_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вычисленное сопротивление";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PoslLabel
            // 
            this.PoslLabel.AutoSize = true;
            this.PoslLabel.BackColor = System.Drawing.SystemColors.Info;
            this.PoslLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoslLabel.Location = new System.Drawing.Point(208, 290);
            this.PoslLabel.Name = "PoslLabel";
            this.PoslLabel.Size = new System.Drawing.Size(391, 20);
            this.PoslLabel.TabIndex = 5;
            this.PoslLabel.Text = "Вычислить в последовательном соединении";
            this.PoslLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ParallLabel
            // 
            this.ParallLabel.AutoSize = true;
            this.ParallLabel.BackColor = System.Drawing.SystemColors.Info;
            this.ParallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParallLabel.Location = new System.Drawing.Point(228, 234);
            this.ParallLabel.Name = "ParallLabel";
            this.ParallLabel.Size = new System.Drawing.Size(350, 20);
            this.ParallLabel.TabIndex = 6;
            this.ParallLabel.Text = "Вычислить в параллельном соединении";
            this.ParallLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(121, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Значение R1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(556, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Значение R2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ParallLabel);
            this.Controls.Add(this.PoslLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R);
            this.Controls.Add(this.R2Mean);
            this.Controls.Add(this.R1Mean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox R1Mean;
        private System.Windows.Forms.TextBox R2Mean;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PoslLabel;
        private System.Windows.Forms.Label ParallLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

