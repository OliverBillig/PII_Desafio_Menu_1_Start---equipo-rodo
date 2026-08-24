//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

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
            foreach (Dish dish in dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }

            return null;
        }

        public void ListaDishes()
        {
            foreach (Dish dish in dishes)
            {
                Console.WriteLine($"{dish.Name} - ${dish.Price}");
            }
        }

    }
}