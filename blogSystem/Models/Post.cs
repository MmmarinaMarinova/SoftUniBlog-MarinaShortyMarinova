using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogSystem.Models
{
    public class Post
    {

        public Post(){
            this.Date = DateTime.Now;
            }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public String Title{ get; set; }

        [Required]        
        [DataType(DataType.MultilineText)]
        public String Body { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public string Author_Id { get; set; }
        [ForeignKey("Author_Id")]
        public ApplicationUser Author{ get; set; }
       

        public ICollection<Comment> Comments{ get; set; }
    }
}