using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebApp.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; } //[Key] ID's that this is the primary key.
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}