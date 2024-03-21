using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class CostumesFactory
    {
        private Dictionary<string, ICostume> _costumes = new Dictionary<string, ICostume>();

        public ICostume GetCostume(string costumeType)
        {
            if (!_costumes.ContainsKey(costumeType))
            {
                _costumes[costumeType] = new Costumes(costumeType);
            }
            return _costumes[costumeType];
        }
    }
}
