// See https://aka.ms/new-console-template for more information

using IntroEncapsulationPlayerInHouse;

var house = new House();
house.MoveTo("A");
house.MoveTo("C");
house.MoveTo(null);
house.MoveTo("Z");

Console.WriteLine(house.CurrentRoom);
//house.CurrentRoom = Room.D;
//Console.WriteLine(house.GetCurrentRoom());
//Console.WriteLine(house._currentRoom);
//house._currentRoom = Room.D;

//house._currentRoom = "A";
//house._currentRoom = "D";