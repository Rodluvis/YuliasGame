using System;

namespace YuliasGame
{
    class Game
    {
        Player player = new Player();
        private Random random = new Random();

        public Game()
        {

        }
        public void startGame()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Welcome to the Game");
            Console.WriteLine("====================");
            Console.WriteLine("Choose your alias:");

            string name = Console.ReadLine();
            CreatePlayer(name);
            GameMenu();
        }

        private void CreatePlayer(string name)
        {
            player = new Player { Name = name, Health = 100, MaxHealth = 100, Level = 1, Enduarance = 20, Experience = 0, Strength = 50 };
        }

        private void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do next?");
            Console.WriteLine("1. Go adventuring!");
            Console.WriteLine($"2. See {player.Name}'s current profile.");
            Console.WriteLine("3. Visit marketplace.");
            Console.WriteLine("4. Exit game.");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    GoAdventuring();
                    break;
                case 2:
                    ShowStats();
                    break;
                case 3:
                    MarketPlace();
                    break;
                case 4:
                    Exit();
                    break;
            }
        }
        private void Exit()
        {
         
            Console.WriteLine("Thank you for your good game! See ya!");
            Environment.Exit(0);

        }
        private void ShowStats()
        {
            player.Describe();
            Utilities.Next();
            GameMenu();
        }
        private void MarketPlace()
        {
            Console.WriteLine("Marketplace will be availbale soon...");
            Utilities.Next();
            GameMenu();
        }
        private void GoAdventuring()
        {
            Monster monster = new Monster();
            Console.Clear();

            int chanceToBattle = random.Next(0, 101);
            if (chanceToBattle <= 10)
            {
                Console.WriteLine("All is quiet, there is nothing, keep moving");
                Utilities.Next();
                GameMenu();
            }
            else
            {
                Battle(monster);
            }
        }
        private void Battle(Monster monster)
        {
            Console.WriteLine($"Watch out! A wild {monster.Name} is charging at you!");

            while (player.Health > 0 && monster.Health > 0)
            {
                if (player.Level >= 1 && player.Level <= 3)
                {
                    int playerStrength = random.Next(10, player.Strength + 1);
                    monster.TakeDamage(playerStrength);
                    Console.WriteLine($"You hit {monster.Name} dealing {playerStrength} damage!");
                    Console.WriteLine($"{monster.Name}'s hp is now: {monster.Health}");
                    if (monster.Health <= 0)
                    {
                        monster.Health = 0;
                        Console.WriteLine("Monster is dead!");
                        break;
                    }

                    int monsterdmg = monster.Strength;
                    Console.WriteLine("");
                    Console.WriteLine($"The monster hit you with {monsterdmg}");
                    player.TakeDamage(monsterdmg);
                    if (player.Health <= 0)
                    {
                        player.Health = 0;
                        Console.WriteLine($"{monster.Name} killed you... ");
                        Exit();
                    }
                    Console.WriteLine($"Your current hp is: {player.Health}");

                }
                if (player.Level >= 4 && player.Level <= 7)
                {
                    int playerStrength = random.Next(10, player.Strength + 1) * 2;
                    monster.TakeDamage(playerStrength);
                    Console.WriteLine($"You hit {monster.Name} dealing {playerStrength} damage!");
                    Console.WriteLine($"{monster.Name}'s hp is now: {monster.Health}");
                    if (monster.Health <= 0)
                    {
                        monster.Health = 0;
                        Console.WriteLine("Monster is dead!");
                        break;
                    }

                    int monsterdmg = (monster.Strength * 2);
                    Console.WriteLine("");
                    Console.WriteLine($"The monster hit you with {monsterdmg}");
                    player.TakeDamage(monsterdmg);
                    if (player.Health <= 0)
                    {
                        player.Health = 0;
                        Console.WriteLine($"{monster.Name} killed you... ");
                        Exit();
                    }
                    Console.WriteLine($"Your current hp is: {player.Health}");

                }
                if (player.Level == 8 | player.Level == 9)
                {
                    int playerStrength = random.Next(10, player.Strength + 1) * 3;
                    monster.TakeDamage(playerStrength);
                    Console.WriteLine($"You hit {monster.Name} dealing {playerStrength} damage!");
                    Console.WriteLine($"{monster.Name}'s hp is now: {monster.Health}");
                    if (monster.Health <= 0)
                    {
                        monster.Health = 0;
                        Console.WriteLine("Monster is dead!");
                        break;
                    }

                    int monsterdmg = (monster.Strength * 3);
                    Console.WriteLine("");
                    Console.WriteLine($"The monster hit you with {monsterdmg}");
                    player.TakeDamage(monsterdmg);
                    if (player.Health <= 0)
                    {
                        player.Health = 0;
                        Console.WriteLine($"{monster.Name} killed you... ");
                        Exit();
                    }
                    Console.WriteLine($"Your current hp is: { player.Health}");
                }
            }

            if (player.Health > 0)
            {
                Console.WriteLine("You won!");
                Console.WriteLine($"You earned {monster.Experience} experience!");
                player.Experience += monster.Experience;
                player.StatsUpdate();
                if (player.Level == 10)
                {
                    Console.WriteLine("Geeeee, you won, congrats!");
                    Exit();
                }
                Utilities.Next();
                GameMenu();
            }


        }

    }
}

