using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Classes;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Buildings;

namespace DZ_C__week_3_1490359396
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = null;
            House house = new House(4, 1, 4);

            List<House> houses = new List<House>();
            houses.Add(new House(4, 2, 5));
            houses.Add(new House(4, 1, 2));

            List<Tower> towers = new List<Tower>();
            for(int i = 0; i < 4; i++)
                towers.Add(new Tower(i));

            Castle castle = new Castle(8, 1, 12, towers);
            
            IBuilding building = new Town(castle, houses);
            
            try
            {
                team = new Team(4); // Если работников меньше 1 вызовится исключение
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                System.Console.ReadKey();
                return;
            }

            team.BuildBuilding(ref building);

            Console.WriteLine("Строительство постройки завершено!");
            building.Render();
            //System.Console.ReadKey();
            //System.Console.WriteLine();
            //System.Console.WriteLine();

            //building = house;
            //team.BuildBuilding(ref building);
            //building.Render();



            System.Console.ReadKey();
        }
    }
}
