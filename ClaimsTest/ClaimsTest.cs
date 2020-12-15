using System;
using ClaimsRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaimsTest
{
    [TestClass]
    public class ClaimsTest
    {

        private Claims _claims;
        private ClaimsRepo _repo;

        [TestInitialize]

        public void Arrange()
        {

            _claims = new Claims("3456", ClaimType.Rental, "My jams were stolen.", "$100.33", new DateTime(2019, 5, 25), new DateTime(2019, 9, 5), true);
            _repo = new ClaimsRepo();
            _repo.CreateClaim(_claims);
        }

        [TestMethod]
        public void AddNewClaim_ShouldGetNonNull()
        {


            // Arrange

            Claims claim = new Claims();
            claim.ClaimID = "44";

            // Act

            ClaimsRepo repo = new ClaimsRepo();
            repo.CreateClaim(claim);
            Claims claimFromQueue = repo.GetClaimByClaimId("44");


            // Assert
            Assert.IsNotNull(claimFromQueue);

        }

        
    }
}
