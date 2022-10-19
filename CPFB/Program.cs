using CPFB.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPFB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var num1 in DBConnection.connection.Number.ToList())
            {
                foreach (var oper in DBConnection.connection.Operator.ToList())
                {
                    foreach (var num2 in DBConnection.connection.Number.ToList())
                    {
                        if(num1.Number_ID != num2.Number_ID)
                        {
                            string str = $"{num1.Number1}{oper.Operator1}{num2.Number1}";
                            double rezult = Convert.ToDouble(new DataTable().Compute(str, ""));
                            Answer answer = new Answer();
                            answer.FNumber_ID = num1.Number_ID;
                            answer.SNumber_ID = num2.Number_ID;
                            answer.Operator_ID = oper.Operator_ID;
                            answer.Answer1 = rezult;
                            DBConnection.connection.Answer.Add(answer);
                            DBConnection.connection.SaveChanges();
                        }
                    }
                }
            }
            try
            {
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine(ex);
            }
            while(true)
            {
                int i = 0;
            }
        }
    }
}
