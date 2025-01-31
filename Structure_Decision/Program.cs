using System.Numerics;
using Structure_Decision;

BaseClasss baseClasss = new BaseClasss();
Console.WriteLine("1 - Continue.");
int continueExit = Convert.ToInt32(Console.ReadLine());

while(continueExit == 1)
{
    Console.WriteLine("Choose one option below:");
    Console.WriteLine("1 - Biggest number. 2 - Avarage. 3 - Salry ajustment");
    int option = Convert.ToInt32(Console.ReadLine());

    switch(option) 
 {
    case 1:
    Console.WriteLine("Input three numbers:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    int number3 = Convert.ToInt32(Console.ReadLine());
    baseClasss.CalculateBiggestNumber(number1, number2, number3);
    break;

    case 2:
    Console.WriteLine("Enter with two notes from 0 to 10");
    double firstNote = Convert.ToDouble(Console.ReadLine());
    double secondNote = Convert.ToDouble(Console.ReadLine());
    baseClasss.CalculateAvarage(firstNote, secondNote);
    break;

    case 3:
    Console.WriteLine("Input the current salary");
    double salary = Convert.ToDouble(Console.ReadLine());
    baseClasss.SalaryReajustment(salary);
    break;

    default:
        throw new Exception(" You exited for choose a wrong option");
    
 }
 
};

