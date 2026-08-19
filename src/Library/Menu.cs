//------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System.Collections;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private ArrayList dishes = new ArrayList();

        public void AddDish(Dish platillo)
        {
            dishes.Add(platillo);
        }

        public void RemoveDish(Dish platillo)
        {
            dishes.Remove(platillo);
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
    }
}