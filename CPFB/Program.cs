using CPFB.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPFB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var num1 in DBConnection.connection.Numbers)
            {
                foreach (var oper in DBConnection.connection.Operators)
                {
                    foreach (var num2 in DBConnection.connection.Numbers)
                    {
                        if(num1.Number_ID != num2.Number_ID)
                        {
                            Numbers number1 = new Numbers()
                            {
                                Number = num1.Number,
                                Number_ID = num1.Number_ID
                            };
                            Numbers number2 = new Numbers()
                            {
                                Number = num2.Number,
                                Number_ID = num2.Number_ID
                            };
                            Operators operator1 = new Operators()
                            {
                                Operator_ID = oper.Operator_ID,
                                Operator = oper.Operator
                            };
                            string str = $"{num1.Number}{oper.Operator}{num2.Number}";
                            double rezult = Convert.ToDouble(new DataTable().Compute(str, ""));
                            Answer answer = new Answer()
                            {
                                Number_ID = number1.Number_ID,
                                Operator_ID = operator1.Operator_ID,
                                Answer1 = rezult
                            };
                            DBConnection.connection.Answer.Add(answer);
                            DBConnection.connection.SaveChanges();
                        }
                    }
                }
            }
            try
            {
            }
            catch
            {

            }
        }
    }
}
