using L2_Сhance.Main.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Model
{
    internal abstract class AbstractItem
    {
        public int EnchanceLevel { get; set; }

        public ItemType ItemType { get; set; }

        public abstract int GetSaveEnchangeLevel();

        public abstract int GetCurrentChance();

    }
}
