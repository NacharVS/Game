using GameCharacterEditor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Classes
{
    public class Logic
    {
        public static int AttackLogic(int attackType, int dependentAtribute)
        {
            attackType = dependentAtribute * 5;
            return attackType;
        }

        public static int ResistLogic(int resistType, int dependentAtribute)
        {
            resistType = dependentAtribute * 2;
            return resistType;
        }

        public static int LevelLogic(int extraPoints, int yourLevel)
        {
            extraPoints = yourLevel * 5;
            return extraPoints;
        }

        public static int LevelUpLogic(int yourExperience)
        {
            return yourExperience;
        }
    }
}
