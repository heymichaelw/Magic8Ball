using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class sad8Ball : IQuestionable
    {
        Dictionary<int, string> sadDictionary = new Dictionary<int, string>()
        {
            { 1, "I suppose that's likely..." },
            { 2, "That will happen.  Must be nice." },
            { 3, "Sure, if you actually want that to happen." },
            { 4, "That won't happen, like most things in life." },
            { 5, "That's as likely as the inevitable heat death of the universe." },
            { 6, "I have no idea..." },
            { 7, "I'm sorry, I'm obviously not intelligent enough to answer this question." },
            { 8, "I guess." }
        };

        public void Ask()
        {
            var rng = new Random();
            int s = rng.Next(1, 9);
            Console.WriteLine($"{sadDictionary[s]}");
        }
    }
}
