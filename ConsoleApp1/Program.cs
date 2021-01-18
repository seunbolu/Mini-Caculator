using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int Sum;
            char Oper;

            Console.Write(" Enter the First Number:");
            firstNum= int.Parse(Console.ReadLine());

            Console.Write(" Enter the Operator:");
            Oper = Convert.ToChar(Console.ReadLine());

            Console.Write(" Enter the Second Number:");
            secondNum = int.Parse(Console.ReadLine());

            if (Oper == '+')
            {
                Sum = firstNum + secondNum;
                Console.WriteLine("The Total =" + Sum);
            }

            else if (Oper == '-')
            {
                Sum = firstNum - secondNum;
                Console.WriteLine("The Total =" + Sum);

            }

            else if (Oper == '/')
            {
                Sum = firstNum / secondNum;
                Console.WriteLine("The Total =" + Sum);

            }

            else if (Oper == '*')
            {
                Sum = firstNum * secondNum;
                Console.WriteLine("The Total =" + Sum);

            }
            else if (Oper == '%')
            {
                Sum = firstNum % secondNum;
                Console.WriteLine("The Total =" +  Sum);

            }


        }
    }
}
