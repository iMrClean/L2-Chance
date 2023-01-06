using L2_Сhance.Main;
using L2_Сhance.Main.Enum;
using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using L2_Сhance.Main.Service;
using L2_Сhance.Main.Service.Item;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L2_Сhance
{
    public partial class MainForm : Form
    {
        public int TryCount { get; private set; } = 1;

        private IAbstractService abstractService;

        private AbstractItem item;

        private ItemType selectedItemType;

        public event EventHandler<string> LogEvent;

        public event EventHandler<int> EnchanceLevelEvent;

        public event EventHandler<int> ProgressEvent;
        public MainForm()
        {
            InitializeComponent();
            this.LogEvent += LogEventHandler;
            this.EnchanceLevelEvent += EnchanceLevelEventHandler;
            this.ProgressEvent += ProgressEventHandler;
        }

        private void ModificationButtonClick(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("Не выбран тип модификации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RunProgressBar();
            bool isSuccessMagic = abstractService.DoMagic(item);
            if (isSuccessMagic)
            {
                SuccessMethod(item);
            }
            else
            {
                FailureMethod();
            }
        }

        private void SuccessMethod(AbstractItem item)
        {
            item = abstractService.SaveItem(item);
            UpdateEnchanceLevelEvent(item);
            UpdateLogEvent("[Успешно] Модификация на " + item.EnchanceLevel + " прошла успешно. Количество попыток " + TryCount);
        }

        private void FailureMethod()
        {
            ++TryCount;
            item = abstractService.DeleteItem();
            UpdateEnchanceLevelEvent(item);
            UpdateLogEvent("[Неуспешно] Модификация прошла неуспешно. Количество попыток " + TryCount);
        }

        public void ResetCount()
        {
            TryCount = 1;
        }

        private void RunProgressBar()
        {
            progressBar.Value = 0;

            for (int i = 0; i < progressBar.Maximum; i++)
            {
                progressBar.Value++;
                Thread.Sleep(10);
            }
        }

        private void AccessoryPictureBoxClick(object sender, EventArgs e)
        {
            selectedItemType = ItemType.ACCESSORY;
            UpdateLogEvent("Выбран аксессуар");
            item = GetSelectedItem();
            UpdateEnchanceLevelEvent(item);
            ResetCount();
        }

        private void ArmorPictureBoxClick(object sender, EventArgs e)
        {
            selectedItemType = ItemType.ARMOR;
            UpdateLogEvent("Выбран доспех");
            item = GetSelectedItem();
            UpdateEnchanceLevelEvent(item);
            ResetCount();
        }

        private void WeaponPictureBoxClick(object sender, EventArgs e)
        {
            selectedItemType = ItemType.WEAPON;
            UpdateLogEvent("Выбрано оружие");
            item = GetSelectedItem();
            UpdateEnchanceLevelEvent(item);
            ResetCount();
        }

        private void UpdateEnchanceLevelEvent(AbstractItem item)
        {
            EnchanceLevelEvent?.Invoke(this, item.EnchanceLevel);
        }

        private void UpdateLogEvent(string logMessage)
        {
            LogEvent?.Invoke(this, logMessage);
        }

        private AbstractItem GetSelectedItem()
        {
            abstractService = ServiceFactory.GetServiceByItemType(selectedItemType);
            return abstractService != null ? abstractService.GetItem() : null;
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
            else
            {
                logRichTextBox.SelectionColor = Color.Coral;
            }
            logRichTextBox.AppendText(logMessage + "\n");
            logRichTextBox.ScrollToCaret();
        }

        private void EnchanceLevelEventHandler(object sender, int curr)
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
        
        private void ProgressBarEventHandler(object sender, int a)
        {

        }
        private void ProgressEventHandler(object sender, ProgressEventArgs e)
        {
            progressBar.Value += e.Progress;
        }
    }
}
