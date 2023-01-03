using L2_Сhance.Main;
using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2_Сhance
{
    public partial class MainForm : Form
    {

        private ItemType selectedItemType;

        public event EventHandler<string> LogEventSelectedItem;

        private readonly AbstractService abstractService;

        public MainForm()
        {
            InitializeComponent();
            this.LogEventSelectedItem += LogEventSelectedItemHandler;
        }

        private void ModificationButton_Click(object sender, EventArgs e)
        {
            ItemServiceFactory factory = ItemServiceFactory.CreateItemServiceFactory(selectedItemType);
            ItemFactory abstractItem = factory.GetItem();
            abstractService.DoMagic(abstractItem);
        }

        private void LogEventSelectedItemHandler(object sender, string logMessage)
        {
            logRichTextBox.SelectionColor = Color.Coral;
            logRichTextBox.AppendText(logMessage + "\n");
            logRichTextBox.ScrollToCaret();
        }

        private void accessoryPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран аксессуар");
            selectedItemType = ItemType.ACCESSORY;
        }

        private void armorPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран доспех");
            selectedItemType = ItemType.ARMOR;
        }

        private void weaponPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран оружие");
            selectedItemType = ItemType.WEAPON;
        }
    }
}
