//------------------------------------------------------------------------------
// <copyright file="Waiter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        public string Name {get; set;}
        private ArrayList assignedTables = new ArrayList();

        public Waiter(string name)
        {
            Name = name;
            assignedTables = new ArrayList();
        }

        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }

    }
}