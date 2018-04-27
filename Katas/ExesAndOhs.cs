using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class ExesAndOhs
    {
        public static bool XO(string input)
        {
            int numberOfO = 0;
            int numberOfX = 0;
            foreach (var letter in input.ToLower().ToCharArray())
            {
                switch (letter)
                {
                    case 'o':
                        numberOfO++;
                        break;
                    case 'x':
                        numberOfX++;
                        break;
                }
            }

            return numberOfX == numberOfO;
        }
    }
}
