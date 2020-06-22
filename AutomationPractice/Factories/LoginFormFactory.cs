using AutoFixture;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Factories
{
    public static class LoginFormFactory
    {
        public static LoginFormModel Create()
        {
            var _fixture = new Fixture();
            var dateTime = _fixture.Create<DateTime>();
            return new LoginFormModel
            {
                FirstName = "Vanio",
                LastName = "Petrov",
                Year = "2000",
                Month = dateTime.Month.ToString(),
                Date = dateTime.Day.ToString(),
                Password = "1234342345",
                Gender = Gender.Male.ToString(),
                PostCode = "13245",
                Email = "sadasd@fdgdfg.com",
                RealFirstName = "Ivan",
                RealLastName = "Petrov",
                Address = "Sofia",
                City = "Sofia",                
                State = "Alabama",
                Phone = "555555555",
                Alias = "Sofia"
            };
        }
    }
}
