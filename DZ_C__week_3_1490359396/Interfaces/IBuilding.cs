using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C__week_3_1490359396.Interfaces
{
    interface IBuilding
    {
        bool IsBuilt();
        List<IPart> GetParts();
        void Render();
    }
}
