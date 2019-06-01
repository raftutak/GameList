using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GL.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public Gender PlayerGender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public enum Gender
        {
            Kobieta,
            Mężczyzna
        }
    }
}