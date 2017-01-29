using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using PlugInApplicationDomain;
using PlugInContract;

namespace PlugInStarter
{
    public class PlugInStarter
    {
        public static List<IMenuCreator> Start()
        {
            #region Create AppDomain
            //var setUp = new AppDomainSetup();
            //setUp.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
           
            //// Kısıtlı ve güvenli olarak üretiyoruz. (CAS)
            //var permissionSet = new PermissionSet(PermissionState.None);
            //permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution)); // Çalıştırabilmek için yetki veriyoruz
            //permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.PathDiscovery, AppDomain.CurrentDomain.BaseDirectory)); // Sadece gerekli klasörümüze keşife izin veriyoruz
            //permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read, AppDomain.CurrentDomain.BaseDirectory + "PlugIns")); // Sadece gerekli klasörümüze okuma izni veriyoruz

            //var plugInApplicationDomain = AppDomain.CreateDomain("Plug In App Domain", null, setUp, permissionSet); // Gerekli bilgileri vererek domain ismi, kurulum bilgisi ve güvenlik izinleri gibi domainimizi üretiyoruz
            #endregion
            PlugInEngine engine = new PlugInEngine();
            // Diğer application domain'imizde PlugInEngine'mizi üretip bu objenin bize ObjectHandle bilgisini geriye döner.
            //var plugInEngine = (PlugInEngine)plugInApplicationDomain.CreateInstanceAndUnwrap(typeof(PlugInEngine).Assembly.FullName, typeof(PlugInEngine).FullName);

            return engine.LoadPlugInCommands();
        }
    }
}
