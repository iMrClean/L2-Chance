using L2_Сhance.Main;
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

        private readonly ItemRepository itemRepository = new ItemRepository();

        private Item SelectedItem;

        public event EventHandler<string> LogEventSelectedItem;

        public MainForm()
        {
            InitializeComponent();
            modificationService = new ModificationService(itemRepository);
            itemRepository.EnchanceLevel += EnchanceLevelHandler;
            modificationService.LogEvent += LogEventHandler;
            this.LogEventSelectedItem += LogEventSelectedItemHandler;
        }

        private void ModificationButton_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null) 
            {
                MessageBox.Show("Не выбран тип модификации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            modificationService.Process(SelectedItem);
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
        }

        private void accessoryPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Начинаем точить аксессуары");
            SelectedItem = itemRepository.GetItemAccessory();
        }

        private void armorPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Начинаем точить армор");
            SelectedItem = itemRepository.GetItemArmor();
        }

        private void weaponPictureBox_Click(object sender, EventArgs e)
        {
            LogEventSelectedItem?.Invoke(this, "Начинаем точить оружие");
            SelectedItem = itemRepository.GetItemWeapon();
        }
    }
}
