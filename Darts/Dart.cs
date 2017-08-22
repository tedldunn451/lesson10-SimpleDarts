using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }

        public int SpecialScore { get; set; }

        Random random = new Random();

        public void Throw()
        {

            // Generate a random number between 0 and 20
            // A result of 0 means a bullseye hit any other value is that number
            Score = random.Next(0, 21);

            // Generate a number between 1 and 100 to represent a percentage
            // used to determine if a "special" kind of hit was made
            int percentile = random.Next(1, 101);

            // If a bullseye (Score == 0) and 5 or less on the percentile "roll"
            // then the inner bullseye was hit
            if (Score == 0 && percentile <= 5)
                SpecialScore = 0;

            // If a bullseye (Score == 0) and greater than 5 on percentile "roll"
            // then the outer bullseye was hit
            else if (Score == 0 && percentile > 5)
                SpecialScore = 1;

            // If any other Score value is generated and 5 or less on percentile "roll"
            // then the double score band was hit for that value
            else if (percentile <= 5)
                SpecialScore = 2;

            // If any other Score value is generated and 6 to 10 on percentile "roll"
            // then the triple score band was hit for that value
            else if (percentile > 5 && percentile <= 10)
                SpecialScore = 3;
        }
    }
}
