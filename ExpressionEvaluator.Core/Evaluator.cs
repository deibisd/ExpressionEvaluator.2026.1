using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpressionEvaluator.Core
{
    public class Evaluator
    {
        public static double Evaluate(string infix)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                CultureInfo.InvariantCulture;

            var postfix = InfixToPostfix(infix);
            return EvaluatePostfix(postfix);
        }

        private static List<string> InfixToPostfix(string infix)
        {
            List<string> output = new List<string>();
            Stack<char> stack = new Stack<char>();

            string numero = "";

            foreach (char item in infix)
            {
                if (char.IsDigit(item) || item == '.')
                {
                    if (item == '.' && numero.Contains("."))
                        throw new Exception("Número decimal inválido");

                    numero += item;
                }
                else
                {
                    if (numero != "")
                    {
                        if (numero == ".")
                            throw new Exception("Número decimal inválido");

                        output.Add(numero);
                        numero = "";
                    }

                    if (IsOperator(item))
                    {
                        if (item == '(')
                        {
                            stack.Push(item);
                        }
                        else if (item == ')')
                        {
                            while (stack.Count > 0 && stack.Peek() != '(')
                            {
                                output.Add(stack.Pop().ToString());
                            }
                            if (stack.Count > 0) stack.Pop();
                        }
                        else
                        {
                            while (stack.Count > 0 &&
                                   stack.Peek() != '(' &&
                                   PriorityStack(stack.Peek()) >= PriorityInfix(item))
                            {
                                output.Add(stack.Pop().ToString());
                            }

                            stack.Push(item);
                        }
                    }
                }
            }

            if (numero != "")
            {
                if (numero == ".")
                    throw new Exception("Número decimal inválido");

                output.Add(numero);
            }

            while (stack.Count > 0)
            {
                output.Add(stack.Pop().ToString());
            }

            return output;
        }

        private static int PriorityStack(char item)
        {
            switch (item)
            {
                case '^': return 3;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 0;
                default: throw new Exception("Sintax error.");
            }
        }

        private static int PriorityInfix(char item)
        {
            switch (item)
            {
                case '^': return 4;
                case '*': return 2;
                case '/': return 2;
                case '+': return 1;
                case '-': return 1;
                case '(': return 5;
                default: throw new Exception("Sintax error.");
            }
        }

        private static double EvaluatePostfix(List<string> postfix)
        {
            Stack<double> stack = new Stack<double>();

            foreach (string item in postfix)
            {
                double numero;

                if (double.TryParse(item, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
                {
                    stack.Push(numero);
                }
                else
                {
                    // 🔥 VALIDACIÓN IMPORTANTE (no rompe tu lógica)
                    if (stack.Count < 2)
                        throw new Exception("Sintax error.");

                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (item[0])
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/': stack.Push(a / b); break;
                        case '^': stack.Push(Math.Pow(a, b)); break;
                        default: throw new Exception("Sintax error.");
                    }
                }
            }

            return stack.Pop();
        }

        private static bool IsOperator(char item)
        {
            return "+-*/^()".Contains(item);
        }
    }
}