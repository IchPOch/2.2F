namespace _2._2F
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
            this.Ras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.den = new System.Windows.Forms.TextBox();
            this.rab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ras
            // 
            this.Ras.Location = new System.Drawing.Point(35, 177);
            this.Ras.Name = "Ras";
            this.Ras.Size = new System.Drawing.Size(141, 23);
            this.Ras.TabIndex = 0;
            this.Ras.Text = "Узнать расписание";
            this.Ras.UseVisualStyleBackColor = true;
            this.Ras.Click += new System.EventHandler(this.Ras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "введите день недели";
            // 
            // den
            // 
            this.den.Location = new System.Drawing.Point(35, 112);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(100, 20);
            this.den.TabIndex = 2;
            // 
            // rab
            // 
            this.rab.Location = new System.Drawing.Point(175, 151);
            this.rab.Name = "rab";
            this.rab.ReadOnly = true;
            this.rab.Size = new System.Drawing.Size(153, 20);
            this.rab.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rab);
            this.Controls.Add(this.den);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox den;
        private System.Windows.Forms.TextBox rab;
    }
}

