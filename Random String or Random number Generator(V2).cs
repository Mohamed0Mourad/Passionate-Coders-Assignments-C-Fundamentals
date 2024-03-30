/* if the user selected to generate numbers , ask him to enter minimum and maximum value
 * if the user selected to generate string , ask him for string length
 *  if user selected random string ask him to select the buffer options as follows:
 *     [1] include capital letters ? (yes/no)
 *     [2] include small letters ? (yes/no)
 *     [3] include numbers ? (yes/no)
 *     [4] include symbols? (yees/no)
         * */

static void GenerateRandomNumberV2()
{
    Console.Write("Enter min Number: ");
    int min = int.Parse(Console.ReadLine());
    Console.Write("Enter max Number: ");
    int max = int.Parse(Console.ReadLine());

    var random = new Random();
    var value = random.Next(min, max);
    Console.WriteLine($"Random Number : {value}");

}
static void GenerateRandomStringV2()
{
    Console.Write("Enter String Length: ");
    int len = int.Parse(Console.ReadLine());
    var sb = new StringBuilder();
    string buffer = "";
    Console.WriteLine("Select Buffer Option ");
    Console.WriteLine("[1] include capital letters ? (yes/no)");
    if (Console.ReadLine() == "yes")
        buffer += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    Console.WriteLine("[2] include small letters ? (yes/no)");
    if (Console.ReadLine() == "yes")
        buffer += "abcdefghijklmnopqrstuvwxyz";
    Console.WriteLine("[3] include numbers ? (yes/no)");
    if (Console.ReadLine() == "yes")
        buffer += "0123456789";
    Console.WriteLine("[4] include symbols ? (yes/no)");
    if (Console.ReadLine() == "yes")
        buffer += "!@#$%^&*()-=";
    var random = new Random();
    while(sb.Length < len)
    {
        var randomIndex = random.Next(0, buffer[buffer.Length - 1]);
        sb.Append(buffer[randomIndex]);
    }
    Console.WriteLine("random String : {0}",sb);

}
static void Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("Select an Option");
        Console.WriteLine("[1] Generate Random Number [2] Generate Random String");
        int SelectedNum = int.Parse(Console.ReadLine());

        if (SelectedNum == 1)
            GenerateRandomNumberV2();
        else if (SelectedNum == 2)
            GenerateRandomStringV2();
        else
            Console.WriteLine("Invalid Input");


    }

}
