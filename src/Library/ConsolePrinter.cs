using System;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /*
        La clase ConsolePrinter va a ser la encargada de imprimir las recetas, ya que
        si lo hiciese la clase Recipe no estaria cumpliendo el SRP.
        El codigo fue modificado para poder imprimir los datos de la receta, remplazando "this"
        por la receta que recibida por parametro y utilizando un StringBuilder
        */
        public void PrintRecipe(Recipe recipe)
        {
            StringBuilder stringBuilder = new StringBuilder($"Receta de {recipe.FinalProduct.Description}\n");
            // Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.Steps)
            {
                //Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    //$"usando '{step.Equipment.Description}' durante {step.Time}");
                stringBuilder.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            stringBuilder.Append($"Total: {recipe.GetProductsCost()}\n");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}