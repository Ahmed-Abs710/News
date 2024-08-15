﻿using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string? Username {  get; set; }

        public string? Password { get; set; }

        public string? Email {  get; set; }

        public bool IsAdmin {  get; set; }

        public ICollection<Article>? Articles { get; set; }

        public ICollection<Comment>? comments { get;set; }
    }
}
