using ClaimsRepository;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProgram
{
    class ProgramUI
    {

        private ClaimsRepo _itemRepo = new ClaimsRepo();

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
                    "1. See All Claims \n" +
                    "2. Take Care of Next Claim \n" +
                    "3. Enter In A New Claim \n" +
                    "4. OPEN \n" +
                    "5. OPEN \n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input)
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
                    case "6":
                        Console.WriteLine("Good Bye!");
                        keepRunning = false;
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
            Console.Clear();

            List<Claims> _listOfClaims = _itemRepo.GetClaims();

            var table = new ConsoleTable("ClaimID", "Type", "Description", "Amount", "Date of Accident", "Date of Claim", "isValid"); //Header for table

            foreach (Claims id in _listOfClaims)
            {
                table.AddRow(id.ClaimID, id.TypeOfClaim, id.Description, id.ClaimAmount, id.DateOfIncident.ToShortDateString(), id.DateOfClaim.Date.ToShortDateString(), id.IsValid); ;
            }

            table.Write();
            Console.WriteLine();

        }


        public void TakeCareOfNextClaim()
        {


        }

        public void EnterNewClaim()
        {
            Console.Clear();

            Claims newClaim = new Claims();

            Console.WriteLine("Enter in the claim ID:");
            newClaim.ClaimID = Console.ReadLine();

            Console.WriteLine("Enter the claim type: \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Rental \n" +
                "4. Life \n" +
                "5. Disability");

            string claimTypeAsString = Console.ReadLine();
            int claimTypeAsInt = int.Parse(claimTypeAsString);
            newClaim.TypeOfClaim = (ClaimType)claimTypeAsInt;

            Console.WriteLine("Enter in the description of claim:");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter in the claim amount ($xx.xx):");
            newClaim.ClaimAmount = Console.ReadLine();
            
            Console.WriteLine("Enter in the date of incident:");
            newClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter in the date of the incident:");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is the policy valid (yes or no)?");
            string inputPolicyValid = Console.ReadLine();
            newClaim.IsValid = "yes".Equals(inputPolicyValid, StringComparison.OrdinalIgnoreCase);

            _itemRepo.CreateClaim(newClaim);

            
        }



        // Other Methods

        public void SeedMenuList()
        {
            Claims claim1 = new Claims("1", ClaimType.Home, "House caught on fire.", "$12,000.33", new DateTime(2019, 10, 21), new DateTime(2019, 11, 5), true);
            Claims claim2 = new Claims("1", ClaimType.Car, "Hit by blind driver.", "$2,030.33", new DateTime(2020, 9, 21), new DateTime(2020, 10, 5), true);

            _itemRepo.CreateClaim(claim1);
            _itemRepo.CreateClaim(claim2);
        }

    } // end of Program UI Class
} // End of Namespace
