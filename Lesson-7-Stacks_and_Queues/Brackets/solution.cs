using System;
using System.Collections.Generic;

class Solution {
    public int solution(string candidate) {

        if (candidate.Length == 0)
            return 1;

        var characterStack = new Stack<char>();

        foreach (char i in candidate) {
            if (i == '{' || i == '[' || i == '(')
                characterStack.Push(i);
            else if (i == '}') {
                if (!characterStack.IsEmpty() && characterStack.Peek() == '{')
                    characterStack.Pop();
                else
                    return 0;
            }
            else if (i == ']') {
                if (!characterStack.IsEmpty() && characterStack.Peek() == '[')
                    characterStack.Pop();
                else
                    return 0;
            }
            else if (i == ')') {
                if (!characterStack.IsEmpty() && characterStack.Peek() == '(')
                    characterStack.Pop();
                else
                    return 0;
            }
        }
        return characterStack.Count == 0 ? 1 : 0;
    }
}

public static class StackExtensions
{
    public static bool IsEmpty<T>(this Stack<T> stack)
    {
        return stack.Count == 0;
    }
}
