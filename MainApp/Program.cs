using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using lib;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Database();

            while(true){
                Console.WriteLine("Type 1 if you're an admin");
                Console.WriteLine("Type 2 if you're a customer");
                var firstSelect = Int32.Parse(Console.ReadLine());

                if(firstSelect == 1){

                    Console.WriteLine("Type 1 to add a flight");
                    Console.WriteLine("Type 2 to check flight revenue");
                    Console.WriteLine("Type 3 to check how full your flights are");
                    Console.WriteLine("Type 4 to check the number of kids on flight");

                    var adminSelect = Int32.Parse(Console.ReadLine());

                    if(adminSelect == 1){
                        Console.WriteLine("Aircraft Type:");
                        var airType = Console.ReadLine();
                        Console.WriteLine("Departure Location:");
                        var depLoc = Console.ReadLine();
                        Console.WriteLine("Arrival Location:");
                        var arrLoc = Console.ReadLine();
                        Console.WriteLine("Flight Capacity:");
                        var fCap = Int32.Parse(Console.ReadLine());
                        Flight f = new Flight(){ AircraftType= airType, DepartureLoc= depLoc, ArrivalLoc=arrLoc, FlightCap =fCap, Revenue=0 };
                        db.Add(f);
                        db.SaveChanges();

                        while(true){
                            Console.WriteLine("Section Type: ( write quit when the sections are done)");
                            var secName = Console.ReadLine();
                            if(secName == "quit"){
                                break;
                            }
                            Console.WriteLine("Number of rows for this section:");
                            var secRow = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Price for the seats in this section:");
                            var secPrice = Int32.Parse(Console.ReadLine());
                            Section section= new Section(){ Flight = f, Rows = secRow, SectionId = secName };

                            db.Add(section);
                            db.SaveChanges();

                                var seatCol = "";
                                for(int i= 0; i< secRow; i++){
                                    for(int j=0; j<6; j++){
                                        switch (j)
                                        {
                                            case (0):
                                            seatCol = "A";
                                            break;
                                            
                                            case (1):
                                            seatCol = "B";
                                            break;

                                            case (2):
                                            seatCol = "C";
                                            break;

                                            case (3):
                                            seatCol = "D";
                                            break;

                                            case (4):
                                            seatCol = "E";
                                            break;

                                            case (5):
                                            seatCol = "F";
                                            break;

                                            default:
                                            break;

                                        }
                                        
                                        Seat seat = new Seat(){ price= secPrice, Row = (i+1), Column = seatCol, Section = section };
                                        Console.WriteLine(seat.Column, seat.Row, seat.price);
                                        db.Seats.Add(seat);
                                        db.SaveChanges();

                                    }

                                }

                            
                        }
                        

                    }else if(adminSelect == 2){

                        ShowFlights(db);

                        Console.WriteLine("Write the flight Id to check revenue:");
                        var adminFlightId = Int32.Parse(Console.ReadLine());

                        var f = db.Flights.Where(f => f.FlightNumber == adminFlightId).First();

                        Console.WriteLine($"Flight Id: {f.FlightNumber}, Revenue: {f.Revenue}");

                    }else if( adminSelect == 3 ){

                        ShowFlights(db);

                        Console.WriteLine("Write the flight Id to check the seats:");
                        var adminFlightId = Int32.Parse(Console.ReadLine());
                        
                        var empty = db.Seats.Where(s => s.Passenger.Name == null)
                        .Where(section => section.Section.Flight.FlightNumber == adminFlightId)
                        .ToList();
                       
                        var flightCap = db.Flights.Where(f => f.FlightNumber == adminFlightId).First().FlightCap;
                        var notEmpty = flightCap - empty.Count;
                        var purchased =  ((double)notEmpty/(double)flightCap)*100;

                        Console.WriteLine($"This is the percentage of the flight that has been filled: {purchased}%");
                    }else if(adminSelect == 4){
                         ShowFlights(db);

                        Console.WriteLine("Write the flight Id to check number of kids:");
                        var adminFlightId = Int32.Parse(Console.ReadLine());

                        var notEmpty = db.Seats.Where(s => s.Passenger.isKid == true)
                        .Include(s=> s.Section).Include(s => s.Passenger).Include(s => s.Section.Flight)
                        .Where(section => section.Section.Flight.FlightNumber == adminFlightId).ToList();
                        Console.WriteLine($"This flight has {notEmpty.Count} kids.");
                        foreach (var item in notEmpty)
                        {
                            Console.WriteLine($"the seat Id: {item.SeatId}, Passenger name: {item.Passenger.Name}");
                        }

                    }
    
                    

                }else if(firstSelect == 2){

                }
            }

        }

        public static void ShowFlights(Database db){
            Console.WriteLine("These are your flights:");
                        var flights = db.Flights.ToList();
                        foreach (var item in flights)
                        {
                            Console.WriteLine($"Flight Id: {item.FlightNumber}, Aircraft Type: {item.AircraftType}, Departure Location: {item.DepartureLoc}, Arrival Location: {item.ArrivalLoc}");
                        } 
        }
    }
}
