using System;
using UserRegistration;

public class Program
{
    public static void Main(string[] args)
    {
        // Use Case 1: Validating First Name
        string firstName = Console.ReadLine();
        FirstNameValidator firstNameValidator = new FirstNameValidator();
        if (firstNameValidator.ValidateFirstName(firstName))
        {
            Console.WriteLine("Valid first name");
        }
        else
        {
            Console.WriteLine("Invalid first name");
        }

        // Use Case 2: Validating Last Name
        string lastName = Console.ReadLine();
        LastNameValidator lastNameValidator = new LastNameValidator();
        if (lastNameValidator.ValidateLastName(lastName))
        {
            Console.WriteLine("Valid last name");
        }
        else
        {
            Console.WriteLine("Invalid last name");
        }

        // Use Case 3: Validating Email
        string email = Console.ReadLine();
        EmailValidator emailValidator = new EmailValidator();
        if (emailValidator.ValidateEmail(email))
        {
            Console.WriteLine("Valid email");
        }
        else
        {
            Console.WriteLine("Invalid email");
        }

        // Use Case 4: Validating Mobile Number
        string mobileNumber = Console.ReadLine();
        MobileNumberValidator mobileNumberValidator = new MobileNumberValidator();
        if (mobileNumberValidator.ValidateMobileNumber(mobileNumber))
        {
            Console.WriteLine("Valid mobile number");
        }
        else
        {
            Console.WriteLine("Invalid mobile number");
        }
    }
}