
namespace WindowsFormsApp1
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
            this.отобразить = new System.Windows.Forms.Button();
            this.выход = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // отобразить
            // 
            this.отобразить.Location = new System.Drawing.Point(197, 240);
            this.отобразить.Name = "отобразить";
            this.отобразить.Size = new System.Drawing.Size(91, 31);
            this.отобразить.TabIndex = 0;
            this.отобразить.Text = "отобразить";
            this.отобразить.UseVisualStyleBackColor = true;
            // 
            // выход
            // 
            this.выход.Location = new System.Drawing.Point(508, 241);
            this.выход.Name = "выход";
            this.выход.Size = new System.Drawing.Size(92, 30);
            this.выход.TabIndex = 1;
            this.выход.Text = "выход";
            this.выход.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.выход);
            this.Controls.Add(this.отобразить);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button отобразить;
        private System.Windows.Forms.Button выход;
        private System.Windows.Forms.TextBox textBox1;
    }
}

