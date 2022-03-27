using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Threading;


namespace Uss
{
    internal class Menu
    {
        public void MainMenu()
        { 
            bool choose = false;
            SetWindowSize(120,60) ;
            do
            {
                Console.WriteLine(@"
                                                                                                                                                                                                                                         
 _______  __    _  _______  ___   _  _______    _______  _______  __   __  _______   
|       ||  |  | ||   _   ||   | | ||       |  |       ||   _   ||  |_|  ||       |  
|  _____||   |_| ||  |_|  ||   |_| ||    ___|  |    ___||  |_|  ||       ||    ___|  
| |_____ |       ||       ||      _||   |___   |   | __ |       ||       ||   |___   
|_____  ||  _    ||       ||     |_ |    ___|  |   ||  ||       ||       ||    ___|  
 _____| || | |   ||   _   ||    _  ||   |___   |   |_| ||   _   || ||_|| ||   |___   
|_______||_|  |__||__| |__||___| |_||_______|  |_______||__| |__||_|   |_||_______|  ");
                Console.WriteLine(" ");
                Console.WriteLine(@"
 ____            ____  _     ____ ___  _  
/  __\          /  __\/ \   /  _ \\  \//  
|  \/|  _____   |  \/|| |   | / \| \  /   
|  __/  \____\  |  __/| |_/\| |-|| / /    
\_/             \_/   \____/\_/ \|/_/     
                                           ");
                Console.WriteLine(@"
 _            _  _      _____ ____   
/ \          / \/ \  /|/    //  _ \  
| |  _____   | || |\ |||  __\| / \|  
| |  \____\  | || | \||| |   | \_/|  
\_/          \_/\_/  \|\_/   \____/  
                                     ");
                Console.WriteLine(@"
 _____           ________  _ _  _____ 
/  __/          /  __/\  \/// \/__ __\
|  \    _____   |  \   \  / | |  / \  
|  /_   \____\  |  /_  /  \ | |  | |  
\____\          \____\/__/\\\_/  \_/  
                                      
                                      ");
                var input = Console.ReadKey(); // для чтения клавишы 
                switch (input.Key)
                {
                    case ConsoleKey.P:
                        choose = true;
                        Clear();
                        break;
                    case ConsoleKey.I:
                        choose = true;
                        Info();
                        Clear();
                        break;
                    case ConsoleKey.E:
                        choose = true;
                        Clear(); 
                        Exit();    
                        break;
                }
                Clear();
            } while (choose != true);
            void Info()
            {
                Clear();
                Console.WriteLine("Autor: Aleksandr Kastanie\n Kuidas mängida: \n vasak nool - madu pöörab vasakule \n parem nool - mad pöörab paremale \n allanool - madu keerab alla\n Nool üles – madu keerdub üles ");
                Console.WriteLine("Kui madu puudutab seinu, on mäng läbi.");
                Console.ReadKey();
                Clear();
                MainMenu();
            }
            void Exit()
            {
                bool answer = false;
                do
                {
                    Console.WriteLine(@"Kas olete kindel, et soovite mängust väljuda?");
                    Console.WriteLine(@"
__   __             ___       _     
\ \ / /            |_  |     | |    
 \ V /   ______      | | __ _| |__  
  \ /   |______|     | |/ _` | '_ \ 
  | |            /\__/ / (_| | | | |
 _\_/_           \_____ ___,_|_| |_|
 _   _            ____  __
| \ | |          |  ___(+)          
|  \| |  ______  | |__  _           
| . ` | |______| |  __|| |          
| |\  |          | |___| |          
\_| \_/          \____/|_|          
                                    
                                    ");

                    var input = Console.ReadKey();
                    switch (input.Key)
                    {
                        case ConsoleKey.Y:
                            answer = true;
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.N:
                            answer = true;                         
                            break;
                    }

                } while (answer != true);
                Clear();
                MainMenu();
            }
        }
    }
}
