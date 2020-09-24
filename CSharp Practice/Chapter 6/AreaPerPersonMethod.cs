// Add a method to Building.

using System;

class BuildingDemoMethod
{
    static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);
        // Assign values to fields in house.
        //house.Occupants = 4;
        //house.Area = 2500;
        //house.Floors = 2;
        // Assign values to fields in office.
        //office.Occupants = 25;
        //office.Area = 4200;
        //office.Floors = 3;
        Console.WriteLine("house has:\n " +
        house.Floors + " floors\n " +
        house.Occupants + " occupants\n " +
        house.Area + " total area");

        house.AreaPerPerson();

        Console.WriteLine();

        Console.WriteLine("office has:\n " +
        office.Floors + " floors\n " +
        office.Occupants + " occupants\n " +
        office.Area + " total area");

        office.AreaPerPerson();
    }
}