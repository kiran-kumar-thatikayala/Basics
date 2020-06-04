using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;
        
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.off();
        }

        public void Redo()
        {
            stereo.off();
        }

        public void Undo()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
