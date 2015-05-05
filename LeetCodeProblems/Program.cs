using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProblems.Problems;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new _020_ValidParentheses_Easy();
            Console.WriteLine(solution.isValid("()[]{}").ToString());
            Console.Read();
        }
    }
}
