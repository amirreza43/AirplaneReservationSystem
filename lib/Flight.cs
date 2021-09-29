using System;
using System.ComponentModel.DataAnnotations;

namespace lib
{
    
    public class Flight{

        [Key]
        public int FlightNumber {get; set;}
        public string AircraftType {get; set;}
        public string DepartureLoc {get; set;}
        public string ArrivalLoc {get; set;}
        public int FlightCap {get; set;}
        public decimal Revenue {get; set;}

    }

}