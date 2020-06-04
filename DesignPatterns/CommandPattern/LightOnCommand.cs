using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class LightOnCommand : ICommand
    {
        Light light;

        // The constructor is passed the light it 
        // is going to control. 
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Redo()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
