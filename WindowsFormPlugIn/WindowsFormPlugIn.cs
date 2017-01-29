using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInContract;

namespace WindowsFormPlugIn
{
    public class WindowsFormPlugIn : IMenuCreator
    {
        List<string> lstMenuItems = new List<string>();
        public WindowsFormPlugIn()
        {
            lstMenuItems.Add("Emploies");
            lstMenuItems.Add("Recruitment");
        }
        #region IMenuCreator Members

        public void CreateMenu(List<string> MenuList)
        {
            throw new NotImplementedException();
        }

        public string MenuTitle
        {
            get { throw new NotImplementedException(); }
        }

        public string ActionName
        {
            get { throw new NotImplementedException(); }
        }

        public string ControllerName
        {
            get { throw new NotImplementedException(); }
        }

        public List<string> MenuList
        {

            get {return lstMenuItems; }
        }

        #endregion
    }
}
