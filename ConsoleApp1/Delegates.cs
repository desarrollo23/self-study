using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Delegates
    {
        private delegate void PrintFormat(string message);


        private void PrintFormatMethod(string message)
        {
            Console.WriteLine($"Hola, este es el mensaje: {message}. Saludos!");
        }

        public void Main(string message)
        {
            Console.WriteLine("Hola, estos es delegados");
            Console.WriteLine("Imprimiremos un mensaje con formato");

            Action<string> actionPrint = delegate (string value)
            {
                Console.WriteLine($"Mensaje directo con delegate: {value}. Saludos!!!!");
            };

            Action<string> actionPrintLambda = value => Console.WriteLine($"Mensaje con Lambda: {value}");

            actionPrint(message);
            actionPrintLambda(message);

            AnotherFunction(actionPrint);

        }

        private void AnotherFunction(Action<string> actionPrint)
        {
            actionPrint("Otro mensaje desde otra funcion");
        }

        public void FunctionsMethod()
        {
            Func<string, bool> validateString = str =>
            {
                return str.StartsWith("ol:");
            };

            var result = validateString("ol:ddd");
        }
    }

    public static class FiltersExtension
    {
        //public static bool<T> ValidateSomething<T>(this T source, Func<T, bool> predicate)
        //{

        //}
    }
}
