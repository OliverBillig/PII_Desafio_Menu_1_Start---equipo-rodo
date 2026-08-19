//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        public ArrayList dishes = new ArrayList();

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        public Dish GetDishByName(string name)
        {
            foreach (Dish platillo in dishes)
            {
                if (platillo.Name == name)
                {
                    return platillo;
                }
            }

            return null;
        }

        public Dish ListaDishes(Dish dish)
        {
            for (int i=0; i++; i<=dishes.Count)
            {
                Console.WriteLine(dishes[i]);
            }
        }

    }
}