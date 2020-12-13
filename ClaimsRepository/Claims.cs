using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepository
{
    

    public enum ClaimType
    {
       Car = 1, // Resets value from 0 to 1
       Home,
       Rental,
       Life,
       Disability

    }

    // Plain Old C# Object -- POCO; Properties of that object
    public class Claims
    {

        public string ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; } // public Enum
        public string Description { get; set; }
        public string ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        // blank contructor
        public Claims() { }


        // Constructor with all of the properties associated with the claims object
        public Claims(string claimID, ClaimType type, string description, string claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {

            ClaimID = claimID;
            TypeOfClaim = type;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }

    } //End of claims class
        
} // End of Namespace
