using L2_Сhance.Main.Factory;
using L2_Сhance.Main.Model;
using L2_Сhance.Main.Repository;
using System;
using System.Reflection;

namespace L2_Сhance.Main.Service
{
    internal abstract class AbstractService<T> : ServiceFactory, IAbstractService
    {
        public int ItemCount { get; private set; }

        internal void ResetCount()
        {
            ItemCount = 0;
        }

        public abstract void GetItem();

        public abstract void SaveItem(T input);

        public abstract void DeleteItem(T input);

        public void SaveItem(object model)
        {
            SaveItem((T)model);
        }

        public void DeleteItem(object model)
        {
            DeleteItem((T)model);
        }

        public override void DoMagic()
        {
            
        }
    }
}
