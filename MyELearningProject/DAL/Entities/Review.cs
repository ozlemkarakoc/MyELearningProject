using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Entities
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public int StrudentID { get; set; }
        public Student Student { get; set; }
        public int ReviewScore { get; set; }
        public int StudentID { get; internal set; }
    }
}