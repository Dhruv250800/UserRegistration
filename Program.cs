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
    }
}