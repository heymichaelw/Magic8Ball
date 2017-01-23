using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class Program
    {
        static void SendQuestion(IQuestionable ball)
        {
            ball.Ask();
        }

        
        
        static void Main(string[] args)
        {
            
            List<IQuestionable> ballnames = new List<IQuestionable> {new robot8Ball(), new sad8Ball(), new happy8Ball() };
            while (true)
            {
                var rng = new Random();
                int r = rng.Next(0, 3);
                Console.WriteLine("YOUR FORTUNE WILL BE REVEALED!  ASK A YES/NO QUESTION.");
                Console.ReadLine();
                SendQuestion(ballnames[r]);
                Console.Read();
                Console.Clear();
            }
        }
    }
}
