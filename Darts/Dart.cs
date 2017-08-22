using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        private Random _random;

        public int Value { get; set; }

        public int SpecialScore { get; set; }

        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {

            // Generate a random number between 0 and 20
            // A result of 0 means a bullseye hit any other value is that number
            Value = _random.Next(0, 21);

            // Generate a number between 1 and 100 to represent a percentage
            // used to determine if a "special" kind of hit was made
            int percentile = _random.Next(1, 101);

            // If a bullseye (Score == 0) and 5 or less on the percentile "roll"
            // then the inner bullseye was hit
            if (Value == 0 && percentile <= 5)
                SpecialScore = 0;

            // If a bullseye (Score == 0) and greater than 5 on percentile "roll"
            // then the outer bullseye was hit
            else if (Value == 0 && percentile > 5)
                SpecialScore = 1;

            // If any Score value other than 0 is generated and 5 or less on percentile "roll"
            // then the double score band was hit for that value
            else if (percentile <= 5)
                SpecialScore = 2;

            // If any Score value other than 0 is generated and 6 to 10 on percentile "roll"
            // then the triple score band was hit for that value
            else if (percentile > 5 && percentile <= 10)
                SpecialScore = 3;
        }
    }
}
