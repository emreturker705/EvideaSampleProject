using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInContract;

namespace MVCPlugIn
{
    public class MVCPlugIn : IMenuCreator
    {
        #region IMenuCreator Members

        public string MenuTitle
        {
            get { return "MVC ÖRNEĞİ"; }
        }

        public string ActionName
        {
            get { return "HumanResources"; }
        }

        public string ControllerName
        {
            get {return "HumanResources"; }
        }

        public List<string> MenuList
        {
            get { return new List<string> { "Human Resources" }; }
        }

        #endregion
    }
}
