using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes;
using DZ_C__week_3_1490359396.Classes.Workers;

using LoggerLib;
using LoggerLib.Messages;

namespace DZ_C__week_3_1490359396.Classes
{
    class Team
    {
        private List<IWorker> _workers = new List<IWorker>();
        public Team(int workersNumber) 
        {
            if (workersNumber < 1) // Исключение если работников меньше 1
                throw new Exception("Недостаточно работников");

            for(int i = 0; i < workersNumber; i++)
            {
                _workers.Add(new Worker());
            }

            _workers.Add(new TeamLeader());
        }

        public void BuildBuilding(ref IBuilding buildingToBuild) // Команда строит дом
        {
            while(true)
            {
                foreach(var worker in _workers) {
                    worker.Work(ref buildingToBuild); // Каждый работник выполняет свою работу
                    if (buildingToBuild.IsBuilt()) // Выходим из функции если дом построен
                        return;
                   
                }
            }
            Logger.WriteMessage(new InformationMessage($"Дом построен"));

        }
    }
}
