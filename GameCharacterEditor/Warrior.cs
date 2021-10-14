using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Warrior : Hero
    {
        public static double str;
        public static double dox;
        public static double intel;
        public static double consti;
        public static string nam;
        public Warrior() : base(250, 70, 50, 100, "Warrior")
        {
            strength = 250;
            doxterity = 70;
            intelegence = 50;
            constitution = 100;
            name = "Warrior";
        }
    }
}
