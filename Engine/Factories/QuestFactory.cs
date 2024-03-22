using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            // Declare the items needed for completion and reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            itemsToComplete.Add(new ItemQuantity(1003, 4));
            rewardItems.Add(new ItemQuantity(1002, 1));

            // Create the quest
            _quests.Add(new Quest(1, "Defeat Antolin", "Get Branch in the Forest",
                itemsToComplete, 25, 10, rewardItems));
        }

        internal static Quest GetQuestByID(int questID)
        {
            return _quests.FirstOrDefault(q => q.ID == questID);
        }
    }
}
