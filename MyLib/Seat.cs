using System;
using System.ComponentModel.DataAnnotations;

namespace MyLib
{

    public class Seat{

        public int SeatId{get; set;}
        public decimal price{get; set;}
        public Passenger Passenger{get; set;}

    }

}