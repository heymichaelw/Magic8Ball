using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class happy8Ball : IQuestionable
    {
        Dictionary<int, string> happyDictionary = new Dictionary<int, string>()
        {
            { 1, "Of course that will happen!" },
            { 2, "Unfortunately, I don't see that happening." },
            { 3, "I can't quite see the answer.  Please ask again." },
            { 4, "It seems likely!" },
            { 5, "That doesn't seem likely, but keep trying!" },
            { 6, "Yes!" },
            { 7, "With enough hard work, of course!" },
            { 8, "I'm not quite sure now, but ask again!" } 
        };

        public void Ask()
        {
            var rng = new Random();
            int v = rng.Next(1, 9);
            Console.WriteLine($"{happyDictionary[v]}");
        }
    }
}
