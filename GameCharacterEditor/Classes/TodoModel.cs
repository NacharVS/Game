using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacterEditor.Models
{
    class TodoModel
    {
        private int _ID;
        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;

            }
        }

        private string _character;
        public string Character
        {
            get => _character;
            set
            {
                _character = value;

            }
        }

        private int _HP;
        public int HP
        {
            get => _HP;
            set
            {
                _HP = value;

            }
        }

        private int _MP;
        public int MP
        {
            get => _MP;
            set
            {
                _MP = value;

            }
        }

        private int _strenght;
        public int Strenght
        {
            get => _strenght;
            set
            {
                _strenght = value;

            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get => _dexterity;
            set
            {
                _dexterity = value;

            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get => _intelligence;
            set
            {
                _intelligence = value;

            }
        }

        private int _constitution;
        public int Constitution
        {
            get => _constitution;
            set
            {
                _constitution = value;

            }
        }

        private int _pAttack;
        public int PAttack
        {
            get => _pAttack;
            set
            {
                _pAttack = value;

            }
        }

        private int _mAttack;
        public int MAttack
        {
            get => _mAttack;
            set
            {
                _mAttack = value;

            }
        }

        private int _pResist;
        public int PResist
        {
            get => _pResist;
            set
            {
                _pResist = value;

            }
        }

        private int _mResist;
        public int MResist
        {
            get => _mResist;
            set
            {
                _mResist = value;

            }
        }

        private int _aSpeed;
        public int ASpeed
        {
            get => _aSpeed;
            set
            {
                _aSpeed = value;

            }
        }

        private int _mSpeed;
        public int MSpeed
        {
            get => _mSpeed;
            set
            {
                _mSpeed = value;

            }
        }
    }
}
