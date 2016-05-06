using System;
namespace NamespaceTree
{
    public class ParseTree
    {
        Operator root;

        public ParseTree(string expression)
        {
            int i = 0;
            while (i < expression.Length)
            {
                if (expression[i] == '(')
                {
                    if (i == expression.Length - 1)
                        throw new UnexpectedSymbolException("Opening bracket at the end of expression.");
                   // try
                    //{
                        AddOperator(expression[i + 1]);
                        ++i;
                    //}
                    //catch(UnexpectedSymbolException e)
                    //{
                   //     Console.WriteLine(e.Message);
                    //}
                }
                else if (expression[i] != ')' && expression[i] != ' ')
                {
                    int number = 0;
                    while (expression[i] != ' ' && expression[i] != ')' && i < expression.Length - 1)
                    {
                        try
                        {
                            number = number * 10 + int.Parse(char.ToString(expression[i]));
                        }
                        catch (FormatException)
                        {
                            throw new UnexpectedSymbolException("Unknown symbol.");
                        }
                        ++i;
                    }
                    AddOperand(number);
                }
                ++i;
            }
        }

        private void AddOperator(char value)
        {
            Operator newOperator = new Operator();
            switch (value)
            {
                case '+':
                    newOperator = new AdditionOperator();
                    break;
                case '-':
                    newOperator = new SubtractionOperator();
                    break;
                case '*':
                    newOperator = new MultiplicationOperator();
                    break;
                case '/':
                    newOperator = new DivisionOperator();
                    break;
                default:
                    throw new UnexpectedSymbolException("There is must be an operator after a closing bracket.");
            }
            if (root == null)
            {
                root = newOperator;
                return;
            }
            bool isAdded = false;
            AddNode(newOperator, root, ref isAdded);
        }

        private void AddOperand(int value)
        {
            Operand newOperand = new Operand(value);
            bool isAdded = false;
            AddNode(newOperand, root, ref isAdded);
        }

        private void AddNode(INode node, Operator pointer, ref bool isAdded)
        {
            if (!isAdded)
            {
                if (pointer.LeftNode == null)
                {
                    pointer.LeftNode = node;
                    isAdded = true;
                    return;
                }
                if (pointer.LeftNode is Operator)
                {
                    Operator op = pointer.LeftNode as Operator;
                    AddNode(node, op, ref isAdded);
                }
            }
            if (!isAdded)
            {
                if (pointer.RightNode == null)
                {
                    pointer.RightNode = node;
                    isAdded = true;
                    return;
                }
                if (pointer.RightNode is Operator)
                {
                    Operator op = pointer.RightNode as Operator;
                    AddNode(node, op, ref isAdded);
                }
            }
        } 

        public string PrintTree()
        {
            string result = "";
            root.Print(ref result);
            return result;
        }

        public int CountTree() => root.Count();
    }
}

