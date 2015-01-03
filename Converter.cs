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

        public String Result()
        {
            Regex pattern = new Regex(@"\d+[\*\/]\d+");
            String tmpExpression = this.expression.Substring(0);
            MatchCollection matches = pattern.Matches(tmpExpression);
            foreach (Match item in matches)
            {
                tmpExpression = tmpExpression.Replace(item.Value, String.Format("({0})", item.Value));
            }
            return tmpExpression;
        }
    }
}
