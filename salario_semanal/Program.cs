// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese el salario por hora");
double salarioHora = double.Parse(Console.ReadLine());

Console.WriteLine("ingrese el numero de horas trabajadas por semana");
double horasTrabajadas = double.Parse(Console.ReadLine());

double sueldoTotal;
if (horasTrabajadas <= 40)
{
    sueldoTotal = salarioHora * horasTrabajadas;
}
else
{
    double horasExtras = horasTrabajadas - 40;
    double salarioExtra = salarioHora * 1.5;
    sueldoTotal = (salarioHora * 40) + (salarioExtra * horasExtras);
}
Console.WriteLine($"el sueldo total semanal es: S/{sueldoTotal}");