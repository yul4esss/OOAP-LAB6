using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Class Actor
    public class Actor
    {
        private ICostume _costume;
        private int _actorNumber;

        public Actor(int actorNumber)
        {
            _actorNumber = actorNumber;
        }

        public void SetCostume(string costumeType, CostumesFactory costumeFactory)
        {
            _costume = costumeFactory.GetCostume(costumeType);
        }

        // Display the scene that actors are playing
        public void PerformAction()
        {
            Console.WriteLine($"Actor {_actorNumber} is performing action:");
            _costume.WearCostumes();
        }
    }
}
