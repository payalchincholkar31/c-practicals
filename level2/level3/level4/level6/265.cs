using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string input = Console.ReadLine();

        if (IsBalanced(input))
            Console.WriteLine("Balanced parentheses.");
        else
            Console.WriteLine("Not balanced.");
    }

    static bool IsBalanced(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if (!IsMatchingPair(top, ch))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    static bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}