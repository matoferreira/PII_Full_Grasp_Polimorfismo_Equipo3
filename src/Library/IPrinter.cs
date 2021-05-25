//Aplicamos el patrón de polimorfismo en la operación de la interface Iprinter tanto en esta clase como en ConsolePrinter
//Se crea la interface Iprinter que contiene la operación PrintTicket para que cumpla
//con el Principio de SRP, al tener una sola razón de cambio.
//Al tener una operación polimórfica que varía su comportamiento segun la clase que la implemente.
//De esta manera podemos eliminar AllinOnePrinter que vulneraba el principio de SRP, que lo hacía dificil de mantener.
using System;
namespace Full_GRASP_And_SOLID.Library
{

    public interface IPrinter
    {
        void PrintRecipe(Recipe Recipe);
    }
}