using System;

namespace StatePattern
{
    public class OpenState : IDoorState
    {
        BedRoomDoor bedRoomDoor;
        public OpenState(BedRoomDoor door)
        {
            bedRoomDoor = door;
        }
        public void CloseDoor()
        {
            Console.WriteLine("success: door closed");
            bedRoomDoor.doorState = new CloseState(bedRoomDoor);
        }

        public void LockDoor()
        {
            Console.WriteLine("failed: door open");
        }

        public void OpenDoor()
        {
            Console.WriteLine("failed: door already open");
        }

        public void UnLockDoor()
        {
            Console.WriteLine("failed: door opened");
        }
    }
}
