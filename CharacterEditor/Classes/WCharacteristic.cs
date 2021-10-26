using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.Classes
{
    class WCharacteristic
    {
        public int WStrength { get; set; }
        public int WAgility { get; set; }
        public int WIntelligence { get; set; }

        public void Warrior(int Wstrength, int Wagility, int Wintelligence)
        {
            WStrength = Wstrength;
            WAgility = Wagility;
            WIntelligence = Wintelligence;
        }

        public virtual void Info()
        {
            Console.WriteLine("Warrior Strange" + WStrength);
            Console.WriteLine("Warrior Agility" + WAgility);
            Console.WriteLine("Warrior Intelligence" + WIntelligence);
        }

        public virtual void WCreate(WCharacteristic wCharacteristic)
        {
            if(wCharacteristic.WStrength + wCharacteristic.WAgility < wCharacteristic.WIntelligence)
            {
                wCharacteristic.WStrength = 30;
                wCharacteristic.WAgility = 20;
                wCharacteristic.WIntelligence = 10;
                Console.WriteLine("Warrior Create");
                wCharacteristic.Info();
            }
        }
    }
}
