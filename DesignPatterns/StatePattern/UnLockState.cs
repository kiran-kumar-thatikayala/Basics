using System;

namespace StatePattern
{
    public class UnLockState : IDoorState
    {
        BedRoomDoor bedRoomDoor;

        public UnLockState(BedRoomDoor door)
        {
            bedRoomDoor = door;
        }
        public void CloseDoor()
        {
            Console.WriteLine("failed: door closed");
        }

        public void LockDoor()
        {
            Console.WriteLine("Success: door locked");
            bedRoomDoor.doorState = new LockState(bedRoomDoor);

        }

        public void OpenDoor()
        {
            Console.WriteLine("success: door opend");
            bedRoomDoor.doorState = new OpenState(bedRoomDoor);
        }

        public void UnLockDoor()
        {
            Console.WriteLine("success: door already unlocked");
        }
    }
}
