using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
namespace RegexImplementation
{
    public class RegexValidation
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = "^[0-9]{10}$";
        public static string EMAIL_REGEX =@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static string PASSWORD_REGEX = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

        public bool ValidateFirstName()
        {
          return Regex.IsMatch("karan", NAME_REGEX);
           
        }

        public bool ValidateMobileNumber()
        {
            return Regex.IsMatch("91589833993", MOBILENUMBER_REGEX);
        }
        public bool validateEmail()
        {
            return Regex.IsMatch("kkkr0099@gmail.com", EMAIL_REGEX);
        }

        public bool ValidatePassword()
        {
            return Regex.IsMatch("morningstar123",PASSWORD_REGEX);
        }
    }

    
}
