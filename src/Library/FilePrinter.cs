//Aplicamos el patrón de polimorfismo en la operación de la interface Iprinter tanto en esta clase como en ConsolePrinter
using System;
using System.IO;
namespace Full_GRASP_And_SOLID.Library
{

    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe Recipe)
        {
            File.WriteAllText("Recipe.txt", Recipe.GetTextToPrint());
        }
    }
}