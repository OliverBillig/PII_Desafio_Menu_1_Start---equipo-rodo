//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Dish burger = new Dish("Burger", 5.99, false);
            Dish salad = new Dish("Salad", 4.99, true);
            Menu menu = new Menu();
            menu.AddDish(burger);
            menu.AddDish(salad);
            Table oneTable = new Table(1);
            Waiter waiter = new Waiter("John");
            waiter.AssignTable(oneTable);
            oneTable.Occupy();
            waiter.TakeOrder(oneTable, burger);
            Console.WriteLine(
                 $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
                 $"y la atiende: {waiter.Name}");
            oneTable.Free();
            Console.WriteLine(
                 $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
            menu.ListaDishes();
        }
    }
}