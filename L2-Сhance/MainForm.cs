using L2_Сhance.Main;
using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Model;
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
        private readonly ModificationService modificationService;

        private ItemType selectedItemType;

        public event EventHandler<string> LogEventSelectedItem;

        public MainForm()
        {
            InitializeComponent();
            modificationService = new ModificationService();
            modificationService.EnchanceLevel += EnchanceLevelHandler;
            modificationService.LogEvent += LogEventHandler;
            this.LogEventSelectedItem += LogEventSelectedItemHandler;
        }

        private void ModificationButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = null;

            switch (selectedItemType)
            {
                case ItemType.UNDEFINED:
                    MessageBox.Show("Не выбран тип модификации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    break;
                case ItemType.ACCESSORY:
                    selectedItem = modificationService.GetItemAccessory();
                    modificationService.DoMagicAccessory(selectedItem);
                    break;
                case ItemType.WEAPON:
                    //selectedItem = modificationService.GetItemWeapon();
                    //modificationService.DoMagicWeapon(selectedItem);
                    break;
                case ItemType.ARMOR:
                    //selectedItem = modificationService.GetItemArmor();
                    //modificationService.DoMagicArmor(selectedItem);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void EnchanceLevelHandler(object sender, int curr)
        {
            
            if (curr == 0) {
                currentLevel.ForeColor = Color.Green;
            }
            else if (curr > 0 && curr < 4)
            {
                currentLevel.ForeColor = Color.Gold;
            }
            else { currentLevel.ForeColor = Color.DarkRed; }

            currentLevel.Text = curr.ToString();
        }

        private void LogEventHandler(object sender, string logMessage) 
        {
            if(logMessage.Contains("[Успешно]")) 
            {
                logRichTextBox.SelectionColor = Color.Green;
                logRichTextBox.AppendText(logMessage + "\n");
            } 
            else if(logMessage.Contains("[Неуспешно]"))
            {
                logRichTextBox.SelectionColor = Color.Red;
                logRichTextBox.AppendText(logMessage + " Количество попыток : " + modificationService.ItemCount + "\n");
            }
            logRichTextBox.SelectionStart = logRichTextBox.Text.Length;
            logRichTextBox.ScrollToCaret();
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
            modificationService.ResetCount();
        }

        private void armorPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран доспех");
            selectedItemType = ItemType.ARMOR;
            modificationService.ResetCount();
        }

        private void weaponPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Выбран оружие");
            selectedItemType = ItemType.WEAPON;
            modificationService.ResetCount();
        }
    }
}
