namespace IntroEncapsulationPlayerInHouse
{
    internal class House
    {
        public Room CurrentRoom { get; private set; }

        public House()
        {
            CurrentRoom = Room.Outside;
        }

        //public Room GetCurrentRoom()
        //{
        //    return _currentRoom;
        //}

        public void MoveTo(string room)
        {
            if (room == null && CurrentRoom == Room.A) CurrentRoom = Room.Outside;
            else if (room == "A" && CurrentRoom is Room.Outside or Room.C) CurrentRoom = Room.A;
            else if (room == "B" && CurrentRoom == Room.D) CurrentRoom = Room.B;
            else if (room == "C" && CurrentRoom is Room.A or Room.D) CurrentRoom = Room.C;
            else if (room == "D" && CurrentRoom is Room.C or Room.B) CurrentRoom = Room.C;
            Console.WriteLine($"Du ville til {room}. Du er nå i {CurrentRoom}."); 
            //if (room == null && _currentRoom == "A") _currentRoom = null;
            //else if (room == "A" && _currentRoom is null or "C") _currentRoom = "A";
            //else if (room == "B" && _currentRoom == "D") _currentRoom = "B";
            //else if (room == "C" && _currentRoom is "A" or "D") _currentRoom = "C";
            //else if (room == "D" && _currentRoom is "C" or "B") _currentRoom = "C";
            //Console.WriteLine($"Du ville til {room}. Du er nå i {_currentRoom}.");
        }
    }
}
