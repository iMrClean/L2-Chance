using L2_Сhance.Main;
using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace L2_Сhance
{
    public partial class MainForm : Form
    {

        private ItemType selectedItemType;

        public event EventHandler<string> LogSelectedItemEvent;

        private readonly ModificationService modificationService;

        private readonly ItemFactory itemFactory;

        public event EventHandler<int> EnchanceLevelEvent;

        Item item;

        public MainForm()
        {
            InitializeComponent();
            this.itemFactory = new ItemFactory();
            this.modificationService = new ModificationService();
            this.LogSelectedItemEvent += LogSelectedItemEventHandler;
            modificationService.LogEvent += LogEventHandler;
            modificationService.EnchanceLevelEvent += EnchanceLevelHandler;
            this.EnchanceLevelEvent += EnchanceLevelHandler;
        }

        private void ModificationButtonClick(object sender, EventArgs e)
        {
            RunProgressBar();
            item = itemFactory.GetItemByType(selectedItemType);
            if (item == null)
            {
                MessageBox.Show("Не выбран тип модификации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetProgressBar();
                return;
            }
            modificationService.Processing(item);
            ResetProgressBar();
        }

        private void RunProgressBar()
        {
            for (int i = 0; i < progressBar.Maximum; i++)
            {
                progressBar.Value++;
                Thread.Sleep(10);
            }
        }

        private void ResetProgressBar()
        {
            progressBar.Value = 0;
        }

        private void AccessoryPictureBoxClick(object sender, EventArgs e)
        {
            LogSelectedItemEvent?.Invoke(this, "Выбран аксессуар");
            selectedItemType = ItemType.ACCESSORY;
            item = itemFactory.GetItemByType(selectedItemType);
            EnchanceLevelEvent?.Invoke(this, item.EnchanceLevel);
            modificationService.ResetCount();
        }

        private void ArmorPictureBoxClick(object sender, EventArgs e)
        {
            LogSelectedItemEvent?.Invoke(this, "Выбран доспех");
            selectedItemType = ItemType.ARMOR;
            item = itemFactory.GetItemByType(selectedItemType);
            EnchanceLevelEvent?.Invoke(this, item.EnchanceLevel);
            modificationService.ResetCount();
        }

        private void WeaponPictureBoxClick(object sender, EventArgs e)
        {
            LogSelectedItemEvent?.Invoke(this, "Выбран оружие");
            selectedItemType = ItemType.WEAPON;
            item = itemFactory.GetItemByType(selectedItemType);
            EnchanceLevelEvent?.Invoke(this, item.EnchanceLevel);
            modificationService.ResetCount();
        }

        private void EnchanceLevelHandler(object sender, int curr)
        {
            if (curr == 0)
            {
                currentLevel.ForeColor = Color.Green;
            }
            else if (curr > 0 && curr < 5)
            {
                currentLevel.ForeColor = Color.Gold;
            }
            else 
            { 
                currentLevel.ForeColor = Color.DarkRed;
            }

            currentLevel.Text = curr.ToString();
        }

        private void LogSelectedItemEventHandler(object sender, string logMessage)
        {
            logRichTextBox.SelectionColor = Color.Coral;
            logRichTextBox.AppendText(logMessage + "\n");
            logRichTextBox.ScrollToCaret();
        }

        private void LogEventHandler(object sender, string logMessage)
        {
            if (logMessage.Contains("[Успешно]"))
            {
                logRichTextBox.SelectionColor = Color.Green;
            }
            else if (logMessage.Contains("[Неуспешно]"))
            {
                logRichTextBox.SelectionColor = Color.Red;
            }
            logRichTextBox.AppendText(logMessage + "\n");
            logRichTextBox.ScrollToCaret();
        }
    }
}
