namespace L2_Сhance
{
    partial class MainForm
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
            this.ModificationButton = new System.Windows.Forms.Button();
            this.currentLevel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModificationButton
            // 
            this.ModificationButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ModificationButton.Location = new System.Drawing.Point(174, 516);
            this.ModificationButton.Name = "ModificationButton";
            this.ModificationButton.Size = new System.Drawing.Size(161, 37);
            this.ModificationButton.TabIndex = 0;
            this.ModificationButton.Text = "Модификация";
            this.ModificationButton.UseVisualStyleBackColor = false;
            this.ModificationButton.Click += new System.EventHandler(this.ModificationButton_Click);
            // 
            // currentLevel
            // 
            this.currentLevel.BackColor = System.Drawing.Color.Transparent;
            this.currentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentLevel.ForeColor = System.Drawing.Color.Green;
            this.currentLevel.Location = new System.Drawing.Point(391, 279);
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.Size = new System.Drawing.Size(98, 94);
            this.currentLevel.TabIndex = 1;
            this.currentLevel.Text = "0";
            this.currentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(215, 425);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(449, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.CausesValidation = false;
            this.logRichTextBox.Location = new System.Drawing.Point(215, 157);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.logRichTextBox.Size = new System.Drawing.Size(449, 110);
            this.logRichTextBox.TabIndex = 3;
            this.logRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(358, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Модификация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(539, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Модификация";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L2_Сhance.Properties.Resources.MainForm;
            this.ClientSize = new System.Drawing.Size(874, 641);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.currentLevel);
            this.Controls.Add(this.ModificationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "L2-Chance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificationButton;
        private System.Windows.Forms.Label currentLevel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

