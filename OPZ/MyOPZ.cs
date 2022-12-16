using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OPZ
{
    public class MyOPZ
    {
        Stack<string> calc = new Stack<string>(); 
        Stack<string> operators = new Stack<string>(); //операторы
        Dictionary<string, int> operatorsDict = new Dictionary<string, int>() { ["("] = 0, ["+"] = 1, ["-"] = 1, ["*"] = 2, ["/"] = 2, ["^"] = 3 };
        string[] num = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        List<string> outs = new List<string>();

        public string Opz(string stroka)
        {
            string cifra = "";
            foreach (char i in stroka)
            {
                if (num.Contains(i.ToString()))
                {
                    cifra += i;
                }
                else if (operatorsDict.ContainsKey(i.ToString()))
                {
                    if (cifra != "")
                    {
                        outs.Add(cifra);
                        cifra = "";
                    }
                    if (operators.Count() > 0 && i != '(' && operatorsDict[i.ToString()] <= operatorsDict[operators.Peek()])
                    {
                        outs.Add(operators.Pop());
                    }
                    operators.Push(i.ToString());
                }
                else if (i == ')')
                {
                    if (cifra != "")
                    {
                        outs.Add(cifra);
                        cifra = "";
                    }

                    string pop_value = operators.Pop();
                    while (pop_value != "(")
                    {
                        outs.Add(pop_value);
                        pop_value = operators.Pop();
                    }
                }
            }
            if (cifra != "")
            {
                outs.Add(cifra);
            }
            while (operators.Count() > 0)
            {
                outs.Add(operators.Pop());
            }
            foreach(string i in outs)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            return Calc();
        }
        private string Calc()
        {
            foreach(string i in outs)
            {
                if(!operatorsDict.ContainsKey(i))
                {
                    calc.Push(i);
                }
                else
                {
                    string otv;
                    string num1 = calc.Pop();
                    string num2 = calc.Pop();
                    if(i == "^")
                    {
                        otv = Math.Pow(float.Parse(num2), float.Parse(num1)).ToString();
                    }
                    else
                    {
                        otv = new DataTable().Compute(num2 + i + num1, "").ToString();
                    }
                    calc.Push(otv);
                }
            }
            return calc.Pop();
        }
         
    }
}
