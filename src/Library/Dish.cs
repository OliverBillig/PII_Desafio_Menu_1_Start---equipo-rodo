//------------------------------------------------------------------------------
// <copyright file="Dish.cs" company="Universidad Catolica del Uruguay">
//     Copyright (c) Programacion II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menu del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
    
        public Dish(string name, decimal price, bool isVegetarian)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
        }
    }
}