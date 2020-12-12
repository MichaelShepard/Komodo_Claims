using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProgram
{
    class ProgramUI
    {
    
    public void Run()
        {
            SeedMenuList();
            Menu();
        }

        public void Menu()
        {

            bool keepRunning = true;

            while (keepRunning)
            {

                Console.WriteLine("Select an option: \n" +
                    "1. Create New Menu Item \n" +
                    "2. View All Menu Items \n" +
                    "3. View Menu Item By Meal # \n" +
                    "4. Update Meal Item \n" +
                    "5. Delete A Meal Item \n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch(input)
                {

                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        break;


                }

                Console.WriteLine("Press any key to conitnue...");
                Console.ReadKey();
                Console.Clear();

            }
        } //End of Menu

        public void SeeAllClaims()
        {

        }


        public void TakeCareOfNextClaim()
        {


        }

        public void EnterNewClaim()
        {

        }


    } // end of Program UI Class
} // End of Namespace
