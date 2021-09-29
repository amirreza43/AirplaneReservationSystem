using System;
using System.Linq;
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
                            Console.WriteLine("Number of rows for this section:");
                            var secRow = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Price for the seats in this section:");
                            var secPrice = Int32.Parse(Console.ReadLine());
                            if(secName == "quit"){
                                break;
                            }
                            Section section= new Section(){ Flight = f, Rows = secRow, SectionId = secName };
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
                                        db.Add(seat);

                                    }

                                }

                            db.Add(section);
                            db.SaveChanges();
                        }
                        

                    }

                }else if(firstSelect == 2){

                }
            }

        }
    }
}
