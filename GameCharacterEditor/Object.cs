using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCharacterEditor;

namespace GameCharacterEditor
{
    public class Object
    {
        public string nameObject { get; protected set; }
        public string Health { get; protected set; }
        public string Rassa { get; protected set; }

        public Object(string nameObj, string health, string rassa)
        {
            nameObject = nameObj;
            Health = health;
            Rassa = rassa;
        }
    }

    public class Person : Object
    {
        public string Health { get; protected set; }
        public string Rassa { get; protected set; }
        public string ResistMagic { get; protected set; } = "";
        public string Lov { get; protected set; }
        public string Intelect { get; protected set; }
        public int Strench { get; protected set; }


        public Person(string nameObj, string health, string rassa, string resistMagic, string lov, string intelect, int strench) : base(nameObj, health, rassa)
        {
            Health = health;
            Rassa = rassa;
            ResistMagic = resistMagic;
            Lov = lov;
            Intelect = intelect;
            Strench = strench;

        }
        public Person(string nameObj, string health, string rassa, string resistMagic, string lov, string intelect) : base(nameObj, health, rassa)
        {
            Health = health;
            Rassa = rassa;
            ResistMagic = resistMagic;
            Lov = lov;
            Intelect = intelect;
        }

    }
    public class tableGame : Object
    {
        public string Developer { get; protected set; }
        public string GamePlay { get; protected set; }
        public string valuePeople { get; protected set; }

        public tableGame(string nameObj, string health, string rassa, string developer, string gameplay, string valuepeople) : base(nameObj, health, rassa)
        {
            Developer = developer;
            GamePlay = gameplay;
            string valuePeople = valuepeople;
        }
    }
}

