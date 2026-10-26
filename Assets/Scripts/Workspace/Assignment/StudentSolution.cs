using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            throw new NotImplementedException();
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            throw new NotImplementedException();
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            throw new NotImplementedException();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            throw new NotImplementedException();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            var stack = new Stack<char>();
            foreach (char c in str)
            {
                stack.Push(c);
            }

            string result = "";
            foreach (char c in stack)
            {
                result += c;
            }

            return result;
        }

        public bool ASN02_StackPalindrome(string str)
        {
            string reversed = ASN01_ReverseString(str);
            return str == reversed;
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
