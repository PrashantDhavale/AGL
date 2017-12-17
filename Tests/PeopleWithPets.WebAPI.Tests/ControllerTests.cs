using System;
using Moq;
using Xunit;
using PeopleWithPets.Domain.Repository;
using PeopleWithPets.WebAPI.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PeopleWithPets.WebAPI.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void CreateWithNullPeopleWithPetsRepositoryWillThrow()
        {

            // Arrange
            PeopleWithPetsRepository nullRepository = null;
            var mockLogger = new Mock<ILogger<PeopleWithPetsController>>();

            // Act and assert
            Assert.Throws<ArgumentNullException>(() => new PeopleWithPetsController(nullRepository, mockLogger.Object));
        }

        [Fact]
        public void GetCatsGroupedByOwnersGender_ReturnsOk()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<PeopleWithPetsController>>();
            var mockRepository = new Mock<PeopleWithPetsRepository>();
            mockRepository.Setup(pro => pro.GetCatsGroupedByOwnersGender()).Returns(GetTestCatsGroupedByOwnersGender());

            var controller = new PeopleWithPetsController(mockRepository.Object, mockLogger.Object);

            // Act
            var result = controller.GetCatsGroupedByOwnersGender();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnModel = Assert.IsAssignableFrom<IEnumerable<Domain.Models.CatsGroupedByOwnersGender>>(okResult.Value);
        }

        private IEnumerable<Domain.Models.CatsGroupedByOwnersGender> GetTestCatsGroupedByOwnersGender()
        {
            List<Domain.Models.CatsGroupedByOwnersGender> l = new List<Domain.Models.CatsGroupedByOwnersGender>();
            l.Add(new Domain.Models.CatsGroupedByOwnersGender(Domain.Enums.PersonGender.Male, new string[] { "a" }));
            l.Add(new Domain.Models.CatsGroupedByOwnersGender(Domain.Enums.PersonGender.Female, new string[] { "b" }));

            return l;
        }
    }
}
