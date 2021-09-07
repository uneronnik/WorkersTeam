using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Classes;

namespace DZ_C__week_3_1490359396.Interfaces
{
    interface IWorker
    {
        void Work(ref IBuilding houseToBuild);
    }
}
