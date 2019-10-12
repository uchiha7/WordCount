using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;
using wordcount.function;

namespace wordcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文件路径");
            string s = Console.ReadLine();
            path.s = s;
            Dictionary<string, int> frequencies = function.wordcount.Countword();
            Dictionary<string, int> dic1Asc = frequencies.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            int sum = function.wordcount.sum1(dic1Asc);
            Console.WriteLine("characters:" + asccount. agefile());
            Console.WriteLine("words:" + sum);
            Console.WriteLine("lines:" + linescount. lines());
            Console.WriteLine("频率最高的10个单词:" );
            int temp=0;
            Dictionary<string, int> dic1Asc1 = frequencies.OrderByDescending(o => o.Value).ThenBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            foreach (KeyValuePair<string, int> entry in dic1Asc1)
            {
                if (temp == 10)
                    break;
                string word = entry.Key;
                int frequency = entry.Value;
                temp++;
                
                Console.WriteLine("{0}:{1}", word, frequency);
                sum = sum + frequency;
               
            }
            Console.ReadKey();
        }
    }

}
