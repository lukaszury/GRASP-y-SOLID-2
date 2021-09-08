//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        /*
        Le asignamos la responsabilidad de experto al paso, ya que es el quien conoce los productos, su cantidad, el costo de la maquinaria utilizada
        y la cantidad de tiempo que se necesito de la misma
        */
        public double costPerStep()
        {
            double costPerIngridient = (this.Input.UnitCost * this.Quantity);
            double costEquipPerTime = (this.Equipment.HourlyCost * (this.Time/60));
            return (costPerIngridient + costEquipPerTime);
        }
    }
}