using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Items
{
    public class PotionMana : GameItem
    {
        private int manaBonus;

        public int BuffMana()
        {
            return manaBonus;
        }

        public PotionMana(string name, int price, int manaBonus) : base(name, price)
        {
            this.manaBonus = manaBonus;
        }

        public PotionMana(string name, int price, string descriptionMain, string descriptionAdditional, int manaBonus) : base(name, price, descriptionMain, descriptionAdditional)
        {
            this.manaBonus = manaBonus;
        }
    }
}
