using System;
using System.ComponentModel.DataAnnotations;

namespace lib
{

    public class Passenger{
        [Key]
        public string Name{get; set;}
        public bool isKid{get; set;}
    }

}