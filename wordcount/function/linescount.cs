﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wordcount.function
{
    class linescount
    {

        public static int lines()//统计文件中的行数
        {
           
            string str = File.ReadAllText(@path.s);
            int nr = Regex.Matches(str, @"\r").Count + 1;
            return nr;
        }
    }
}
