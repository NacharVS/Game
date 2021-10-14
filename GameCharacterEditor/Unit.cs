using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Unit
    {
        protected double Hp_Unit = 100; /*Здоровье юнита*/
        protected double Mp_Unit = 100; /*Манакост юнита*/
        protected double strenght = 20; /*Сила юнита*/
        protected double dexterity = 20;   /*Ловкость юнита*/
        protected double intelegence = 20; /*Интеллект юнита */
        protected double constitution = 20; /*Телосложение юнита*/
        protected double Extra = 150;  /*Ограничение по способностям*/
        protected double AttackSpeed; /*Это Атакспид*/
        protected double Phusical_Attack = 20;
        protected double Running_Speed = 20;
        protected double Magic_Attack = 20;
        protected double Magic_Defence = 20;
        protected double Phisical_Defence = 20;
        protected double Woolding_Speed = 20;
        public double Strenght { get => strenght; set => strenght = value; }
        public double Dexterity { get => dexterity; set => dexterity = value; }
        public double Intelegence { get => intelegence; set => intelegence = value; }
        public double Constitution { get => constitution; set => constitution = value; }
        public double HP_Unit { get => Hp_Unit; set => Hp_Unit = value; }
        public double MP_Unit { get => Mp_Unit; set => Mp_Unit = value; }

    }
}
