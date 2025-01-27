﻿using System.ComponentModel.DataAnnotations;

namespace FoodStore.Models
{
    public class FoodCategory : DeletableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
    }
}
