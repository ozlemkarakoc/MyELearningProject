using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public String NameSurname { get; set; }

        public String Title { get; set; }

        public string ImageUrl { get; set; }

        public String Comment { get; set; }

        public bool Status { get; set; }

    }
}