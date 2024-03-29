internal class Program
{
    //assignment random number or random string generator
    /* ask the user to select an Option
     * [1] Generate Random Number [2] Generate Random String
     * If [1] generate random number between *(1000,9999)
     * if[2] generate random string has 16 char length
      
     */
    static void GenerateRandomNumber()
    {
        var random = new Random();
        var val = random.Next(1000, 9999);
        Console.WriteLine($"Random Number: {val}");
    }
    static void GeneratedRandomString()
    {
        const string Buffer = "abcdefjhigklmnopqrstuvwxyzABCDEFGHIGKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";
        var random = new Random();
        var sb = new StringBuilder();
        while (sb.Length < 16) {
            var ranomIndex = random.Next(0, Buffer.Length - 1);
            sb.Append(Buffer[ranomIndex]);
        }
        Console.WriteLine($"Random String: {sb}");

        //memory consuming so we used strind builder
        //var randString = " ";
        //while(randString.Length < 16)
        //{
        //    var ranomIndex = random.Next(0,Buffer.Length - 1);
        //    randString += Buffer[ranomIndex];
        //}
        //Console.WriteLine($"Random String: {randString}");
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an Option");
            Console.WriteLine("[1] Generate Random Number [2] Generate Random String");
            int SelectedNum = int.Parse(Console.ReadLine());

            if (SelectedNum == 1)
                GenerateRandomNumber();
            else if (SelectedNum == 2)
                GeneratedRandomString();
            else
                Console.WriteLine("Invalid Input");

           
        }

    }
