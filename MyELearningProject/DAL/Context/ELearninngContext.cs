using MyELearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyELearningProject.DAL.Context
{
    public class ELearninngContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRegister> CourseRegisters { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ContactUs> ContactUss { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public object CourseLinks { get; internal set; }
    }
}