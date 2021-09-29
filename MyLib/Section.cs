using System;
using System.ComponentModel.DataAnnotations;

namespace MyLib
{

    public class Section{

        public string SectionId {get; set;}
        public string Name {get; set;}
        public Flight Flight {get; set;}

    }

}