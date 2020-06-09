using System;

namespace StatePattern
{
    public class CloseState : IDoorState
    {

        BedRoomDoor bedRoomDoor;
        public CloseState(BedRoomDoor door)
        {
            bedRoomDoor = door;
        }
        public void CloseDoor()
        {
            Console.WriteLine("failed: door already closed");
        }

        public void LockDoor()
        {
            Console.WriteLine("success: door locked");
            bedRoomDoor.doorState = new LockState(bedRoomDoor);
        }

        public void OpenDoor()
        {
            Console.WriteLine("success: door open");
            bedRoomDoor.doorState = new OpenState(bedRoomDoor);
        }

        public void UnLockDoor()
        {
            Console.WriteLine("failed: door closed");          
        }
    }
}
