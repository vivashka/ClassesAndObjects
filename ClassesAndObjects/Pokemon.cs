﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Pokemon
    {
        short attack;
        short defense;
        short stamina;
        public static int count;
        public Pokemon()
        {
            Attack = 17;
            Defence = 32;
            Stamina = 1;
            count++;
        }
        
        public Pokemon(short atk = 0, short def = 0, short stm = 0)
        {
            Attack = atk;
            Defence = def;
            Stamina = stm;
            count++;
        }

        public Pokemon(Pokemon p)
        {
            Attack = p.Attack;
            Defence = p.Defence;
            Stamina = p.Stamina;
            count++;
        }

        public short Attack
        {
            get => attack;
            set
            {
                if (value < 17 || value > 414)
                {
                    Console.WriteLine("Урон не может быть больше 414 или меньше 17\n");
                }
                else
                {
                    attack = value;
                }
            }
        }
        public short Defence
        {
            get { return defense; }
            set
            {
                if (value < 32 || value > 396)
                {
                    Console.WriteLine("Защита не может быть больше 396 или меньше 32\n");
                }
                else
                {
                    defense = value;
                }
            }
        }

        public short Stamina
        {
            get => stamina;
            set
            {
                if (value < 1 || value > 496)
                {
                    Console.WriteLine("Защита не может быть больше 496 или меньше 1\n");
                }
                else
                {
                    stamina = value;
                }
            }
        }
        public Pokemon LevelUp(short atk = 0, short def = 0, short stm = 0)
        {
            Attack += atk;
            Defence += def;
            Stamina += stm;
            return this;
        }

        public static Pokemon SLevelUp(Pokemon p, short atk = 0, short def = 0, short stm = 0)
        {
            p.Attack += atk;
            p.Defence += def;
            p.Stamina += stm;
            return p;
        }

        public void Show()
        {
            Console.WriteLine($"Характеристики покемона\n"+
                                $"Урон - {Attack}\n" +
                                $"Защита - {Defence}\n" +
                                $"Выносливость - {Stamina}\n");
        }
    }
}
