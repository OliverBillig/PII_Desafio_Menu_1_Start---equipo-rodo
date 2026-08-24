//------------------------------------------------------------------------------
 // <copyright file="Table.cs" company="Universidad Católica del Uruguay">
 // Copyright (c) Programación II. Derechos reservados.
 // </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private ArrayList order = new ArrayList();

        public int Number { get; }

        public bool IsOccupied { get; private set; }

        public bool IsTakeOut { get; private set; }

        public Table(int number)
        {
            this.Number = number;
            this.IsOccupied = false;
            this.IsTakeOut = false;
        }

        public void Occupy()
        {
            this.IsOccupied = true;
        }

        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }

        public void TakeOut()
        {
            this.IsTakeOut = true;
        }

        public void Taked()
        {
            this.IsTakeOut = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }


    }
}
