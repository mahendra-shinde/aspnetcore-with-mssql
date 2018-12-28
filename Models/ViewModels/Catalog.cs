using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNETCoreGettingStarted.Models
{
    public class Catalog
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public double  Price {get;set;}   
        public int Quantity {get;set;}
        [DisplayName("Manufacturing Date")]
        public DateTime MfgDate{get;set;}
        public string CategoryName{get;set;}   

    }
}