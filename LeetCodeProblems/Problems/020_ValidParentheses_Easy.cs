using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems
{
    //https://leetcode.com/problems/valid-parentheses/
    /*
     * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
     */
    class _020_ValidParentheses_Easy
    {
        public Dictionary<char, char> dict = new Dictionary<char, char> { { ')', '(' }, { '}', '{' }, { ']', '[' } };
        public Stack<char> stk = new Stack<char>();
        public void _020_ValidParenteses_Easy() {

        }
        public bool isValid(string s)
        {
            int i = 0;
            while (i < s.Length)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (stk.Count == 0) return false;
                    if (dict[s[i]] != stk.Pop()) return false;
                }
                else
                    stk.Push(s[i]);
                i++;
            }
            if (stk.Count == 0) return true;
            else return false;
        }
    }

}
