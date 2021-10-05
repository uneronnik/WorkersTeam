using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Classes;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Buildings;

using LoggerLib;
using LoggerLib.Events;

namespace DZ_C__week_3_1490359396
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.AddEvent(new InformationEvent("Программа была запущена"));
            try
            {
                Team team = null;
                House house = new House(4, 1, 4);
                Logger.AddEvent(new InformationEvent("1 дом создан"));

                List<House> houses = new List<House>();
                houses.Add(new House(4, 2, 5));
                houses.Add(new House(4, 1, 2));
                Logger.AddEvent(new InformationEvent("2 дома создано"));

                List<Tower> towers = new List<Tower>();
                for (int i = 0; i < 4; i++)
                    towers.Add(new Tower(i));
                Logger.AddEvent(new InformationEvent("башни созданы"));

                Castle castle = new Castle(8, 1, 12, towers);
                Logger.AddEvent(new InformationEvent("замок создан"));

                IBuilding building = new Town(castle, houses);
                Logger.AddEvent(new InformationEvent("город создан"));

                team = new Team(4); // Если работников меньше 1 вызовится исключение
                Logger.AddEvent(new InformationEvent("команда создана"));

                team.BuildBuilding(ref building);

                Console.WriteLine("Строительство постройки завершено!");
                building.Render();
                
            }
            catch (Exception e)
            {
                Logger.AddEvent(new ExeptionEvent(e.Message));
                Logger.AddEvent(new EmptyLine());
                return;
            }
            Logger.AddEvent(new InformationEvent("Программа успешно выполнилась"));
            Logger.AddEvent(new EmptyLine());
            System.Console.ReadKey();
        }
    }
}
