namespace HW3_MultithreadingAndAsynchrony
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
            this.lb_PrimeNumbers = new System.Windows.Forms.Label();
            this.lbox_PrimeNumbers = new System.Windows.Forms.ListBox();
            this.lb_Start = new System.Windows.Forms.Label();
            this.lb_End = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_Start = new System.Windows.Forms.TextBox();
            this.tbox_End = new System.Windows.Forms.TextBox();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_StartPrimeNumbers = new System.Windows.Forms.Button();
            this.btn_StopPrimeNumbers = new System.Windows.Forms.Button();
            this.btn_PausePrimeNumbers = new System.Windows.Forms.Button();
            this.btn_ResumePrimeNumbers = new System.Windows.Forms.Button();
            this.lb_FibonacciNumbers = new System.Windows.Forms.Label();
            this.lbox_FibonacciNumbers = new System.Windows.Forms.ListBox();
            this.btn_StartFibonacciNumbers = new System.Windows.Forms.Button();
            this.btn_PauseFibonacciNumbers = new System.Windows.Forms.Button();
            this.btn_ResumeFibonacciNumbers = new System.Windows.Forms.Button();
            this.btn_StopFibonacciNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_PrimeNumbers
            // 
            this.lb_PrimeNumbers.AutoSize = true;
            this.lb_PrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_PrimeNumbers.Location = new System.Drawing.Point(9, 56);
            this.lb_PrimeNumbers.Name = "lb_PrimeNumbers";
            this.lb_PrimeNumbers.Size = new System.Drawing.Size(97, 13);
            this.lb_PrimeNumbers.TabIndex = 0;
            this.lb_PrimeNumbers.Text = "Простые числа";
            // 
            // lbox_PrimeNumbers
            // 
            this.lbox_PrimeNumbers.FormattingEnabled = true;
            this.lbox_PrimeNumbers.Location = new System.Drawing.Point(11, 72);
            this.lbox_PrimeNumbers.Name = "lbox_PrimeNumbers";
            this.lbox_PrimeNumbers.Size = new System.Drawing.Size(120, 537);
            this.lbox_PrimeNumbers.TabIndex = 1;
            // 
            // lb_Start
            // 
            this.lb_Start.AutoSize = true;
            this.lb_Start.Location = new System.Drawing.Point(112, 19);
            this.lb_Start.Name = "lb_Start";
            this.lb_Start.Size = new System.Drawing.Size(99, 13);
            this.lb_Start.TabIndex = 2;
            this.lb_Start.Text = "начало диапазона";
            // 
            // lb_End
            // 
            this.lb_End.AutoSize = true;
            this.lb_End.Location = new System.Drawing.Point(309, 19);
            this.lb_End.Name = "lb_End";
            this.lb_End.Size = new System.Drawing.Size(94, 13);
            this.lb_End.TabIndex = 2;
            this.lb_End.Text = "конец диапазона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для генерации\r\nчисел укажите:";
            // 
            // tbox_Start
            // 
            this.tbox_Start.Location = new System.Drawing.Point(217, 15);
            this.tbox_Start.Name = "tbox_Start";
            this.tbox_Start.Size = new System.Drawing.Size(86, 20);
            this.tbox_Start.TabIndex = 4;
            // 
            // tbox_End
            // 
            this.tbox_End.Location = new System.Drawing.Point(409, 15);
            this.tbox_End.Name = "tbox_End";
            this.tbox_End.Size = new System.Drawing.Size(86, 20);
            this.tbox_End.TabIndex = 5;
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Restart.Location = new System.Drawing.Point(207, 615);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(107, 110);
            this.btn_Restart.TabIndex = 6;
            this.btn_Restart.Text = "Рестарт потоков с новыми границами";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_StartPrimeNumbers
            // 
            this.btn_StartPrimeNumbers.BackColor = System.Drawing.Color.Lime;
            this.btn_StartPrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_StartPrimeNumbers.Location = new System.Drawing.Point(14, 615);
            this.btn_StartPrimeNumbers.Name = "btn_StartPrimeNumbers";
            this.btn_StartPrimeNumbers.Size = new System.Drawing.Size(118, 23);
            this.btn_StartPrimeNumbers.TabIndex = 7;
            this.btn_StartPrimeNumbers.Text = "Старт";
            this.btn_StartPrimeNumbers.UseVisualStyleBackColor = false;
            this.btn_StartPrimeNumbers.Click += new System.EventHandler(this.btn_StartPrimeNumbers_Click);
            // 
            // btn_StopPrimeNumbers
            // 
            this.btn_StopPrimeNumbers.BackColor = System.Drawing.Color.Red;
            this.btn_StopPrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_StopPrimeNumbers.Location = new System.Drawing.Point(13, 702);
            this.btn_StopPrimeNumbers.Name = "btn_StopPrimeNumbers";
            this.btn_StopPrimeNumbers.Size = new System.Drawing.Size(119, 23);
            this.btn_StopPrimeNumbers.TabIndex = 8;
            this.btn_StopPrimeNumbers.Text = "Стоп";
            this.btn_StopPrimeNumbers.UseVisualStyleBackColor = false;
            this.btn_StopPrimeNumbers.Click += new System.EventHandler(this.btn_StopPrimeNumbers_Click);
            // 
            // btn_PausePrimeNumbers
            // 
            this.btn_PausePrimeNumbers.BackColor = System.Drawing.Color.Yellow;
            this.btn_PausePrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_PausePrimeNumbers.Location = new System.Drawing.Point(14, 644);
            this.btn_PausePrimeNumbers.Name = "btn_PausePrimeNumbers";
            this.btn_PausePrimeNumbers.Size = new System.Drawing.Size(118, 23);
            this.btn_PausePrimeNumbers.TabIndex = 9;
            this.btn_PausePrimeNumbers.Text = "Пауза";
            this.btn_PausePrimeNumbers.UseVisualStyleBackColor = false;
            this.btn_PausePrimeNumbers.Click += new System.EventHandler(this.btn_PausePrimeNumbers_Click);
            // 
            // btn_ResumePrimeNumbers
            // 
            this.btn_ResumePrimeNumbers.BackColor = System.Drawing.Color.Cyan;
            this.btn_ResumePrimeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ResumePrimeNumbers.Location = new System.Drawing.Point(14, 673);
            this.btn_ResumePrimeNumbers.Name = "btn_ResumePrimeNumbers";
            this.btn_ResumePrimeNumbers.Size = new System.Drawing.Size(118, 23);
            this.btn_ResumePrimeNumbers.TabIndex = 10;
            this.btn_ResumePrimeNumbers.Text = "Возобновить";
            this.btn_ResumePrimeNumbers.UseVisualStyleBackColor = false;
            this.btn_ResumePrimeNumbers.Click += new System.EventHandler(this.btn_ResumePrimeNumbers_Click);
            // 
            // lb_FibonacciNumbers
            // 
            this.lb_FibonacciNumbers.AutoSize = true;
            this.lb_FibonacciNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_FibonacciNumbers.Location = new System.Drawing.Point(372, 56);
            this.lb_FibonacciNumbers.Name = "lb_FibonacciNumbers";
            this.lb_FibonacciNumbers.Size = new System.Drawing.Size(114, 13);
            this.lb_FibonacciNumbers.TabIndex = 0;
            this.lb_FibonacciNumbers.Text = "Числа Фибоначчи";
            // 
            // lbox_FibonacciNumbers
            // 
            this.lbox_FibonacciNumbers.FormattingEnabled = true;
            this.lbox_FibonacciNumbers.Location = new System.Drawing.Point(375, 72);
            this.lbox_FibonacciNumbers.Name = "lbox_FibonacciNumbers";
            this.lbox_FibonacciNumbers.Size = new System.Drawing.Size(120, 537);
            this.lbox_FibonacciNumbers.TabIndex = 1;
            // 
            // btn_StartFibonacciNumbers
            // 
            this.btn_StartFibonacciNumbers.BackColor = System.Drawing.Color.Lime;
            this.btn_StartFibonacciNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_StartFibonacciNumbers.Location = new System.Drawing.Point(374, 615);
            this.btn_StartFibonacciNumbers.Name = "btn_StartFibonacciNumbers";
            this.btn_StartFibonacciNumbers.Size = new System.Drawing.Size(118, 23);
            this.btn_StartFibonacciNumbers.TabIndex = 7;
            this.btn_StartFibonacciNumbers.Text = "Старт";
            this.btn_StartFibonacciNumbers.UseVisualStyleBackColor = false;
            this.btn_StartFibonacciNumbers.Click += new System.EventHandler(this.btn_StartFibonacciNumbers_Click);
            // 
            // btn_PauseFibonacciNumbers
            // 
            this.btn_PauseFibonacciNumbers.BackColor = System.Drawing.Color.Yellow;
            this.btn_PauseFibonacciNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_PauseFibonacciNumbers.Location = new System.Drawing.Point(374, 644);
            this.btn_PauseFibonacciNumbers.Name = "btn_PauseFibonacciNumbers";
            this.btn_PauseFibonacciNumbers.Size = new System.Drawing.Size(118, 23);
            this.btn_PauseFibonacciNumbers.TabIndex = 9;
            this.btn_PauseFibonacciNumbers.Text = "Пауза";
            this.btn_PauseFibonacciNumbers.UseVisualStyleBackColor = false;
            this.btn_PauseFibonacciNumbers.Click += new System.EventHandler(this.btn_PauseFibonacciNumbers_Click);
            // 
            // btn_ResumeFibonacciNumbers
            // 
            this.btn_ResumeFibonacciNumbers.BackColor = System.Drawing.Color.Cyan;
            this.btn_ResumeFibonacciNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ResumeFibonacciNumbers.Location = new System.Drawing.Point(374, 673);
            this.btn_ResumeFibonacciNumbers.Name = "btn_ResumeFibonacciNumbers";
            this.btn_ResumeFibonacciNumbers.Size = new System.Drawing.Size(118, 23);
            this.btn_ResumeFibonacciNumbers.TabIndex = 10;
            this.btn_ResumeFibonacciNumbers.Text = "Возобновить";
            this.btn_ResumeFibonacciNumbers.UseVisualStyleBackColor = false;
            this.btn_ResumeFibonacciNumbers.Click += new System.EventHandler(this.btn_ResumeFibonacciNumbers_Click);
            // 
            // btn_StopFibonacciNumbers
            // 
            this.btn_StopFibonacciNumbers.BackColor = System.Drawing.Color.Red;
            this.btn_StopFibonacciNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_StopFibonacciNumbers.Location = new System.Drawing.Point(374, 702);
            this.btn_StopFibonacciNumbers.Name = "btn_StopFibonacciNumbers";
            this.btn_StopFibonacciNumbers.Size = new System.Drawing.Size(119, 23);
            this.btn_StopFibonacciNumbers.TabIndex = 8;
            this.btn_StopFibonacciNumbers.Text = "Стоп";
            this.btn_StopFibonacciNumbers.UseVisualStyleBackColor = false;
            this.btn_StopFibonacciNumbers.Click += new System.EventHandler(this.btn_StopFibonacciNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 737);
            this.Controls.Add(this.btn_ResumeFibonacciNumbers);
            this.Controls.Add(this.btn_ResumePrimeNumbers);
            this.Controls.Add(this.btn_PauseFibonacciNumbers);
            this.Controls.Add(this.btn_PausePrimeNumbers);
            this.Controls.Add(this.btn_StopFibonacciNumbers);
            this.Controls.Add(this.btn_StopPrimeNumbers);
            this.Controls.Add(this.btn_StartFibonacciNumbers);
            this.Controls.Add(this.btn_StartPrimeNumbers);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.tbox_End);
            this.Controls.Add(this.tbox_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_End);
            this.Controls.Add(this.lb_Start);
            this.Controls.Add(this.lbox_FibonacciNumbers);
            this.Controls.Add(this.lbox_PrimeNumbers);
            this.Controls.Add(this.lb_FibonacciNumbers);
            this.Controls.Add(this.lb_PrimeNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PrimeNumbers;
        private System.Windows.Forms.ListBox lbox_PrimeNumbers;
        private System.Windows.Forms.Label lb_Start;
        private System.Windows.Forms.Label lb_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_Start;
        private System.Windows.Forms.TextBox tbox_End;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_StartPrimeNumbers;
        private System.Windows.Forms.Button btn_StopPrimeNumbers;
        private System.Windows.Forms.Button btn_PausePrimeNumbers;
        private System.Windows.Forms.Button btn_ResumePrimeNumbers;
        private System.Windows.Forms.Label lb_FibonacciNumbers;
        private System.Windows.Forms.ListBox lbox_FibonacciNumbers;
        private System.Windows.Forms.Button btn_StartFibonacciNumbers;
        private System.Windows.Forms.Button btn_PauseFibonacciNumbers;
        private System.Windows.Forms.Button btn_ResumeFibonacciNumbers;
        private System.Windows.Forms.Button btn_StopFibonacciNumbers;
    }
}

