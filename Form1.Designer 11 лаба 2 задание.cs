namespace Задание_2
{
    partial class STUDENT
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
            this.Array2 = new System.Windows.Forms.RichTextBox();
            this.Gen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Array1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Array2
            // 
            this.Array2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array2.Location = new System.Drawing.Point(440, 12);
            this.Array2.Name = "Array2";
            this.Array2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Array2.Size = new System.Drawing.Size(372, 543);
            this.Array2.TabIndex = 1;
            this.Array2.Text = "";
            // 
            // Gen
            // 
            this.Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gen.Location = new System.Drawing.Point(887, 34);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(126, 45);
            this.Gen.TabIndex = 2;
            this.Gen.Text = "Генерация";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(887, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(887, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Фильтрация ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Array1
            // 
            this.Array1.AcceptsReturn = true;
            this.Array1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Array1.Location = new System.Drawing.Point(12, 12);
            this.Array1.Multiline = true;
            this.Array1.Name = "Array1";
            this.Array1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Array1.Size = new System.Drawing.Size(422, 543);
            this.Array1.TabIndex = 5;
            // 
            // STUDENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 600);
            this.Controls.Add(this.Array1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Array2);
            this.Name = "STUDENT";
            this.Text = "STUDENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Array2;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Array1;
    }
}

