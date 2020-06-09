namespace StatePattern
{
    public interface IDoorState
    {
        void OpenDoor();
        void CloseDoor();
        void LockDoor();
        void UnLockDoor();
    }
}
