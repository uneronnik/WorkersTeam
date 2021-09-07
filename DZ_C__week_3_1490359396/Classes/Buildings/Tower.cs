using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes;
using DZ_C__week_3_1490359396.Classes.Parts;

namespace DZ_C__week_3_1490359396.Classes.Buildings
{
    class Tower : Building
    {
        private Sprite _defaultSprite = new Sprite("Sprites\\Tower.txt");
        public Tower(int windowsNumber)
        {
            _spriteRenderer.ChangeSprite(_defaultSprite);
            _parts.Add(new Basement());
            for (int i = 0; i < windowsNumber; i++)
                _parts.Add(new Window());
            _parts.Add(new Roof());
        }

    }
}
