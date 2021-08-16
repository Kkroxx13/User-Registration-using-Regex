using System;

namespace RegexImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            bool validResultName = regex.ValidateFirstName();
            if(validResultName==true)
                Console.WriteLine("The name is valid");
            else
                Console.WriteLine("The name is invalid");


            bool validResultNumber = regex.ValidateMobileNumber();
            if(validResultNumber==true)
                Console.WriteLine("The Number is valid");
            else
                Console.WriteLine("The number is invalid");


            bool validResultEmail = regex.validateEmail();
            if(validResultEmail==true)
                Console.WriteLine("The Email is valid");
            else
                Console.WriteLine("The Email is invalid");

            bool validPassword = regex.ValidatePassword();
            if(validPassword==true)
                Console.WriteLine("The Password is valid");
            else
                Console.WriteLine("The password is invalid");

        }
    }
}
