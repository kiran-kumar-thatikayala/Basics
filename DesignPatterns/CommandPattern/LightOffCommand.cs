using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class LightOffCommand : ICommand
    {
        LightOnCommand lightOnCommand;
        public LightOffCommand(Light light)
        {
            this.lightOnCommand = new LightOnCommand(light);
        }
        public void Execute()
        {
            lightOnCommand.Undo();
        }

        public void Redo()
        {
            lightOnCommand.Undo();
        }

        public void Undo()
        {
            lightOnCommand.Execute();
        }
    }
}
