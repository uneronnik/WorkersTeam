using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;

using LoggerLib;
using LoggerLib.Messages;

namespace DZ_C__week_3_1490359396.Classes
{
    class SpriteRenderer // Выводит спрайт на экран
    {
        Sprite _sprite = null;

        internal Sprite Sprite { get => _sprite; }

        public SpriteRenderer(string spritePath)
        {
            this._sprite = new Sprite(spritePath);
        }
        public SpriteRenderer(Sprite sprite)
        {
            this._sprite = sprite;
        }
        public void RenderSprite()
        {
            Logger.WriteMessage(new InformationMessage("Началась прорисовка спрайта"));
            if (_sprite.Lines == null)
                return;
            
            foreach(var line in _sprite.Lines)
            {
                Console.WriteLine(line);
            }
            Logger.WriteMessage(new InformationMessage("Спрайт успешно прорисован"));
        }
        public void ChangeSprite(Sprite sprite)
        {
            _sprite.SetSprite(sprite);
        }

    }
}
