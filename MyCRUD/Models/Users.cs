using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System;

namespace MyCRUD.Models
{
    public class Users
    {

        [Key]
        public int userID { get; set; }

        
        [Required(ErrorMessage = "First Name Required")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = " Invalid Email Address")]
        public string emailID { get; set; }


        [Required(ErrorMessage = "Contact Number required")]
        [RegularExpression(@"^((\\+|00)(\\d{1,3})[\\s-]?)?(\\d{10})$", ErrorMessage = "Invalid Phone number")]
        public string phoneNumber { get; set; }

        public virtual ICollection<File> FileData { get; set; }

    }
    public class userDBContext : DbContext
    {
        public userDBContext() : base("userDBContext")
        {

        }
        public DbSet<Users> UserData { get; set; }
        public DbSet<File> FileData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}