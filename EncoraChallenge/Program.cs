using System;
using System.Linq;
using System.Text;

namespace EncoraChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = SortingOperations(new string[] { "abaccadcc", "xyzxy" });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] SortingOperations(string[] words)
        {
            string[] result = new string[words.Length];
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                // Sort by frequency
                foreach (var group in words[i].Distinct()
                    .Select(c => new { Character = c, Frequency = words[i].Count(ch => ch == c) })
                    .GroupBy(c => c.Frequency)
                    .OrderByDescending(c => c.Key))
                {
                    // Sort by lexicographic order
                    foreach (var character in group.OrderBy(c => c.Character))
                    {
                        for (int y = 0; y < character.Frequency; y++)
                        {
                            stringBuilder.Append(character.Character);
                        }
                    }
                }
                // Set result
                result[i] = stringBuilder.ToString();
                stringBuilder.Clear();
            }
            return result;
        }
    }
}
