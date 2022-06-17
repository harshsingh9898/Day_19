using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class ValidUserRegistraton
    {
        
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";                 
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";                  
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";     //UC3
        public const string MOBILE = "^([9][1])+[ ]+[6789]{1}[0-9]{9}$";      
        public const string PASSWORD = "^[a-z]{8}";                           
        
        public void ValidateFName(string fName)
        {
            
            Regex regex = new Regex(FIRST_NAME);

            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
            }
            else
            {
                Console.WriteLine("first name does not match with pattern");
            }
        }
        
        public void ValidateLName(string lName)
        {
            
            Regex regex = new Regex(LAST_NAME);

            if (regex.IsMatch(lName))
            {
                Console.WriteLine("last name is matched with pattern");
            }
            else
            {
                Console.WriteLine("last name does not match with pattern");
            }
        }
        
        public void ValidateEmail(string emailId)
        {
            
            Regex regex = new Regex(EMAIL);

            if (regex.IsMatch(emailId))
            {
                Console.WriteLine("Email is matched with pattern");
            }
            else
            {
                Console.WriteLine("email does not match with pattern");
            }
        }
        
        public void ValidateMobile(string mnum)
        {
            
            Regex regex = new Regex(MOBILE);

            if (regex.IsMatch(mnum))
            {
                Console.WriteLine("Mobile Number is matched with pattern");
            }
            else
            {
                Console.WriteLine("Mobile Number does not match with pattern");
            }
        }
        
        public void ValidatePassword(string psswrd)
        {
           
            Regex regex = new Regex(PASSWORD);

            if (regex.IsMatch(psswrd))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord Number does not match with pattern");
            }
        }
    }
}