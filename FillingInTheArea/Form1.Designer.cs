namespace FillingInTheArea
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
            this.SideA = new System.Windows.Forms.TextBox();
            this.SideB = new System.Windows.Forms.TextBox();
            this.SideSquare = new System.Windows.Forms.TextBox();
            this.Step = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountSquaer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SideA
            // 
            this.SideA.Location = new System.Drawing.Point(118, 28);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(100, 20);
            this.SideA.TabIndex = 0;
            // 
            // SideB
            // 
            this.SideB.Location = new System.Drawing.Point(224, 27);
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(100, 20);
            this.SideB.TabIndex = 1;
            // 
            // SideSquare
            // 
            this.SideSquare.Location = new System.Drawing.Point(330, 27);
            this.SideSquare.Name = "SideSquare";
            this.SideSquare.Size = new System.Drawing.Size(100, 20);
            this.SideSquare.TabIndex = 2;
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(436, 27);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(100, 20);
            this.Step.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сторона а";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сторона b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сторона квадрата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шаг изменения длины";
            // 
            // CountSquaer
            // 
            this.CountSquaer.Location = new System.Drawing.Point(118, 68);
            this.CountSquaer.Multiline = true;
            this.CountSquaer.Name = "CountSquaer";
            this.CountSquaer.Size = new System.Drawing.Size(517, 370);
            this.CountSquaer.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отчистить\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CountSquaer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.SideSquare);
            this.Controls.Add(this.SideB);
            this.Controls.Add(this.SideA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideA;
        private System.Windows.Forms.TextBox SideB;
        private System.Windows.Forms.TextBox SideSquare;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountSquaer;
        private System.Windows.Forms.Button button2;
    }
}

