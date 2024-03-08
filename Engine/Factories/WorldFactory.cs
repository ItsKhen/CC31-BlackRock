using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0,
                "Underway",
                "Y", 
                "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg");

            newWorld.AddLocation(1, 0,
                "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");
            newWorld.AddLocation(1, 1,
                 "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/TearfullTavern.png");
            newWorld.AddLocation(1, -1,
               "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg");
            newWorld.AddLocation(2, 0,
              "Underway",
                 "Underway",
               "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");
            newWorld.AddLocation(2, 1,
               "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");
            newWorld.AddLocation(2, -1,
               "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/TearfullTavern.png");
            newWorld.AddLocation(3, 0,
               "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/GatesOfAsea.jpg");
            newWorld.AddLocation(1, 2,
               "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/HellionPlaza.png");
            newWorld.AddLocation(4, 0,
                "Underway",
                 "Underway",
                "pack://application:,,,/Engine;component/Images/Locations/TearfullTavern.png");


            return newWorld;
        }
    }
}
