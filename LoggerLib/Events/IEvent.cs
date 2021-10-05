using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib.Events
{
    public interface IEvent
    {
        string ToString(INIManager manager);
    }
}
