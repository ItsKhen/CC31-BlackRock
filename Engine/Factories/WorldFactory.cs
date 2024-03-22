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

newWorld.AddLocation(0, 0,"SafeHouse",
   "This is your safe place",
   "pack://application:,,,/Engine;component/Image/Locations/SafeHouse.png");

newWorld.AddLocation(-1, 0,
    "Khenert's Arch",
     "A place for trading",
    "pack://application:,,,/Engine;component/Image/Locations/Khenert's Arch.png");
newWorld.AddLocation(0, -1,
     "Jc Village",
     "A place for trading goods!",
    "pack://application:,,,/Engine;component/Image/Locations/JCVillage.png");
newWorld.AddLocation(1, -1,
   "Bandit's Wood",
     "Careful! There are enemies",
    "pack://application:,,,/Engine;component/Image/Locations/BanditsWood.png");
newWorld.AddLocation(2, -1,
  "Tower of Chosen",
     "Climb up the tower and fight!",
  "pack://application:,,,/Engine;component/Image/Locations/TowerOfChosen.png");
newWorld.AddLocation(-1, -1,
   "8 Mile",
     "Gangster's!",
    "pack://application:,,,/Engine;component/Image/Locations/8Mile.png");
newWorld.AddLocation(-1, -2,
   "GangBoss Hideout",
     "Their Boss is here get ready to fight",
    "pack://application:,,,/Engine;component/Image/Locations/GangstaBoss.png");
newWorld.AddLocation(-1, -3,
   "Antolin Den",
     "A SCARY BIG ANTOLIN!!",
    "pack://application:,,,/Engine;component/Image/Locations/AntolinsDen.png");
newWorld.AddLocation(0, -3,
   "Mecha Stash",
     "An enemy bountiful of loots!",
    "pack://application:,,,/Engine;component/Image/Locations/BossMecha.png");
newWorld.AddLocation(1, -3,
    "Exit Point",
     "Underway",
    "pack://application:,,,/Engine;component/Image/Locations/ExitPoint.png");

            return newWorld;
        }
    }
}
