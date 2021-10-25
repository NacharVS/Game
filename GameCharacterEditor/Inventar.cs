using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Inventar
    {
        private List<Item> allItems = new List<Item>();
        private List<Item> existItem = new List<Item>();
        public List<Item> AllItems { get => allItems; }
        public List<Item> ExistItem { get => existItem; }

        public void Add(int index, double strength, double dexterity, double constitution, double intelegence, int lvl)
        {
            //string a = allItems[index].ToString().Substring(20);
            if (index == 0)
            {
                if (intelegence > 70 && lvl > 2)
                    existItem.Add(new Robe());
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 1)
            {
                if (strength > 110 && dexterity > 150 && lvl > 4)
                    existItem.Add(new Leather());
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 2)
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(new Hecoy());
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 3)
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(new RobeHelmet());
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 4)
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(new LeatherHelmet());
                else
                    throw new Exception("Не хватает статов");
            }

            else if (index == 5)
            {
                if (strength > 250 && constitution > 300 && lvl > 7)
                    existItem.Add(new HoceyHelmet());
                else
                    throw new Exception("Не хватает статов");
            }
        }

        public void Delete(int index)
        {
            existItem.Remove(existItem[index]);
        }

        public void FillAllItemsList()
        {
            allItems.Add(new Robe());
            allItems.Add(new Hecoy());
            allItems.Add(new Leather());
            allItems.Add(new RobeHelmet());
            allItems.Add(new HoceyHelmet());
            allItems.Add(new LeatherHelmet());
        }
    }
}