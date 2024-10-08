﻿using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<Article>? Articles { get; set; }
    }
}
