using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Classes;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Buildings;

using LoggerLib;
using LoggerLib.Messages;

namespace DZ_C__week_3_1490359396
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteMessage(new InformationMessage("Программа была запущена"));
            try
            {
                Team team = null;
                House house = new House(4, 1, 4);
                Logger.WriteMessage(new InformationMessage("1 дом создан"));

                List<House> houses = new List<House>();
                houses.Add(new House(4, 2, 5));
                houses.Add(new House(4, 1, 2));
                Logger.WriteMessage(new InformationMessage("2 дома создано"));

                List<Tower> towers = new List<Tower>();
                for (int i = 0; i < 4; i++)
                    towers.Add(new Tower(i));
                Logger.WriteMessage(new InformationMessage("башни созданы"));

                Castle castle = new Castle(8, 1, 12, towers);
                Logger.WriteMessage(new InformationMessage("замок создан"));

                IBuilding building = new Town(castle, houses);
                Logger.WriteMessage(new InformationMessage("город создан"));

                team = new Team(4); // Если работников меньше 1 вызовится исключение
                Logger.WriteMessage(new InformationMessage("команда создана"));

                team.BuildBuilding(ref building);

                Console.WriteLine("Строительство постройки завершено!");
                building.Render();
                int f = 0;
                int g = 5 / f;
            }
            catch (Exception e)
            {
                Logger.WriteMessage(new ExeptionMessage(e.Message));
                Logger.WriteMessage(new EmptyLine());
                return;
            }
            Logger.WriteMessage(new InformationMessage("Программа успешно выполнилась"));
            Logger.WriteMessage(new EmptyLine());
            System.Console.ReadKey();
        }
    }
}
