using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste da classe base Assignment
        Assignment tarefa1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(tarefa1.GetSummary());

        // Teste da classe derivada MathAssignment
        MathAssignment tarefa2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(tarefa2.GetSummary());
        Console.WriteLine(tarefa2.GetHomeworkList());

        // Teste da classe derivada WritingAssignment
        WritingAssignment tarefa3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(tarefa3.GetSummary());
        Console.WriteLine(tarefa3.GetWritingInformation());
    }
}