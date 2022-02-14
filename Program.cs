using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }

        static void Menu()
        {
          double totalMoney = 11.00;
          DisplayMenu();
          int userChoice = GetMenuChoice();

           if (userChoice == 1)
            {
              BuyItem( ref totalMoney);
            }
            else if (userChoice == 2)
            {
              GiveHammACoin();
            }
            else if(userChoice == 3)
            {
             CheckMoneyBalance();
            }
            userChoice = GetMenuChoice();
        
        }
    }   static void DisplayMenu()
        {
          Console.WriteLine("1. Buy an Item");
          Console.WriteLine("2. Give Hamm a Coin");
          Console.WriteLine("3. Check Money Balance");
          Console.WriteLine("4. Exit the Program");

        }
        static void GetMenuChoice()
        {
          Console.WriteLine("Enter your choice: ");
          int menuChoice = int.Parse(Console.ReadLine());
              
              while (menuChoice < 1 || menuChoice> 4)
              {
                Console.WriteLine("Invalid Choice. Please enter a choice from the menu");
                Console.WriteLine("Enter a choice: ");
                toyChoice = int.Parse(Console.ReadLine());
                return toyChoice
              }
              
        }

        
          

              
              
        
            


        }   




            



            
            
}       
