using DZ_C__week_3_1490359396.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C__week_3_1490359396.Classes
{
    class Part : IPart
    {
        protected bool _built;
        void IPart.Build()
        {
            _built = true;
        }

        bool IPart.IsBuilt()
        {
            return _built;
        }

        public Part()
        {
            _built = false;
        }
    }
}
