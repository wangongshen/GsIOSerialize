using GsIOSerialize.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsIOSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("==========IO序列化==========");
				{
					MyIO.Show();
				}
			}
			catch (Exception Ex)
			{
				Console.WriteLine("错误："+Ex.Message);
			}
			Console.ReadLine();
        }
    }
}
