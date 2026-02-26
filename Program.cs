namespace Carlos_Mota_Carela_tarea_1
{
    using System;

    class Program
    {
        static double CalcularISR(double sueldoAnual)
        {
            // el isr
            double exento = 416220.00;
            double tramo1 = 624329.00;
            double tramo2 = 867123.00;

            if (sueldoAnual <= exento)
            {
                return 0; 
            }
            else if (sueldoAnual <= tramo1)
            {
                double excedente = sueldoAnual - exento;
                return excedente * 0.15;
            }
            else if (sueldoAnual <= tramo2)
            {
                double excedente = sueldoAnual - tramo1;
                return 31216 + (excedente * 0.20);
            }
            else
            {
                double excedente = sueldoAnual - tramo2;
                return 79776 + (excedente * 0.25);
            }
        }

        static void Main()
        {
            Console.WriteLine("Cálculo del ISR");

            Console.Write("Ingrese el sueldo anual del empleado: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            double isr = CalcularISR(sueldo);

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Sueldo anual: $" + sueldo.ToString("N2"));

            if (isr == 0)
                Console.WriteLine("ISR a pagar: N/A ");
            else
                Console.WriteLine("ISR a pagar:  $" + isr.ToString("N2"));
        }
    }
}
