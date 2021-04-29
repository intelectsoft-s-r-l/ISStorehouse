namespace ISStorehouseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sms = new ISStorehouseService.SHService();
            sms.StartService();
            string str = System.Console.ReadLine();
        }
    }
}
