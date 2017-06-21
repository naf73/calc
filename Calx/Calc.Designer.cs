namespace Calx
{
    partial class Calc
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
            this.input1 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.input1Text = new System.Windows.Forms.TextBox();
            this.ouputText = new System.Windows.Forms.TextBox();
            this.input2Text = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.AutoSize = true;
            this.input1.Location = new System.Drawing.Point(37, 29);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(14, 13);
            this.input1.TabIndex = 0;
            this.input1.Text = "A";
            // 
            // input2
            // 
            this.input2.AutoSize = true;
            this.input2.Location = new System.Drawing.Point(37, 56);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(14, 13);
            this.input2.TabIndex = 1;
            this.input2.Text = "B";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(37, 84);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(14, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = "C";
            // 
            // input1Text
            // 
            this.input1Text.Location = new System.Drawing.Point(73, 26);
            this.input1Text.Name = "input1Text";
            this.input1Text.Size = new System.Drawing.Size(175, 20);
            this.input1Text.TabIndex = 3;
            // 
            // ouputText
            // 
            this.ouputText.Location = new System.Drawing.Point(73, 84);
            this.ouputText.Name = "ouputText";
            this.ouputText.ReadOnly = true;
            this.ouputText.Size = new System.Drawing.Size(175, 20);
            this.ouputText.TabIndex = 4;
            // 
            // input2Text
            // 
            this.input2Text.Location = new System.Drawing.Point(73, 53);
            this.input2Text.Name = "input2Text";
            this.input2Text.Size = new System.Drawing.Size(175, 20);
            this.input2Text.TabIndex = 5;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(40, 120);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "^2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.input2Text);
            this.Controls.Add(this.ouputText);
            this.Controls.Add(this.input1Text);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Calc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input1;
        private System.Windows.Forms.Label input2;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox input1Text;
        private System.Windows.Forms.TextBox ouputText;
        private System.Windows.Forms.TextBox input2Text;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

