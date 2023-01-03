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
            itemRepository.EnchanceLevel += EnchanceLevel_Handler;
        }

        private void ModificationButton_Click(object sender, EventArgs e)
        {
            Item item = itemRepository.GetItem();
            modificationService.Process(item);
        }

        private void EnchanceLevel_Handler(object sender, int curr)
        {
            currentLevel.Text = curr.ToString();
        }
    }
}
