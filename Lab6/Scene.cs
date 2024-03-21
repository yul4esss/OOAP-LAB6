using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Creating Scene class to display actors' actions
    public class Scene
    {
        private readonly List<Actor> _actors = new List<Actor>();

        public void AddActor(Actor actor)
        {
            _actors.Add(actor);
        }

        public void SetCostume(string costumeType, CostumesFactory costumeFactory)
        {
            foreach (var actor in _actors)
            {
                actor.SetCostume(costumeType, costumeFactory);
            }
        }

        public void PerformScene()
        {
            foreach (var actor in _actors)
            {
                actor.PerformAction();
            }
        }
    }
}
