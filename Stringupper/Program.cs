using System;
using System.Text;
using System.Collections;

namespace StringUpper
{
    public class StringUpp
    {
        
            static void Main(string[] args)
            {
                List<string> mylist = test(new List<string>(new string[] { Console.ReadLine() }));
                foreach (var i in mylist)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            public static List<string> test(List<string> str)
            {
                IEnumerable<string> s = str.Select(x => x.ToUpper());
                return s.ToList();
            }
    }
 }


