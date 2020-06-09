using System;

namespace StatePattern
{
    public class LivingRoomDoor
    {
        public State state { get; set; }
        public void Open()
        {
            if (this.state == State.Open)
            {
                Console.WriteLine("failed: door already opened");
            }
            if (this.state == State.Close)
            {
                Console.WriteLine("failed: door is closed, unlock first");

            }
            if (this.state == State.Lock)
            {
                Console.WriteLine("failed: door locked, unlock first");

            }
            if (this.state == State.UnLock)
            {
                Console.WriteLine("success: door  opened");

            }
        }
        public void Close()
        {
            if (this.state == State.Open)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.Close)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.Lock)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.UnLock)
            {
                Console.WriteLine("do something");
            }
        }
        public void Lock()
        {
            if (this.state == State.Open)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.Close)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.Lock)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.UnLock)
            {
                Console.WriteLine("do something");
            }
        }
        public void UnLock()
        {
            if (this.state == State.Open)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.Close)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.Lock)
            {
                Console.WriteLine("do something");
            }
            if (this.state == State.UnLock)
            {
                Console.WriteLine("do something");
            }
        }
    }
}
