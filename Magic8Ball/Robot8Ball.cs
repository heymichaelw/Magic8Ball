using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class Robot8Ball : IQuestionable
    {

        Dictionary<int, string> robotDictionary = new Dictionary<int, string>()
        {
            { 1, "AFFIRMATIVE" },
            { 2, "NEGATIVE" },
            { 3, "REQUIRES FURTHER INPUT" },
            { 4, "ERROR" },
            { 5, "THAT IS STATISTICALLY IMPOSSIBLE" },
            { 6, "THE PROBABILITY IS VERY CLOSE TO 1" },
            { 7, "THIS HUMAN SITUATION IS UNCLEAR" },
            { 8, "MY BRAIN IS FAR TOO VAST FOR THIS INCONSEQUENTIAL QUERY" }

        };
        public void Ask()
        {
            var rng = new Random();
            int r = rng.Next(0, 9);
            Console.WriteLine($"{robotDictionary[r]}");
        }

      
    }
}
