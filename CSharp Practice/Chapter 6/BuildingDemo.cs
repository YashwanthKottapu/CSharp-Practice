// A program that uses the Building class

using System;

class Building
{
    public int Floors; // number of floors
    public int Area; // total square footage of building
    public int Occupants; // number of occupants

    // Display the area per person.
    public void AreaPerPerson()
    {
        Console.WriteLine(" " + Area / Occupants + " area per person");
    }

    // Return the maximum number of occupants if each is to have at least the specified minimum area.
    public int MaxOccupants(int minArea)
    {
        return Area / minArea;
    }

    // A parameterized constructor for Building.
    public Building(int f, int a, int o)
    {
        Floors = f;
        Area = a;
        Occupants = o;
    }
}

// This class declares an object of type Building.

class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(2, 2500, 4); // create a Building object
        int areaPP; // area per person

        // Assign values to fields in house.
        //house.Occupants = 4;
        //house.Area = 2500;
        //house.Floors = 2;

        // Compute the area per person.
        areaPP = house.Area / house.Occupants;

        Console.WriteLine("house has:\n " + house.Floors + " floors\n " + house.Occupants + " occupants\n " + house.Area + " total area\n " + areaPP + " area per person");
    }
}