using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInContract;

namespace PlugInApplicationDomain
{
    public class MenuPlugIn : MarshalByRefObject, IMenuCreator
    {
        private IMenuCreator _creator;

        public MenuPlugIn(IMenuCreator creator)
        {
            this._creator = creator;
        }
        

        #region IMenuCreator Members

        public string MenuTitle
        {
            get { return this._creator.MenuTitle; }
        }

        public string ActionName
        {
            get {  return this._creator.ActionName; }
        }

        public string ControllerName
        {
            get
            {
                return this._creator.ControllerName;
            }
            
        }

        public List<string> MenuList
        {
            get
            {
                return this._creator.MenuList;
            }
           
        }

        #endregion
    }
}
