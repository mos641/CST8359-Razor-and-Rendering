/*
 * Person has the following properties:
 *      First Name -- string
 *      Last Name -- string
 *      Age -- int
 *      Email Address -- string
 *      Password -- string
 *      Description of person -- string
 *      
 */

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(255)]
        [BindProperty(Name = "fName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [BindProperty(Name = "lName")]
        public string LastName { get; set; }

        [Required]
        [Range(0, 120)]
        [BindProperty(Name = "age")]
        public int Age { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(255)]
        [BindProperty(Name = "password")]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        [BindProperty(Name = "desc")]
        public string Description { get; set; }
    }
}
