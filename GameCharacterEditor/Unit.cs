using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Unit
    {
        public double Hp_Unit = 100; /*Здоровье юнита*/
        public double Mp_Unit = 100; /*Манакост юнита*/
        protected double strenght = 20; /*Сила юнита*/
        public double dexterity = 20;   /*Ловкость юнита*/
        public double intelegence = 20; /*Интеллект юнита */
        public double constitution = 20; /*Телосложение юнита*/
        public double Extra = 150;  /*Ограничение по способностям*/
        public double AttackSpeed; /*Это Атакспид*/
        public double Phusical_Attack = 20;
        public double Running_Speed = 20;
        public double Magic_Attack = 20;
        public double Magic_Defence = 20;
        public double Phisical_Defence = 20;
        public double Woolding_Speed = 20;
    }
}
