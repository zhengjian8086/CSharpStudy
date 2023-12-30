using Study001;
class Program
{
    static void Main(string[] args)
    {
        Utils utils0;
        Utils utils1 = new Utils();
        utils0 = new Utils();

        Console.WriteLine(utils0.CreateDate);
        Console.WriteLine($"=={utils0.GetUnknowString()}==");
        Console.WriteLine("=={0}==", utils1.CreateDate);

        utils0.SetUnknowString("From class 'Program'");
        Console.WriteLine(utils0.GetUnknowString());

        utils0.SetCurrentInstanceName();
        Console.WriteLine(utils0.GetCurrentInstanceName());
        utils1.SetCurrentInstanceName();
        Console.WriteLine(utils1.GetCurrentInstanceName());
    }
}