using System;
using System.Threading;

namespace June
{
    public class Character
    {
        private string name { get; set; }
        private int health { get; set; }
        private int damage { get; set; }
        private int armour { get; set; }

        public Character(string Name, int Health, int Damage, int Armour)
        {
            name = Name;
            health = Health;
            damage = Damage;
            armour = Armour;
        }

        public void SetName(string Name)
        {
            name = Name;
        }

        public void SkillCustomization(int Health, int Damage, int Armour)
        {
            Console.WriteLine("Сколько будет здоровья у вашего персонажа?(100-1000)");
            Health = Console.Read();
            if (100 > Health || Health > 1000)
            {
                while (Health! > 100 || Health! < 1000)
                {
                    health = Health;
                }
            }
            Console.WriteLine("Сколько будет урона у вашего персонажа?(10-120)");
            Damage = Console.Read();
            if (10 > Damage || Damage > 120)
            {
                while (Damage! > 100 || Damage! < 1000)
                {
                    damage = Damage;
                }
            }
            Console.WriteLine("Сколько будет брони у вашего персонажа?(50-200)");
            Armour = Console.Read();
            if (50 > Armour || Armour > 200)
            {
                while (Armour! > 50 || Armour! < 200)
                {
                    armour = Armour;
                }
            }
        }

        public bool CharacterIsDead(Character pers)
        {
            if(pers.health == 0 || pers.health < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string TheFight(Character pers1, Character pers2)
        {
            string res = "Ничья!";

            pers1.health += pers1.armour;
            pers2.health += pers2.armour;

            while(CharacterIsDead(pers1) != true || CharacterIsDead(pers2) != true)
            {
                pers1.health -= pers2.damage;
                pers2.health -= pers1.damage;
                Thread.Sleep(1000);
                
            }

            if(CharacterIsDead(pers1) == true)
            {
                res = $"{pers1} выиграл сражение!";
            }
            else if(CharacterIsDead(pers2) == true)
            {
                res = $"{pers2} выиграл сражение!";
            }
            return res;
        }
    }
}
