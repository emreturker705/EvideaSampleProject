using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using PlugInContract;
using System.IO;

namespace PlugInApplicationDomain
{
    public class PlugInEngine : MarshalByRefObject
    {
        public List<IMenuCreator> LoadPlugInCommands()
        {
            var commandList = new List<IMenuCreator>(); // Plug-in'lerimizin instance'larını ekleyeceğimiz listemiz
            string basePath = AppDomain.CurrentDomain.BaseDirectory + "PlugIns"; // Plug-in'lerimizi bulmak için tarıyacağımız ana PlugIns path'imiz.

            foreach (var filePath in Directory.GetFiles(basePath, "*.dll")) // GetFiles metotuna yazdığımız "*.dll" patterni ile ilgili path'imizdeki assembly'lerimizi buluyoruz
            {
                var loadedAssembly = Assembly.LoadFile(filePath); // Reflection namespace'si altındaki Assembly sınıfı ile ilgili assembly'imizi yüklüyoruz
                var calculationTypes = loadedAssembly.GetTypes().Where(t => typeof(IMenuCreator).IsAssignableFrom(t)); // ICalculationCommand'dan inherit alan nesneleri buluyoruz

                foreach (var calculationType in calculationTypes)
                {
                    var cmd = Activator.CreateInstance(calculationType); // Instance'sini üretiyoruz
                    commandList.Add(new MenuPlugIn(cmd as IMenuCreator)); // Ürettiğimiz instance'ımızı hazırlamış olduğumuz bizim için serialize hale getirecek olan CalculationCommandCommunicator ile sarmalıyor ve commandList'imize ekliyoruz
                }
            }

            return commandList;
        }
    }
}
