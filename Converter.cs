using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MathExpression
{
    public class PriorityConverter
    {
        private String expression;

        public PriorityConverter(String expression)
        {
            this.expression = expression;
        }

        private Int32  SearchIndex(string tmpExpression, Int32 MatchIndex)
        {
                int i=0;
                for ( i=MatchIndex-1; tmpExpression[i] == ')'; i--);
            return i;
        }
        public String Result()
        {
            //Regex pattern = new Regex(@"\(?\d+[\*\/]\d+\)?");
            Regex pattern = new Regex(@"[\*\/]\d+\)?");
            String tmpExpression = this.expression.Substring(0);
            MatchCollection matches = pattern.Matches(tmpExpression);
            for (int i = 0; i < matches.Count; i++)
            {
                string temp = matches[i].Value;
                Int32 num = SearchIndex(tmpExpression, matches[i].Index);
                temp = tmpExpression.Substring(num, matches[i].Index - num + matches[i].Value.Length);

                if ((num != 0 && tmpExpression[num - 1] != '(' )|| num == 0)
                {
                    tmpExpression = tmpExpression.Replace(temp, String.Format("({0})", temp));
                    matches = pattern.Matches(tmpExpression);
                }
 
            }
            return tmpExpression;
        }
    }
}
