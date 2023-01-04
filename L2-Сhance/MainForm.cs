using L2_Сhance.Main;
using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace L2_Сhance
{
    public partial class MainForm : Form
    {

        private ItemType selectedItemType;

        public event EventHandler<string> LogEventSelectedItem;

        private readonly ModificationService modificationService;

        private readonly ItemFactory itemFactory;
        public MainForm()
        {
            InitializeComponent();
            this.itemFactory = new ItemFactory();
            this.modificationService = new ModificationService();
            this.LogEventSelectedItem += LogEventSelectedItemHandler;
        }

        private void ModificationButton_Click(object sender, EventArgs e)
        {
            var item = itemFactory.GetItemByType<Item>(selectedItemType);
            if (item == null)
            {
                MessageBox.Show("Не выбран тип модификации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modificationService.DoMagic(item);
        }

        private void LogEventSelectedItemHandler(object sender, string logMessage)
        {
            logRichTextBox.SelectionColor = Color.Coral;
            logRichTextBox.AppendText(logMessage + "\n");
            logRichTextBox.ScrollToCaret();
        }

        private void AccessoryPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран аксессуар");
            selectedItemType = ItemType.ACCESSORY;
        }

        private void ArmorPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран доспех");
            selectedItemType = ItemType.ARMOR;
        }

        private void WeaponPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран оружие");
            selectedItemType = ItemType.WEAPON;
        }
    }
}
