using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Pokemon
    {
        short attack;
        short defense;
        short stamina;
        static int count;
        public Pokemon()
        {
            Attack = 17;
            Defence = 32;
            Stamina = 1;
            Count++;
        }
        
        public Pokemon(short atk = 17, short def = 32, short stm = 1)
        {
            Attack = atk;
            Defence = def;
            Stamina = stm;
            Count++;
        }

        public Pokemon(Pokemon p)
        {
            Attack = p.Attack;
            Defence = p.Defence;
            Stamina = p.Stamina;
            Count++;
        }
        public int Count
        {
            get => count;
            set => count = value;
        }
        public short Attack
        {
            get => attack;
            set
            {
                try
                {
                    attack = value;
                    if (value < 17 || value > 414)
                    {
                        
                        throw new Exception("Атака превышает допустимые значение от 17 до 414");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка диапазона - {e.Message}");
                    attack = 17;
                }
            }
        }
        public short Defence
        {
            get { return defense; }
            set
            {
                try
                {
                    defense = value;
                    if (value < 32 || value > 396)
                    {
                        throw new Exception("Защита превышает допустимые значения от 32 до 396");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка диапазона - {e.Message}");
                    defense = 32;
                }
            }
        }

        public short Stamina
        {
            get => stamina;
            set
            {
                try
                {
                    stamina = value;
                    if (value < 1 || value > 496)
                    {
                        throw new Exception("Выносливость превышает допустимые значение от 1 до 496");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка диапазона - {e.Message}");
                    stamina = 1;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is not Pokemon pokemon) return false;
            return Stamina == pokemon.Stamina && Defence == pokemon.Defence && Attack == pokemon.Attack;
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

        public static float operator ~(Pokemon p)
        {
            double power = (Math.Sqrt((p.Stamina))*p.Attack* Math.Sqrt((p.Defence)))/10;
            return (float)Math.Round(power, 2);
        }

        //оператор не должен менять значения своих параметров
        public static Pokemon operator --(Pokemon p)
        {
            return new Pokemon { Stamina = (short)(p.Stamina - 1) };
        }

        public override string ToString()
        {
            return $"\nХарактеристики покемона\nУрон - {Attack}\nЗащита - {Defence}\nВыносливость - {Stamina}\n";
        }

        //Операции приведение типа 
        //Явное
        public static explicit operator int(Pokemon p)
        {
            return p.Stamina+p.Attack+p.Defence;
        }
        //Неявное
        public static implicit operator double(Pokemon p)
        {
            return Math.Round(((double)(p.Stamina + p.Attack + p.Defence) / 3), 2);
        }

        //Бинарные операции
        public static Pokemon operator >>(Pokemon p, short stm)
        => new Pokemon { Stamina = (short)(p.Stamina + stm) };

        public static Pokemon operator >(Pokemon p, short def)
            => new Pokemon { Defence = (short)(p.Defence + def) };
            
        public static Pokemon operator <(Pokemon p, short atk)
        => new Pokemon { Attack = (short)(p.Attack + atk) };
    }
}

