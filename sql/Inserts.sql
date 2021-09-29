-- insert into FLights ( AircraftType, DepartureLoc, ArrivalLoc, FlightCap, Revenue) values ("Airbus A350", "Houston, TX", "Hartford, CT", 30, 0 );
-- insert into FLights ( AircraftType, DepartureLoc, ArrivalLoc, FlightCap, Revenue) values ("BOEING 737 MAX", "Los Angeles, CA", "New York, NY", 30, 0);
-- insert into FLights ( AircraftType, DepartureLoc, ArrivalLoc, FlightCap, Revenue) values ("BOEING 747", "Newark, NJ", "Las Vegas, NV", 24, 0 );
-- -- 
-- insert into Sections ( SectionId, FlightNumber, Rows ) values ( "First Class 1", 1, 1);--6 
-- insert into Sections ( SectionId, FlightNumber, Rows ) values ( "Second Class 1", 1, 2); --12
-- insert into Sections ( SectionId, FlightNumber, Rows ) values ( "Third Class 1", 1, 2); --12

-- insert into Sections ( SectionId, FlightNumber, Rows ) values ( "First Class 2", 2, 1);
-- insert into Sections ( SectionId, FlightNumber, Rows ) values ( "Second Class 2", 2, 2);
-- insert into Sections ( SectionId, FlightNumber, Rows ) values ( "Third Class 2" , 2, 2);

-- insert into Sections ( SectionId, Name, FlightNumber ) values ( "First Class", "C", 3);
-- insert into Sections ( SectionId, Name, FlightNumber ) values ( "First Class", "C", 3);
-- insert into Sections ( SectionId, Name, FlightNumber ) values ( "First Class", "C", 3);

-- insert into Passengers (Name, isKid) VALUES ("John", false);
-- insert into Passengers (Name, isKid) VALUES ("Jane", false);
-- insert into Passengers (Name, isKid) VALUES ("Tim", true);
-- insert into Passengers (Name, isKid) VALUES ("Jack", true);
-- insert into Passengers (Name, isKid) VALUES ("Ariana", false);

-- insert into Passengers (Name, isKid) VALUES ("David", false);
-- insert into Passengers (Name, isKid) VALUES ("Kim", false);
-- insert into Passengers (Name, isKid) VALUES ("Rose", true);
-- insert into Passengers (Name, isKid) VALUES ("Marvin", true);
-- insert into Passengers (Name, isKid) VALUES ("Sean", false);

-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (300 ,"John", "First CLass 1", 1, "A");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (300 ,"Jane", "First Class 1", 1, "B");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (200 ,"Tim", "Second Class 1", 2, "F");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (200 ,"Jane", "Second Class 1", 3, "F");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (100 ,"Ariana", "Third Class 1", 4, "B");

-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (300 ,"David", "First Class 2", 1, "B");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (200 ,"Kim", "Second Class 2", 2, "C");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (100 ,"Rose", "Third Class 2", 4, "A");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (100 ,"Marvin", "Third Class 2", 5, "D");
-- insert into Seats (price, passengerName, SectionId, Row, Column) VALUES (100 ,"Sean", "Third Class 2", 5, "E");

-- insert into Seats (price,  SectionId, Row, Column) VALUES (300 , "First Class 2", 1, "A");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (300 , "First Class 2", 1, "C");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (300 , "First Class 2", 1, "D");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (300 , "First Class 2", 1, "E");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (300 , "First Class 2", 1, "F");

-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 2, "A");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 2, "B");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 2, "D");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 2, "E");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 2, "F");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 3, "A");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 3, "B");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 3, "C");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 3, "D");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 3, "E");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (200 , "Second Class 2", 3, "F");


-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 4, "B");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 4, "C");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 4, "D");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 4, "E");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 4, "F");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 5, "A");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 5, "B");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 5, "C");
-- insert into Seats (price,  SectionId, Row, Column) VALUES (100 , "Third Class 2", 5, "F");

-- Delete from Flights where FlightNumber=3;