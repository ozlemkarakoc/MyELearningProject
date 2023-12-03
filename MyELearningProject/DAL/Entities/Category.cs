using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public List<Course> Courses { get; set; }
    }
}