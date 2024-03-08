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
 "SafeHouse",
   "Y",
   "pack://application:,,,/Engine;component/Image/SafeHouse.png");

newWorld.AddLocation(-1, 0,
    "Khenert's Arch",
     "Underway",
    "pack://application:,,,/Engine;component/Image/Khenert's Arch.png");
newWorld.AddLocation(0, -1,
     "Jc Village",
     "Underway",
    "pack://application:,,,/Engine;component/Image/JCVillage.png");
newWorld.AddLocation(1, -1,
   "Bandit's Wood",
     "Bandit's Wood",
    "pack://application:,,,/Engine;component/Image/BanditWood.png");
newWorld.AddLocation(2, -1,
  "Tower of Chosen",
     "Tower of Chosen",
  "pack://application:,,,/Engine;component/Image/Tower.png");
newWorld.AddLocation(-1, -1,
   "8 Mile",
     "Underway",
    "pack://application:,,,/Engine;component/Image/8Mile.png");
newWorld.AddLocation(-1, -2,
   "GangBoss Hideout",
     "Underway",
    "pack://application:,,,/Engine;component/Image/GangBoss.png");
newWorld.AddLocation(-1, -3,
   "Antolin Den",
     "Underway",
    "pack://application:,,,/Engine;component/Image/AntolinDen.png");
newWorld.AddLocation(0, -3,
   "Mecha Stash",
     "Underway",
    "pack://application:,,,/Engine;component/Image/BossMecha.png");
newWorld.AddLocation(1, -3,
    "Exit Point",
     "Underway",
    "pack://application:,,,/Engine;component/Image/Exit.png");

            return newWorld;
        }
    }
}
