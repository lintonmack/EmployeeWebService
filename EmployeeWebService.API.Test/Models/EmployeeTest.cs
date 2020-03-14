using EmployeeWebService.API.Models;
using FluentAssertions;
using Xunit;

namespace EmployeeWebService.API.Test.Models
{
    public class EmployeeTest
    {
        [Fact]
        public void WhenEmployeeIsInstantiatedANewEmployeeIsCreated()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Smith";
            var gender = "M";
            var dob = "31/01/1990";
            var postcode = "M1 2AR";
            var employeeNumber = 1234;
            var department = "Technology";
            var startDate = "31/11/2019";
            float salary = 30000;
            var email = "john@test.com";

                // Act
            var subject = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                DOB = dob,
                Postcode = postcode,
                EmployeeNumber = employeeNumber,
                Department = department,
                StartDate = startDate,
                Salary = salary,
                Email = email
            };

            // Assert
            subject.FirstName.Should().Be(firstName);
            subject.LastName.Should().Be(lastName);
            subject.Gender.Should().Be(gender);
            subject.DOB.Should().Be(dob);
            subject.Postcode.Should().Be(postcode);
            subject.EmployeeNumber.Should().Be(employeeNumber);
            subject.Department.Should().Be(department);
            subject.StartDate.Should().Be(startDate);
            subject.Salary.Should().Be(salary);
            subject.Email.Should().Be(email);
        }
    }
}