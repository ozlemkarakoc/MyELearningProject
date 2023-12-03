using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AddressInfo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}