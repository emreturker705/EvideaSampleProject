using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInContract
{
    public interface IMenuCreator
    {
         string MenuTitle { get; }
         string ActionName { get;  }
         string ControllerName { get; }
         List<string> MenuList { get;  }

    }
}
