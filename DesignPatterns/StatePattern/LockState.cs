using System;

namespace StatePattern
{
    public class LockState : IDoorState
    {
        BedRoomDoor bedRoomDoor;

        public LockState(BedRoomDoor door)
        {
            bedRoomDoor = door;
        }
        public void CloseDoor()
        {
            Console.WriteLine("failed: door closed");
        }

        public void LockDoor()
        {
            Console.WriteLine("failed: door already locked");
        }

        public void OpenDoor()
        {
            Console.WriteLine("failed: door is locked");
        }

        public void UnLockDoor()
        {
            Console.WriteLine("success: door unlocked");
            bedRoomDoor.doorState = new UnLockState(bedRoomDoor);
        }
    }
}
