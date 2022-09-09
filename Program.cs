using System;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace Juab;
class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine($"Juab path\\to\\exe path\\to\\commandline_file");
            return;
        }
        string exe = args[0];
        string txt = args[1];

        if (!File.Exists(exe))
        {
            Console.WriteLine($"{exe} not found.");
            return;
        }
        if (!File.Exists(txt))
        {
            Console.WriteLine($"{txt} not found.");
            return;
        }
        ProcessStartInfo pro = new ProcessStartInfo();
        pro.WindowStyle = ProcessWindowStyle.Hidden;
        pro.FileName = exe;
        pro.Arguments = File.ReadAllText(txt);
        Process x = Process.Start(pro) ?? throw new Exception($"Some problem executing {txt} with {exe}");
        x.WaitForExit();
    }
}
