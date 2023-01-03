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
            this.SuspendLayout();
            // 
            // ModificationButton
            // 
            this.ModificationButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ModificationButton.Location = new System.Drawing.Point(359, 517);
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
            this.currentLevel.ForeColor = System.Drawing.Color.Red;
            this.currentLevel.Location = new System.Drawing.Point(391, 279);
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.Size = new System.Drawing.Size(98, 94);
            this.currentLevel.TabIndex = 1;
            this.currentLevel.Text = "0";
            this.currentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L2_Сhance.Properties.Resources.MainForm;
            this.ClientSize = new System.Drawing.Size(874, 641);
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
    }
}

