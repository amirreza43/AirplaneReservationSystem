using System;
using System.ComponentModel.DataAnnotations;

namespace lib
{

    public class Section{

        public string SectionId {get; set;}
        public int Rows{get; set;}
        public Flight Flight {get; set;}

    }

}