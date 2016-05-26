using System;
using Stacks;

namespace hw6_1
{
    public class Calculator
    {
        public static int Calculate(string expression)
        {
            int firstNumber = 0;
            int i = 0;
            bool isNegative = false;

            if (expression[0] == '-')
                {
                    isNegative = true;
                    ++i;
                }

            while (expression[i] >= '0' && expression[i] <= '9')
            {
                firstNumber = firstNumber * 10 + (int)expression[i] - 48;
                ++i;
                if (i == expression.Length)
                {
                    if (isNegative)
                    {
                        firstNumber = 0 - firstNumber;
                    }
                    return firstNumber;
                }
            }

            if (isNegative)
            {
                firstNumber = 0 - firstNumber;
            }

            int OperationPlace = i;
            ++i;
            int secondNumber = 0;

            while (i < expression.Length)
            {
                secondNumber = secondNumber * 10 + (int)expression[i] - 48;
                ++i;
            }

            var calc = new StackCalculator(new Stack());
            calc.Push(firstNumber);
            calc.Push(secondNumber);
            switch (expression[OperationPlace])
            {
                case '/':
                    calc.Divide();
                    break;
                case '*': 
                    calc.Multiply();
                    break;
                case '+':
                    calc.Add();
                    break;
                case '-':
                    calc.Subtract();
                    break;
            }
            return calc.Result();
        }
    }
}

