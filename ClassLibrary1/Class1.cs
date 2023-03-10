using System;

namespace ClassLibrary1
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(numbers.Length == 0)
            {
                return 0;
            }
            string[] splited = numbers.Split(',', '\n');
            int sum = 0;
            for (int i = 0; i < splited.Length; i++)
            {
                int number = Convert.ToInt32(splited[i]);
                if(number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if(number <= 1000)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
