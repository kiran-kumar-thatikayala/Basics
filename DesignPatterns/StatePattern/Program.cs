namespace StatePattern
{
    /************** plain **************/
    public enum State
    {
        UnLock,
        Open,
        Close,
        Lock
    }
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("********* Living Room *********\n");
            //LivingRoomDoor d = new LivingRoomDoor();
            //d.state = State.Open;
            //d.Open();
            //d.state = State.Close;
            //d.Open();
            //d.state = State.UnLock;
            //d.Open();

            System.Console.WriteLine("********* Bed Room *********\n");
            BedRoomDoor bedRoomDoor = new BedRoomDoor();  //default state door is open
            bedRoomDoor.OpenDoor();

            bedRoomDoor.LockDoor();

            bedRoomDoor.CloseDoor();
            bedRoomDoor.OpenDoor();

        }
    }
}
