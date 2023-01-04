using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Сhance.Main.Service
{
    internal interface IAbstractService
    {

        void GetItem();

        void SaveItem(object model);

        void DeleteItem(object model);

        void DoMagic();
    }
}
