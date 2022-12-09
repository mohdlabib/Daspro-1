using System;

namespace _7
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to My Adventure Game");
            Console.WriteLine("What is your name?");

            Beginner Player = new Beginner();
            Player.Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Hi {Player.Name}, Ready to begin the game? [yes/no]");
            
            string play = Console.ReadLine();
            if(play == "yes")
            {
                Console.WriteLine($"\n{Player.Name} is entering the World...");

                Enemy Enemy = new Enemy("Minion");

                Console.WriteLine($"{Player.Name} was exploring the world");
                Console.WriteLine($"{Player.Name} found a monster {Enemy.Name}");

                Console.WriteLine($"{Enemy.Name} is attacking you...");

                while (!Player.Dead && !Enemy.Dead)
                {

                    Console.WriteLine("\nChoose your action :");
                    Console.WriteLine("1. Single Attack");
                    Console.WriteLine("2. Swing Attack");
                    Console.WriteLine("3. Defend");
                    Console.WriteLine("4. Run Away");

                    string PlayerAction = Console.ReadLine(); 
                    Console.WriteLine();

                    switch (PlayerAction)
                    {
                        case "1" :
                            Console.WriteLine($"{Player.Name} is doing single attack.. ");
                            Enemy.Attack(Enemy.AttackPower);  

                            Player.Experience += 0.3f;
                            Player.GetHit(Enemy.AttackPower);
                            Enemy.GetHit(Player.AttackPower);

                            Player.Experience += 0.3f;
                            Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {Enemy.Health}");
                            Console.WriteLine($"Your energy skill is : {Player.SkillSlot}");
                        break;

                        case "2" :
                            Player.Swing();   

                            Enemy.Attack(Enemy.AttackPower);
                            Player.GetHit(Enemy.AttackPower);
                            Enemy.GetHit(Player.AttackPower);

                            Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {Enemy.Health}");
                            Console.WriteLine($"Your energy skill is : {Player.SkillSlot}");
                        break;

                        case "3" :
                            Player.Rest();

                            Console.WriteLine("Energy is being restored..");
                            Enemy.Attack(Enemy.AttackPower);
                            Player.GetHit(Enemy.AttackPower);

                            Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {Enemy.Health}");
                            Console.WriteLine($"Your energy skill is : {Player.SkillSlot}");
                        break;

                        default:
                            Console.WriteLine($"{Player.Name} is Running away...");
                        break;
                    }
                    
                }

                Console.WriteLine($"You get {Player.Experience} experience point from kill {Enemy.Name}");
                Console.ReadLine();
                Console.Clear();
                

            }
            
            Console.WriteLine("GoodByee!!");
            
        }
    }

    class Beginner
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool Dead { get; set; }
        public float Experience { get; set; }
        Random random = new Random();

        public Beginner()
        {
            Health = 100;
            AttackPower = 1;
            SkillSlot = 0;
            Experience = 0f;

        }
        
        public void Swing()
        {
            if(SkillSlot > 0){
                Console.WriteLine("SWIINGGG!!");
                AttackPower = AttackPower + random.Next(3,8);
                Experience += 0.5f;
                SkillSlot--;

            }else{
                
                Console.WriteLine("You dont have enough energy!");
            }
            
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine($"{Name} Get hit by {HitValue}");
            Health = Health - HitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.Clear();
            Console.WriteLine("You Are dead.. Game overr..");
            Dead = true;
        }

    }
    
    class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool Dead { get; set; }
        Random random = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;

        }
        
        public void Attack(int damage)
        {
            AttackPower = random.Next(2,8);
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine($"{Name} Get hit by {HitValue}");
            Health = Health - HitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine($"{Name} is Dead");
            Dead = true;
        }

    }
}
