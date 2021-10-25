using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Items
{
    public class PotionHP : GameItem
    {
        private int hpBonus;

        public int BuffHP()
        {
            return hpBonus;
        }

        public PotionHP(string name, int price, int hpBonus) : base(name, price)
        {
            this.hpBonus = hpBonus;
        }

        public PotionHP(string name, int price, string descriptionMain, string descriptionAdditional, int hpBonus) : base(name, price, descriptionMain, descriptionAdditional)
        {
            this.hpBonus = hpBonus;
        }    
    }
}
