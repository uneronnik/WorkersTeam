using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ_C__week_3_1490359396.Classes.Buildings
{
    class House : Building
    {
        private new Sprite _defaultSprite = new Sprite("Sprites\\House.txt");
        public House(int wallsNumber, int doorsNumber, int windowsNumber)
        {
            _spriteRenderer.ChangeSprite(_defaultSprite);
            _parts.Add(new Basement()); // Последовательно добавляются части
            for (int i = 0; i < wallsNumber; i++)
            {
                _parts.Add(new Wall());
            }
            for (int i = 0; i < doorsNumber; i++)
            {
                _parts.Add(new Door());
            }
            for (int i = 0; i < windowsNumber; i++)
            {
                _parts.Add(new Window());
            }
            _parts.Add(new Roof());
        }
    }
}
