class Program
{
    static void Main()
    {
        //display title
        System.Console.WriteLine("*********** Demo Bank *************");
        System.Console.WriteLine("::Login Page::");

        string userName = null, password = null;
        System.Console.Write("Username:");
        userName = System.Console.ReadLine();
        if (userName != "")
        {
            System.Console.Write("Password:");
            password = System.Console.ReadLine();
        }
        if(userName == "system" && password == "manager")      
        {
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Account");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");
                System.Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: // Display customer menu
                        break;
                    case 2: // Display Account
                        break;
                    case 3: // Display Funds Transfer
                        break;
                    case 4: // Display Funds Transfer Statement
                        break;
                    case 5: // Display Account Statement
                        break;
                    case 0: // Display Exit
                        break;
                }
            } while (mainMenuChoice != 0);
        } 
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
    }
}