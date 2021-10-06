using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib.Messages
{
    sealed public class ExeptionMessage : ILogMessage
    {
        private string _message;
        public ExeptionMessage(string message)
        {
            _message = message;
        }
        string ILogMessage.ToString(INIManager manager)
        {
            Dictionary<string, int> order = new Dictionary<string, int>();
            order["date"] = Convert.ToInt32(manager.GetPrivateString("order", "date"));
            order["message type"] = Convert.ToInt32(manager.GetPrivateString("order", "message type"));
            order["user name"] = Convert.ToInt32(manager.GetPrivateString("order", "user name"));
            order["message"] = Convert.ToInt32(manager.GetPrivateString("order", "message"));
            order = order.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);



            Dictionary<string, bool> existence = new Dictionary<string, bool>();
            existence["date"] = Convert.ToBoolean(manager.GetPrivateString("existence", "date"));
            existence["message type"] = Convert.ToBoolean(manager.GetPrivateString("existence", "message type"));
            existence["user name"] = Convert.ToBoolean(manager.GetPrivateString("existence", "user name"));
            existence["message"] = Convert.ToBoolean(manager.GetPrivateString("existence", "message"));

            string stringToReturn = "";
            for (int i = 0; i < 4; i++)
            {
                string keyWithMinOrder = order.First().Key;
                if (existence[keyWithMinOrder] == true)
                {
                    switch (keyWithMinOrder)
                    {
                        case "date":
                            stringToReturn += $"[{DateTime.Now.ToLocalTime()}]" + " ";
                            break;
                        case "message type":
                            stringToReturn += "Exception" + " ";
                            break;
                        case "user name":
                            stringToReturn += "(User name)" + " ";
                            break;
                        case "message":
                            stringToReturn += _message + " ";
                            break;
                    }
                }

                order.Remove(keyWithMinOrder);

            }
            return stringToReturn;
        }
    }
}
