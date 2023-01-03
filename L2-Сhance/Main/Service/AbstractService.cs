using L2_Сhance.Main.Model;

namespace L2_Сhance.Main.Service
{
    internal class AbstractService
    {
        public int ItemCount { get; private set; }

        internal void ResetCount()
        {
            ItemCount = 0;
        }

        internal virtual void DoMagic(AbstractItem item)
        {
            item.DoMagic();
        }
    }
}
