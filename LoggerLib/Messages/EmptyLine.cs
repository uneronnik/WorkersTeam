using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib.Messages
{
    sealed public class EmptyLine : ILogMessage
    {
        string ILogMessage.ToString(INIManager manager)
        {
            return "";
        }
    }
}
