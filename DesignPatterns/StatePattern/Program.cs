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
            System.Console.WriteLine("pls open door");
            bedRoomDoor.OpenDoor();

            System.Console.WriteLine("pls lock door");
            bedRoomDoor.LockDoor();

            System.Console.WriteLine("pls close door");
            bedRoomDoor.CloseDoor();

            System.Console.WriteLine("pls open door");
            bedRoomDoor.OpenDoor();

            System.Console.WriteLine("pls close door");
            bedRoomDoor.CloseDoor();

            System.Console.WriteLine("pls unlock door");
            bedRoomDoor.UnLockDoor();

            System.Console.WriteLine("pls lock door");
            bedRoomDoor.LockDoor();
        }
    }
}
