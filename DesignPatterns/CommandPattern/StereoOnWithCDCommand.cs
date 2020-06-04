using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }

        public void Redo()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }

        public void Undo()
        {
            stereo.off();
        }
    }
}
