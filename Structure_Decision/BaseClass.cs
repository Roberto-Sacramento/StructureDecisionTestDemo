using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Structure_Decision
{
    public class BaseClasss
    {
        public void CalculateBiggestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"The biggest number is the first with the value: {firstNumber}");
            }

            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"The biggest number is the second with the value: {secondNumber}");
            }

            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine($"The biggest number is the third with the value: {thirdNumber}");
            }

            else
            {
                Console.WriteLine($"The numbers are equals");
            }

        }

        public void CalculateAvarage(double note1, double note2)
        {
            double avarage = (note1 + note2) / 2;
            if (avarage == 7)
            {
                Console.WriteLine($"Passed with avarege:{avarage}");
            }
            else if (avarage < 7)
            {
                Console.WriteLine($"Isn't pased with note: {avarage}");
            }

            else
            {
                Console.WriteLine($"Passed with max note: {avarage}");
            }
        }

        public void SalaryReajustment(double currentSalary)
        {
            try
            {

                if (currentSalary <= 2800)
                {
                    double salaryBeforeReajustment = currentSalary;
                    double salaryAfterReajustment = currentSalary + ( currentSalary * 20/100 );
                    double readjustment = salaryAfterReajustment - currentSalary;
                    double percentReadjustment = (20/currentSalary) * 100;
                    Console.WriteLine("_______________RESULTS______________");
                    Console.WriteLine($"Salary before applayed adjustment: {salaryBeforeReajustment}");
                    Console.WriteLine($"Percenual of adjustment: {percentReadjustment}");
                    Console.WriteLine($"Value of adjustment: {readjustment}");
                    Console.WriteLine($"New salary after adjustment: {salaryAfterReajustment}");
                }
                else if (currentSalary >= 2800 || currentSalary <= 7000)
                {
                    double salaryAfterReajustment = currentSalary + (currentSalary / 100) * 15;
                    double readjustment = (currentSalary * 15 / 100);
                    double percentReadjustment = (currentSalary / 100) * 0.15;
                    double salaryBeforeReajustment = currentSalary;
                    Console.WriteLine($"Salary before applayed adjustment {salaryBeforeReajustment}");
                    Console.WriteLine($"Percenual of adjustment {percentReadjustment}%");
                    Console.WriteLine($"Value of adjustment {readjustment}");
                    Console.WriteLine($"New salary after adjustment {salaryAfterReajustment}");
                }
                else if (currentSalary >= 7000 || currentSalary <= 15000)
                {
                    double salaryAfterReajustment = currentSalary + (currentSalary * 10 / 100);
                    double readjustment = (currentSalary * 10 / 100);
                    double percentReadjustment = 0.10 *(currentSalary/100);
                    double salaryBeforeReajustment = currentSalary;
                    Console.WriteLine($"Salary before applayed adjustment {salaryBeforeReajustment}");
                    Console.WriteLine($"Percenual of adjustment {percentReadjustment}%");
                    Console.WriteLine($"Value of adjustment {readjustment}");
                    Console.WriteLine($"New salary after adjustment {salaryAfterReajustment}");
                }

                else if (currentSalary > 15000)
                {
                    double salaryAfterReajustment = currentSalary + (currentSalary * 5 / 100);
                    double readjustment = salaryAfterReajustment - currentSalary ;
                    double percentReadjustment = 0.5 *(currentSalary/100);
                    double salaryBeforeReajustment = currentSalary;
                    Console.WriteLine($"Salary before applayed adjustment {salaryBeforeReajustment}");
                    Console.WriteLine($"Percenual of adjustment {percentReadjustment}%");
                    Console.WriteLine($"Value of adjustment {readjustment}");
                    Console.WriteLine($"New salary after adjustment {salaryAfterReajustment}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Something went wrong");
            }

            finally
            {
                Console.WriteLine("The program finished");
            }
        }


    }
}