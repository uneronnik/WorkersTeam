using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;

namespace DZ_C__week_3_1490359396.Classes.Buildings
{
    class Town : Building
    {
        private new Sprite _defaultSprite = new Sprite("Sprites\\Town.txt");
        public Town(Castle castle, List<House> houses)
        {
            _spriteRenderer.ChangeSprite(_defaultSprite);

            _parts.Add(castle as IPart);

            foreach(var house in houses)
                _parts.Add(house as IPart);
        }
    }
}
