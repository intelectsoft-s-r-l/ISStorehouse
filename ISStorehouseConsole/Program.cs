using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
