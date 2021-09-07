using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C__week_3_1490359396.Classes
{
    class Sprite
    {
        private string[] _lines;

        public Sprite(string path = null)
        {
            SetSprite(path);
        }

        public string[] Lines { get => _lines; }

        public void SetSprite(string path)
        {
            if (path == null)
            {
                _lines = null;
                return;
            }
            string currentDirectory = Directory.GetCurrentDirectory();
            string spriteAbsPath = Path.GetFullPath(currentDirectory + "\\.." + "\\..");
            spriteAbsPath += "\\" + path; //Абсолютный путь к спрайту
            try
            {
                _lines = System.IO.File.ReadAllLines(spriteAbsPath); // Чтение всех строк со спрайта
            }
            catch (Exception e)// Если нет файла с таким путём
            {
                throw e;
            }
        }
        public void SetSprite(Sprite sprite)
        {
            _lines = sprite.Lines;
        }
    }
}
