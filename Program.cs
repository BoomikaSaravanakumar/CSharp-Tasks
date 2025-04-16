using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace C_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ans = true;
            while (ans)
            {
                Console.WriteLine("Functions Available:\n 1.Eligibility for Loan\n 2.Transaction\n 3.Future Balance Rate of Interest\n 4.Account Number multiple customers\n 5.Password Validation\n 6.History\n 7.Exit");
                Console.WriteLine("Enter your wish:");
                int wish = int.Parse(Console.ReadLine());
                switch (wish) {

                    //Task1
                    //1. Write a program that takes the customer's credit score and annual income as input.
                    //2. Use conditional statements (if-else) to determine if the customer is eligible for a loan.
                    //3. Display an appropriate message based on eligibility.
                    case 1:
                        Console.WriteLine("Enter the credit card score");
                        int score = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Annual income:");
                        double income = double.Parse(Console.ReadLine());
                        if (score >= 700 && income >= 50000)
                        {
                            Console.WriteLine("You are Eligible for applying loan");
                        }
                        else
                        {
                            Console.WriteLine("You are not Eligible for applying Loan");
                        }
                        break;
                    //Task 2
                    /*
                    1.Create a program that simulates an ATM transaction. Display options such as "Check Balance,"
                    "Withdraw," "Deposit,".
                    2.Ask the user to enter their current balance and the amount they want to
                    withdraw or deposit. 
                    3.Implement checks to ensure that the withdrawal amount is not greater than the
                    available balance and that the withdrawal amount is in multiples of 100 or 500.
                    4.Display appropriate messages for success or failure.
                    */
                    case 2:
                        Console.WriteLine("Enter your current balane:");
                        int Balance = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choices:\n 1.Check Balance\n 2.Withdraw\n3.Deposit");
                        Console.WriteLine("Enter your choice:");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"Your Balance Amount is:{Balance}");
                                break;

                            case 2:
                                Console.WriteLine("Enter the Amount for Withdrawal:");
                                double withdraw = double.Parse(Console.ReadLine());
                                if (withdraw <= Balance)
                                {
                                    if (withdraw % 100 == 0 || withdraw % 500 == 0)
                                    {
                                        Console.WriteLine($"Successful withdrawal of amount {withdraw}");
                                        double bb = Balance - withdraw;
                                        Console.WriteLine($"Available Balance:{bb}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Withdrawal Amount is not the multiples of 100 and 500");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Exceeding the Available Balance");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Enter the amount to be deposited:");
                                double Money = double.Parse(Console.ReadLine());
                                double totalAmount = Money + Balance;
                                Console.WriteLine($"Available balance Now:{totalAmount}");
                                break;

                        }
                        break;
                    //Task 3
                    /*  1. Create a program that calculates the future balance of a savings account.
                        2. Use a loop structure (e.g., for loop) to calculate the balance for multiple customers.
                        3. Prompt the user to enter the initial balance, annual interest rate, and the number of years.
                        4. Calculate the future balance using the formula:      
                           future_balance = initial_balance * (1 + annual_interest_rate/100)^years.
                        5. Display the future balance for each customer.  */

                    case 3:
                        Console.Write("Enter the number of customers: ");
                        int noOfCustomers = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= noOfCustomers; i++)
                        {
                            Console.WriteLine($"\nCustomer {i}:");

                            // Getting customer i/p
                            Console.Write("Enter initial balance: ");
                            double initialBalance = double.Parse(Console.ReadLine());

                            Console.Write("Enter annual interest rate (in %): ");
                            double annualInterestRate = double.Parse(Console.ReadLine());

                            Console.Write("Enter number of years for calculation: ");
                            int years = int.Parse(Console.ReadLine());

                            // Calculating future balance
                            double futureBalance = initialBalance * Math.Pow(1 + (annualInterestRate / 100), years);

                            // Displaying the result for each customers
                            Console.WriteLine($"Future balance after {years} years: {futureBalance:C}");
                        }
                        break;
                    //Task 4
                    /*
                    1. Create a C# program that simulates a bank with multiple customer accounts.
                    2. Use a loop (e.g., while loop) to repeatedly ask the user for their account number and
                    balance until they enter a valid account number.
                    3. Validate the account number entered by the user.
                    4. If the account number is valid, display the account balance. If not, ask the user to try again.
                    */
                    case 4:
                        string accNumber;
                        double balance1;

                        while (true)
                        {
                            // Get account number from user
                            Console.Write("Enter your account number (Format: ABCD1234): ");
                            accNumber = Console.ReadLine();

                            // Validate format: 4 uppercase letters + 4 digits
                            if (accNumber.Length == 8)
                            {
                                bool isValid = true;

                                // Check first 4 characters are uppercase letters
                                for (int i = 0; i < 4; i++)
                                {
                                    if (!char.IsUpper(accNumber[i]) || !char.IsLetter(accNumber[i]))
                                    {
                                        isValid = false;
                                        break;
                                    }
                                }

                                // Check last 4 characters are digits
                                for (int i = 4; i < 8; i++)
                                {
                                    if (!char.IsDigit(accNumber[i]))
                                    {
                                        isValid = false;
                                        break;
                                    }
                                }

                                if (isValid)
                                {
                                    Console.Write("Enter your account balance: ");
                                    balance1 = double.Parse(Console.ReadLine());
                                    if (true)
                                    {
                                        Console.WriteLine($"Your account balance: {balance1}");
                                        break; // Exit loop after valid input
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid account format! Try again (Example: ABCD1234).");
                                }
                            }

                        }
                        break;
                    //Task 5
                    /*   Task 5: Password Validation
                     Write a program that prompts the user to create a password for their bank account. Implement if
                     conditions to validate the password according to these rules:
                     • The password must be at least 8 characters long.
                     • It must contain at least one uppercase letter.
                     • It must contain at least one digit.
                     • Display appropriate messages to indicate whether their password is valid or not.   */

                    case 5:
                        Console.Write("Create your password: ");
                        string password = Console.ReadLine();

                        bool hasUppercase = false;
                        bool hasDigit = false;

                        // for checking 
                        foreach (char c in password)
                        {
                            if (char.IsUpper(c))
                                hasUppercase = true;
                            if (char.IsDigit(c))
                                hasDigit = true;
                        }

                        // Validating the password
                        if (password.Length < 8)
                        {
                            Console.WriteLine("Password must be at least 8 characters long.");
                        }
                        else if (!hasUppercase)
                        {
                            Console.WriteLine("Password must contain at least one uppercase letter.");
                        }
                        else if (!hasDigit)
                        {
                            Console.WriteLine("Password must contain at least one digit.");
                        }
                        else
                        {
                            Console.WriteLine("Password created successfully!");
                        }
                        break;

                    //Task 6
                    /*  1.Create a program that maintains a list of bank transactions (deposits and withdrawals) for a customer.
                        2.Use a while loop to allow the user to keep adding transactions until they choose to exit. 
                        3.Display the  transaction history upon exit using looping statements.   */

                    case 6:
                        List<string> transactions = new List<string>(); // Stores transaction history
                        double balance3 = 0;
                        bool running = true;

                        while (running)
                        {
                            Console.WriteLine("\n--- Bank Transaction Menu ---");
                            Console.WriteLine("1. Deposit");
                            Console.WriteLine("2. Withdraw");
                            Console.WriteLine("3. Exit & Show History");
                            Console.Write("Choose an option: ");

                            string choice2 = Console.ReadLine();

                            if (choice2 == "1") // Deposit
                            {
                                Console.Write("Enter deposit amount: ");
                                if (double.TryParse(Console.ReadLine(), out double deposit) && deposit > 0)
                                {
                                    balance3 += deposit;
                                    transactions.Add($"Deposited: +${deposit:F2}, New Balance: ${balance3:F2}");
                                    Console.WriteLine("Deposit successful!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid amount! Try again.");
                                }
                            }
                            else if (choice2 == "2") // Withdraw
                            {
                                Console.Write("Enter withdrawal amount: ");
                                if (double.TryParse(Console.ReadLine(), out double withdrawal) && withdrawal > 0)
                                {
                                    if (withdrawal <= balance3)
                                    {
                                        balance3 -= withdrawal;
                                        transactions.Add($"Withdrawn: -${withdrawal}, New Balance: ${balance3}");
                                        Console.WriteLine("Withdrawal successful!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficient balance!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid amount! Try again.");
                                }
                            }
                            else if (choice2 == "3") // Exit & Show History
                            {
                                running = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice! Please select again.");
                            }
                        }

                        // Display transaction history
                        Console.WriteLine("\n--- Transaction History ---");
                        if (transactions.Count == 0)
                        {
                            Console.WriteLine("No transactions recorded.");
                        }
                        else
                        {
                            foreach (string transaction in transactions)
                            {
                                Console.WriteLine(transaction);
                            }
                        }

                        Console.WriteLine($"Final Balance: ${balance3}");
                        break;
                
                
                case 7:
                    // Exit
                    Console.WriteLine("Exiting...");
                    ans = false;
                    break;

                default:
                    Console.WriteLine("Thankyou");
                    break;

                }
            }
        }

    }
}


    


 
