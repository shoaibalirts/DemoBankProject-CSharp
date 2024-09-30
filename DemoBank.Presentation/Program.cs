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
            System.Console.WriteLine("TO DO: Main menu here");
        }
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
    }
}