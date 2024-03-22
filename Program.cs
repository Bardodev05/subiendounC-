using System;

// Clase base para las operaciones
class Operacion
{
    public virtual double RealizarOperacion(double[] operandos)
    {
        // Implementación genérica (puede ser sobrescrita por las clases derivadas)
        return 0;
    }
}

// Clase para la operación de suma
class Suma : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        return operandos[0] + operandos[1];
    }
}

// Clase para la operación de resta
class Resta : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        return operandos[0] - operandos[1];
    }
}

// Clase para la operación de multiplicación
class Multiplicacion : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        double resultado = 1;
        foreach (double operando in operandos)
        {
            resultado *= operando;
        }
        return resultado;
    }
}

// Clase para la operación de división
class Division : Operacion
{
    public override double RealizarOperacion(double[] operandos)
    {
        if (operandos[1] != 0)
        {
            return operandos[0] / operandos[1];
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return double.NaN;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora básica");
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        int opcion = int.Parse(Console.ReadLine());

        // Pedir operandos
        Console.Write("Ingrese el primer operando: ");
        double operando1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo operando: ");
        double operando2 = double.Parse(Console.ReadLine());

        // Crear el arreglo de operandos
        double[] operandos = { operando1, operando2 };

        // Realizar la operación seleccionada
        Operacion operacion;
        switch (opcion)
        {
            case 1:
                operacion = new Suma();
                break;
            case 2:
                operacion = new Resta();
                break;
            case 3:
                operacion = new Multiplicacion();
                break;
            case 4:
                operacion = new Division();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        double resultado = operacion.RealizarOperacion(operandos);
        Console.WriteLine($"Resultado: {resultado}");
    }
}
