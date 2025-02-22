﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceptiKatalog;

namespace ReceptiKatalog
{
    public class Users
    {
        [Key]

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Recipe
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cooking_Description { get; set; }
        public int Autor_Id { get; set; }
        public DateTime Date_Add { get; set; }
        public string Type_Id { get; set; }
    }
}
 