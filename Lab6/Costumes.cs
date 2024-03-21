using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Costumes : ICostume
    {
        private string _costume;
        public Costumes(string costume)
        {
            _costume = costume;
        }

        // Show what costumes actors are wearing
        public void WearCostumes()
        {
            Console.WriteLine($"Wearing {_costume} costume");
        }
    }
}
