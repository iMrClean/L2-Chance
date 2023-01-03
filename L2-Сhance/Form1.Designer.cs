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
            this.accessoryPictureBox = new System.Windows.Forms.PictureBox();
            this.armorPictureBox = new System.Windows.Forms.PictureBox();
            this.weaponPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificationButton
            // 
            this.ModificationButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.ModificationButton.Location = new System.Drawing.Point(359, 516);
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
            // accessoryPictureBox
            // 
            this.accessoryPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accessoryPictureBox.Image = global::L2_Сhance.Properties.Resources.Accessory;
            this.accessoryPictureBox.Location = new System.Drawing.Point(364, 100);
            this.accessoryPictureBox.Name = "accessoryPictureBox";
            this.accessoryPictureBox.Size = new System.Drawing.Size(40, 40);
            this.accessoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accessoryPictureBox.TabIndex = 6;
            this.accessoryPictureBox.TabStop = false;
            this.accessoryPictureBox.Click += new System.EventHandler(this.accessoryPictureBox_Click);
            // 
            // armorPictureBox
            // 
            this.armorPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.armorPictureBox.Image = global::L2_Сhance.Properties.Resources.Armor;
            this.armorPictureBox.Location = new System.Drawing.Point(413, 100);
            this.armorPictureBox.Name = "armorPictureBox";
            this.armorPictureBox.Size = new System.Drawing.Size(40, 40);
            this.armorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.armorPictureBox.TabIndex = 7;
            this.armorPictureBox.TabStop = false;
            this.armorPictureBox.Click += new System.EventHandler(this.armorPictureBox_Click);
            // 
            // weaponPictureBox
            // 
            this.weaponPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weaponPictureBox.Image = global::L2_Сhance.Properties.Resources.Weapon;
            this.weaponPictureBox.Location = new System.Drawing.Point(463, 100);
            this.weaponPictureBox.Name = "weaponPictureBox";
            this.weaponPictureBox.Size = new System.Drawing.Size(40, 40);
            this.weaponPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weaponPictureBox.TabIndex = 8;
            this.weaponPictureBox.TabStop = false;
            this.weaponPictureBox.Click += new System.EventHandler(this.weaponPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L2_Сhance.Properties.Resources.MainForm;
            this.ClientSize = new System.Drawing.Size(874, 641);
            this.Controls.Add(this.weaponPictureBox);
            this.Controls.Add(this.armorPictureBox);
            this.Controls.Add(this.accessoryPictureBox);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.currentLevel);
            this.Controls.Add(this.ModificationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "L2-Chance";
            ((System.ComponentModel.ISupportInitialize)(this.accessoryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModificationButton;
        private System.Windows.Forms.Label currentLevel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.PictureBox accessoryPictureBox;
        private System.Windows.Forms.PictureBox armorPictureBox;
        private System.Windows.Forms.PictureBox weaponPictureBox;
    }
}

