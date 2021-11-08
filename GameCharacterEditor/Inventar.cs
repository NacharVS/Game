using System;
using System.Collections.Generic;

namespace GameCharacterEditor
{
    class Inventar
    {
        private List<Item> allItems = new List<Item>() { };
        //private List<Item> existItem = new List<Item>();
        public List<Item> AllItems { get => allItems; }
        //public List<Item> ExistItem { get => existItem; }
        public BodyArmor bodyArmor;
        public Helmet helmet;
        public Weapon weapon;

        public void Add(string name, Unit unit)
        {
            if (name == "Robe")
            {
                if (unit.Intelegence > 20 && unit.Lvl > 1 && CheckExistItems("Robe"))
                    bodyArmor = new Robe(unit);
                else if (CheckExistItems("Robe") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "Leather")
            {
                if (unit.Strength > 50 && unit.Dexterity > 50 && unit.Lvl > 4 && CheckExistItems("Leather"))
                    bodyArmor = new Leather(unit);
                else if (CheckExistItems("Leather") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "Hecoy")
            {
                if (unit.Strength > 250 && unit.Constitution > 100 && unit.Lvl > 7 && CheckExistItems("Hecoy"))
                    bodyArmor = new Hecoy();
                else if (CheckExistItems("Hecoy") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "RobeHelmet")
            {
                if (unit.Intelegence > 20 && unit.Lvl > 1 && CheckExistItems("RobeHelmet"))
                    helmet = new RobeHelmet();
                else if (CheckExistItems("RobeHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "LeatherHelmet")
            {
                if (unit.Strength > 50 && unit.Constitution > 30 && unit.Lvl > 4 && CheckExistItems("LeatherHelmet"))
                    helmet = new LeatherHelmet();
                else if (CheckExistItems("LeatherHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "HoceyHelmet")
            {
                if (unit.Strength > 250 && unit.Constitution > 100 && unit.Lvl > 7 && CheckExistItems("HoceyHelmet"))
                    helmet = new HoceyHelmet();
                else if (CheckExistItems("HoceyHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "One Handed Sword")
            {
                if (unit.Strength > 10 && unit.Constitution > 10 && unit.Lvl > 0 && CheckExistItems("Sword"))
                    weapon = new Sword(0, unit);
                else if (CheckExistItems("HoceyHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "Two Handed Sword")
            {
                if (unit.Strength > 10 && unit.Constitution > 10 && unit.Lvl > 0 && CheckExistItems("HoceyHelmet"))
                    weapon = new Sword(1, unit);
                else if (CheckExistItems("HoceyHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }

            else if (name == "Axe")
            {
                if (unit.Strength > 10 && unit.Constitution > 10 && unit.Lvl > 0 && CheckExistItems("HoceyHelmet"))
                    weapon = new Axe(unit);
                else if (CheckExistItems("HoceyHelmet") == false)
                    throw new Exception("Такой элемент уже есть в инвентаре");
                else
                    throw new Exception("Не хватает статов");
            }
        }

        private bool CheckExistItems(string itemName)
        {
            //foreach (var item in existItem)
            //{
            //    if (item.ToString().Substring(20) == itemName)
            //        return false;
            //}
            return true;
        }

        public void Delete(int index)
        {
            //try
            //{
            //    existItem.Remove(existItem[index]);
            //}
            //catch
            //{
            //    throw new Exception("Невозможно удалить");
            //}
        }
    }
}