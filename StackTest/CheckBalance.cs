using System.Collections.Generic;


/* to test
 *       public static void Main(string[] args)
        {
            bool b = CheckBalance.BalanceCheck();
            if (b)
                Console.WriteLine("expression balanced");
            else
                Console.WriteLine("expression unbalanced");
        }
 * 
 */
namespace seriesone.StackTest
{
    class CheckBalance
    {
        public static bool BalanceCheck()
        {
            string str = "(([1] + [2])){3}[4]";
            //string str = "";
            //string str = "(()"
            string op = "({[<";
            string cl = ")}]>";
            Stack<char> ch = new Stack<char>();

            if (str.Length == 0)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (op.Contains(str[i].ToString()))
                {
                    ch.Push(str[i]);
                }
                else if (cl.Contains(str[i].ToString()))
                {
                    if (ch.Count == 0)
                        return false;

                    var stTop = ch.Peek();

                    if ((str[i].Equals(')') && stTop.Equals('(')) || (str[i].Equals('}') && stTop.Equals('{'))
                        || (str[i].Equals(']') && stTop.Equals('[')) || (str[i].Equals('>') && stTop.Equals('<')))
                        ch.Pop();
                    else
                        break;
                }
            }

            if (ch.Count == 0)
                return true;
            else
                return false;
        }
    }
}
