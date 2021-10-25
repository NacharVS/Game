using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCore.Class;

namespace HeroFabric
{
    public class HeroMakerDefult
    {
        List<HeroClass> heroClassesLst;
        Dictionary<string, HeroClass> heroClassesDictionary;

        public HeroMakerDefult()
        {
            heroClassesLst = new List<HeroClass>()
            {
                new Warrior ("NameWarrior"),
                new Mage ("NameMage"),
                new Rogue ("Name Rogue")
            };

            heroClassesDictionary = new Dictionary<string, HeroClass>()
            {
                {"Warrior", heroClassesLst[0]},
                {"Mage", heroClassesLst[1]},
                {"Rogue", heroClassesLst[2]}
            };
        }

        public List<HeroClass> GetListHero()
        {
            return heroClassesLst;
        }

        public Dictionary<string, HeroClass> GetDictionaryHero()
        {
            return heroClassesDictionary;
        }

        public List<HeroClass> GetWarriorLst()
        {
            List<HeroClass> warrior = new List<HeroClass>();
            foreach (var keyValue in heroClassesDictionary)
            {
                if(keyValue.Key == "Warrior")
                {
                    warrior.Add(keyValue.Value);
                }
            }
            return warrior;
        }

        public List<HeroClass> GetMageLst()
        {
            List<HeroClass> mage = new List<HeroClass>();
            foreach (var keyValue in heroClassesDictionary)
            {
                if (keyValue.Key == "Mage")
                {
                    mage.Add(keyValue.Value);
                }
            }
            return mage;
        }

        public List<HeroClass> GetRogueLst()
        {
            List<HeroClass> rogue = new List<HeroClass>();
            foreach (var keyValue in heroClassesDictionary)
            {
                if (keyValue.Key == "Rogue")
                {
                    rogue.Add(keyValue.Value);
                }
            }
            return rogue;
        }
    }
}
