using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;

namespace DZ_C__week_3_1490359396.Classes
{
    class Building : IBuilding, IPart
    {
        protected List<IPart> _parts = new List<IPart>(); // Список всех частей дома
        protected SpriteRenderer _spriteRenderer = new SpriteRenderer(new Sprite());
        protected bool _built;

        internal List<IPart> Parts { get => _parts; }
        void IPart.Build()
        {
            _built = true;
        }

        List<IPart> IBuilding.GetParts()
        {
            return Parts;
        }

        bool IBuilding.IsBuilt()
        {
            foreach (var part in _parts)
            {
                if (!part.IsBuilt())
                    return false;
            }
            return true;
        }

        bool IPart.IsBuilt()
        {
            return _built;
        }

        void IBuilding.Render()
        {
            try
            {
                _spriteRenderer.RenderSprite();
            }catch
            {
                System.Console.WriteLine("Спрайт не найден");
            }
        }
    }
}
