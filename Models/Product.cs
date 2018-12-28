using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNETCoreGettingStarted.Models
{
    //[Table("Products")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
        [DisplayName("Manufacturing Date")]
        public DateTime MfgDate{get;set;}
        public int Quantity{get;set;}   
        public int? CategoryId{get;set;} 
        public Category Category{get;set;}   
    }
}