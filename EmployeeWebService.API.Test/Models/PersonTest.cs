using EmployeeWebService.API.Models;
using FluentAssertions;
using Xunit;

namespace EmployeeWebService.API.Test.Models
{
    public class PersonTest
    {
        [Fact]
        public void WhenPersonIsInstantiatedANewPersonIsCreated()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Smith";
            var gender = "M";
            var dob = "31/01/1990";
            var postcode = "M1 2AR";

            // Act
            var subject = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                DOB = dob,
                Postcode = postcode
            };

            // Assert
            subject.FirstName.Should().Be(firstName);
            subject.LastName.Should().Be(lastName);
            subject.Gender.Should().Be(gender);
            subject.DOB.Should().Be(dob);
            subject.Postcode.Should().Be(postcode);
        }
    }
}