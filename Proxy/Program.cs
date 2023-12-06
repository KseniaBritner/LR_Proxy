using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main()
        {
            IFile file = new FileProxy("text.txt");
            Console.WriteLine($"Размер: {file.GetSize()} \nПуть: {file.GetPath()}");
        }
    }
}
