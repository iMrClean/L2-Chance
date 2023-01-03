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

        public MainForm()
        {
            InitializeComponent();
            modificationService = new ModificationService(itemRepository);
            itemRepository.EnchanceLevel += EnchanceLevelHandler;
            modificationService.LogEvent += LogEventHandler; 
        }

        private void ModificationButton_Click(object sender, EventArgs e)
        {
            Item item = itemRepository.GetItemAccessory();
            modificationService.Process(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = itemRepository.GetItemWeapon();
            modificationService.Process(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item item = itemRepository.GetItemArmor();
            modificationService.Process(item);
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
    }
}
