using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Parts;

namespace DZ_C__week_3_1490359396.Classes.Buildings
{
    class Castle : Building
    {
        private new Sprite _defaultSprite = new Sprite("Sprites\\Castle.txt");
        public Castle(int wallsNumber, int gatesNumber, int windowsNumber, List<Tower> towers)
        {
            _spriteRenderer.ChangeSprite(_defaultSprite);
            _parts.Add(new Basement()); // Последовательно добавляются части

            foreach(var tower in towers)
                _parts.Add(tower);

            for (int i = 0; i < wallsNumber; i++)
                _parts.Add(new Wall());

            for (int i = 0; i < gatesNumber; i++)
                _parts.Add(new Gate());

            for (int i = 0; i < windowsNumber; i++)
                _parts.Add(new Window());
            
            _parts.Add(new Roof());
        }
    }
}
