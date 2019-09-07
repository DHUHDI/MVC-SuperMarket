using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newSupermarketManager.ControllerBase
{
    interface IController<T>
    {
        //判断是否为空
        void JudgeNull(T obj);

    }
}
