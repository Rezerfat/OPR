namespace Задание_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RMean = new System.Windows.Forms.TextBox();
            this.UMean = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IMean = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RMean
            // 
            this.RMean.Location = new System.Drawing.Point(750, 157);
            this.RMean.Name = "RMean";
            this.RMean.Size = new System.Drawing.Size(395, 34);
            this.RMean.TabIndex = 1;
            // 
            // UMean
            // 
            this.UMean.Location = new System.Drawing.Point(204, 157);
            this.UMean.Name = "UMean";
            this.UMean.Size = new System.Drawing.Size(395, 34);
            this.UMean.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вычисленная сила тока (I):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите U (напряжение)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите R (сопротивление)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Формула для нахождения силы тока: I = U * R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(552, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вычислить!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // IMean
            // 
            this.IMean.Location = new System.Drawing.Point(526, 70);
            this.IMean.Name = "IMean";
            this.IMean.Size = new System.Drawing.Size(281, 34);
            this.IMean.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1308, 505);
            this.Controls.Add(this.IMean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UMean);
            this.Controls.Add(this.RMean);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RMean;
        private System.Windows.Forms.TextBox UMean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IMean;
    }
}

