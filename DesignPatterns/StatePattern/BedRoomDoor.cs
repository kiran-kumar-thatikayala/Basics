using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class BedRoomDoor
    {
        public IDoorState doorState { set; get; }
        public BedRoomDoor()
        {
            this.doorState = new OpenState(this);
        }

        public void CloseDoor()
        {
            doorState.CloseDoor();
        }
        public void LockDoor()
        {
            doorState.LockDoor();
        }
        public void UnLockDoor()
        {
            doorState.UnLockDoor();
        }
        public void OpenDoor()
        {
            doorState.OpenDoor();
        }
    }
}
