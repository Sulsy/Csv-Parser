using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace ClassLibrary1
{
    /// <summary>
    /// Разбивания строки в List
    /// </summary>
    public class Parse
    {
        public static Char razdel;
        /// <summary>
        /// Разбивания строки в List
        /// </summary>
        public static List<object> ParseString(String line)
        {
             line = line.Replace("\"", String.Empty);
            List<Object> list = new List<Object>(line.Split(razdel));
            return list;
        }
    }
    /// <summary>
    /// Траснформация List в двумерный List
    /// </summary>
    public class Transorm
    {/// <summary>
     /// Траснформация List в двумерный List
     /// </summary>
        public static List<List<object>> TransormToTwoList(string path= "bum24.csv")
        {
            var list = File.ReadAllLines(path)
                      .Select(Parse.ParseString)
                      .ToList();
            
            return list;
        }
        /// <summary>
        /// Траснформация List в двумерный List и выполняет сортировку по ID
        /// </summary>
        public static List<List<object>> TransormToTwoList(bool Sort, string path = "bum24.csv")
        {
            if (Sort)
            {
                var list = File.ReadAllLines(path)  
                          .Skip(1)
                          .Select(Parse.ParseString)
                          .OrderBy(x=>Convert.ToInt32(x[0]))
                          .ToList();
                return list;
            }
            else
            {
                var list = File.ReadAllLines(path)
                              .Skip(1)
                              .Select(Parse.ParseString)
                              .OrderByDescending(x => Convert.ToInt32(x[0]))
                              .ToList();
                return list;

            }
            
        }

    }
}

