﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor
{
    class Unit
    {
        protected double hp_Unit = 100; /*Здоровье юнита*/
        protected double mp_Unit = 100; /*Манакост юнита*/
        protected double strenght = 20; /*Сила юнита*/
        protected double dexterity = 20;   /*Ловкость юнита*/
        protected double intelegence = 20; /*Интеллект юнита */
        protected double constitution = 20; /*Телосложение юнита*/
        protected double extra = 20;  /*Ограничение по способностям*/
        protected double attackSpeed; /*Это Атакспид*/
        protected double phusical_Attack = 20;
        protected double running_Speed = 20;
        protected double magic_Attack = 20;
        protected double magic_Defence = 20;
        protected double phisical_Defence = 20;
        protected double woolding_Speed = 20;
        public double Strenght { get => strenght; set => strenght = value; }
        public double Dexterity { get => dexterity; set => dexterity = value; }
        public double Intelegence { get => intelegence; set => intelegence = value; }
        public double Constitution { get => constitution; set => constitution = value; }
        public double HP_Unit { get => hp_Unit; set => hp_Unit = value; }
        public double MP_Unit { get => mp_Unit; set => mp_Unit = value; }

        public double Extra { get => extra; set => extra = value; }
    }
}
