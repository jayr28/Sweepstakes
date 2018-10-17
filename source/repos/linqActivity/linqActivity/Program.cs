using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", " bike", "this", "it", "tenth", "mathematics" };

            var thWords = words.Where(w => w.Contains("th"));
            foreach (var wordTh in thWords)
            {
                Console.WriteLine(wordTh);

            }
            Console.Read();

            //List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

            //var listName = names.Distinct();

            //foreach(var name in listName)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.Read();

            List<string> classGrades = new List<string>
            {   "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55",
            };

            var studentAverage = classGrades.Select(s => s.Split(',').Select(x => Int32.Parse(x)).OrderBy(y => y).Skip(1).Average()).Average();



            //var studentAverage = classGrades.Select(s => s.Split(',').ToList().Select(x=> Int32.Parse(x)).OrderBy(y=> y).ToList());
            //var w = studentAverage.Select(x => x.First()).ToList();
            //var f = studentAverage.Select(d => d.ToList().Where(c => !w.Contains(c))).Select(y=> y.ToList().Average());
            //var r = f.Average();


            //var studentAverage = classGrades.Select(s => s.Split(',').ToList()
            //.Select(x => Int32.Parse(x)).OrderBy(y => y).ToList()).ToList()
            //.Select(d => d.ToList().Where(c => !(classGrades.Select(s => s.Split(',').ToList()
            //.Select(x => Int32.Parse(x)).OrderBy(y => y).ToList()).Select(x => x.First()).ToList()).Contains(c))).Select(y => y.ToList().Average()).Average();

            string word = "Terrill";
            var d = word.ToList().Select(g=> g.ToString().ToUpper()).OrderBy(x=>x);
            StringBuilder alphaWithCount = new StringBuilder();
            foreach (var t in d.Distinct())
            {
                int alphaCtr = 0;
                foreach (var c in d)
                {
                    if (t == c)
                    {
                        alphaCtr += 1;
                    }
                }
                alphaWithCount.Append(t);
                alphaWithCount.Append(alphaCtr.ToString());

            }

        }
    }
}
