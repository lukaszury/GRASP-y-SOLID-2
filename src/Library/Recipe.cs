//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        // Agrego una property para poder acceder a los steps desde fuera de la clase Recipe
        public ArrayList Steps
        {
            get
            {
                return this.steps;
            }
        }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /*
        La receta va a ser la responsable de calcular del precio total, ya que es quien tiene la cantidad de pasos necesarios
        para poder completarla
        */
        public double GetProductsCost()
        {
            double total = 0;
            foreach (Step s in this.steps)
            {
                total += s.costPerStep();
            }
            return total;
        }

        /*
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
        */
    }
}