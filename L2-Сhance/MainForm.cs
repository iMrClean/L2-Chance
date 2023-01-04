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

        public event EventHandler<string> LogSelectedItemEvent;

        private readonly ModificationService modificationService;

        private readonly ItemFactory itemFactory;
        public MainForm()
        {
            InitializeComponent();
            this.itemFactory = new ItemFactory();
            this.modificationService = new ModificationService();
            this.LogSelectedItemEvent += LogSelectedItemEventHandler;
        }

        private void ModificationButtonClick(object sender, EventArgs e)
        {
            var item = itemFactory.GetItemByType(selectedItemType);
            if (item == null)
            {
                MessageBox.Show("Не выбран тип модификации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            modificationService.Processing(item);
        }

        private void AccessoryPictureBoxClick(object sender, EventArgs e)
        {
            LogSelectedItemEvent?.Invoke(this, "Выбран аксессуар");
            selectedItemType = ItemType.ACCESSORY;
        }

        private void ArmorPictureBoxClick(object sender, EventArgs e)
        {
            LogSelectedItemEvent?.Invoke(this, "Выбран доспех");
            selectedItemType = ItemType.ARMOR;
        }

        private void WeaponPictureBoxClick(object sender, EventArgs e)
        {
            LogSelectedItemEvent?.Invoke(this, "Выбран оружие");
            selectedItemType = ItemType.WEAPON;
        }
        private void LogSelectedItemEventHandler(object sender, string logMessage)
        {
            logRichTextBox.SelectionColor = Color.Coral;
            logRichTextBox.AppendText(logMessage + "\n");
            logRichTextBox.ScrollToCaret();
        }
    }
}
