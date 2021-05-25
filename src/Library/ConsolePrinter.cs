//Aplicamos el patrón de polimorfismo en la operación de la interface Iprinter tanto en esta clase como en FilePrinter
using System;
namespace Full_GRASP_And_SOLID.Library
{

    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe Recipe)
        {
            Console.WriteLine(Recipe.GetTextToPrint());
        }
    }
}