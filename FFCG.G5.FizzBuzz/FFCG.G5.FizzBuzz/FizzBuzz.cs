﻿using System.Collections.Generic;

namespace FFCG.G5.FizzBuzz
{
    public class FizzBuzz
    {
        public List<string> GetResultSerie()
        {
            List<string> serie = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                string item = i.ToString();

                if (i % 3 == 0)
                {
                    item = "Fizz";
                }
                if (i % 5 == 0)
                {
                    item = "Buzz";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    item = "FizzBuzz";
                }
                serie.Add(item);
            }

            return serie;
        }
    }
}