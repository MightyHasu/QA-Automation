using AutoFixture;
using AutomationPractice.Models;
using System;


namespace AutomationPractice.Factories
{
    public static class SignInFactory
    {        
        public static SignInModel Create()
        {
            var _fixture = new Fixture();
            return new SignInModel
            {
                Email = _fixture.Create<string>()+"@gmail.com"
            };
        }
    }
}
