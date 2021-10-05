using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_C__week_3_1490359396.Interfaces;
using DZ_C__week_3_1490359396.Classes.Parts;

using LoggerLib;
using LoggerLib.Events;

namespace DZ_C__week_3_1490359396.Classes.Workers
{
    class Worker : IWorker
    {
        void IWorker.Work(ref IBuilding buildingToBuild) // Работник строит часть дома
        {
            
            IPart nextPart = FindNextPartToBuild(buildingToBuild); // Часть, которую работник должен построить
            if(nextPart != null)
                nextPart.Build();
            else
            {
                nextPart = FindNextPartToBuild(buildingToBuild);
                if (nextPart == null)
                    return;
                nextPart.Build();
            }
            Logger.AddEvent(new InformationEvent($"Worker завершил работу"));
        }

        IPart FindNextPartToBuild(IBuilding building)
        {
            foreach (var buildingsPart in building.GetParts())
            {
                if (buildingsPart.IsBuilt() == false)
                {
                    if (buildingsPart is IBuilding)
                        return FindNextPartToBuild(buildingsPart as IBuilding);
                    return buildingsPart;
                }
            }
            if (building is IBuilding)
            {
                IPart compositePartAsPart = building as IPart;
                compositePartAsPart.Build();
            }
            return null;
        }
    }
}
