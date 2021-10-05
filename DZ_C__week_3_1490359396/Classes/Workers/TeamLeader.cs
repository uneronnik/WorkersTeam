using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Parts;

using LoggerLib;
using LoggerLib.Messages;

namespace DZ_C__week_3_1490359396.Classes.Workers
{

    class TeamLeader : IWorker
    {
        void IWorker.Work(ref IBuilding buildingToBuild) // Бригадир смотрит какую часть постройки построили
        {
            int numberOfBuiltParts = FindNumberOfBuiltPartsInBuilding(buildingToBuild); // Количество построенных частей
            int numberOfParts = FindNumberOfPartsInBuilding(buildingToBuild);

            int percentOfBuiltParts = (int)(numberOfBuiltParts / (double)numberOfParts * 100);
            Console.WriteLine($"Постройка завершена на {percentOfBuiltParts}%");
            Logger.WriteMessage(new InformationMessage($"Team Leader завершил работу"));
            Logger.WriteMessage(new InformationMessage($"Постройка завершена на { percentOfBuiltParts }%"));
        }
        int FindNumberOfBuiltPartsInBuilding(IBuilding building)
        {
            int numberOfBuiltParts = 0;
            foreach (var buildingsPart in building.GetParts())
            {
                if (buildingsPart is Building)
                    numberOfBuiltParts += FindNumberOfBuiltPartsInBuilding(buildingsPart as IBuilding);
                else if (buildingsPart.IsBuilt())
                    numberOfBuiltParts += 1;
            }
            return numberOfBuiltParts;
        }
        int FindNumberOfPartsInBuilding(IBuilding building)
        {
            int numberOfParts = 0;
            foreach (var buildingsPart in building.GetParts())
            {
                if (buildingsPart is Building)
                    numberOfParts += FindNumberOfPartsInBuilding(buildingsPart as IBuilding);
                else
                    numberOfParts += 1;
            }
            return numberOfParts;
        }
    }
}
