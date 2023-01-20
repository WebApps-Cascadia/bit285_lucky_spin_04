﻿using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player //TODO: Annotate the Player properties as described in section 3.
    {
        [Required(ErrorMessage = "Name required")]
        public string FirstName { get; set; }

        [Range(1,9, ErrorMessage = "Number required")]
        public int Luck { get; set; }
    }
}