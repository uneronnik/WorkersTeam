using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LoggerLib.Events;
namespace LoggerLib
{
    public class Logger
    {
        public static void AddEvent(IEvent logEvent)
        {
            INIManager manager = new INIManager("settings.ini");
            if (!File.Exists("log.txt"))
            {
                File.Create("log.txt");
            }

            StreamWriter streamWriter = new StreamWriter("log.txt", true, Encoding.Default);
            string eventLine = logEvent.ToString(manager);


            streamWriter.WriteLine(eventLine);

            streamWriter.Close();
        }
    }
}
