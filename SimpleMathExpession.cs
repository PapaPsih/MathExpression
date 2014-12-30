using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Expression
{
    public class SimpleMathExpession
    {
        public SimpleMathExpession(String expression)
        {
            this.stringExpression = expression;
        }

        private String stringExpression;

        public Boolean IsCorrect()
        {
            Regex expressionPattern = new Regex(@"^\d+([\+\-\*\/]{1}\d+)\G?");
            return expressionPattern.IsMatch(this.stringExpression);
        }

        public Int32 Result()
        {
            if (!this.IsCorrect())
            {
                throw new Exception("Error! Expression is uncorrect");
            }
            
            Int32 result = 0;
            Regex number = new Regex(@"\d+");
            MatchCollection matches = number.Matches(this.stringExpression);
            String processingExpression = number.Replace(this.stringExpression, "");

            List<Int32> numbers = new List<Int32>();
            foreach (Match match in matches)
                numbers.Add(Convert.ToInt32(match.Value));

            result = numbers[0];
            for (int i = 1; i < matches.Count; i++)
            {
                switch (processingExpression[i - 1])
                {
                    case '+':
                        {
                            result += numbers[i];
                            break;
                        }
                    case '-':
                        {
                            result -= numbers[i];
                            break;
                        }
                    case '*':
                        {
                            result *= numbers[i];
                            break;
                        }
                    case '/':
                        {
                            result /= numbers[i];
                            break;
                        }
                    default:
                        {
                            throw new Exception("Error! ");
                        }
                }
            }
            return result;
            
        }
    }
}
