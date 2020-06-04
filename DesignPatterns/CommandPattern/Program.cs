using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            Invoker invoker = new Invoker();


            Stereo stereo = new Stereo();
            
            StereoOnWithCDCommand stereoCommand = new StereoOnWithCDCommand(stereo);
            invoker.SetCommand(stereoCommand);
            invoker.RunCommand();


            invoker.SetCommand(lightOn);
            invoker.RunCommand();

            invoker.Undo();
            invoker.Undo();

            invoker.Redo();
            invoker.Redo();

            //************Running multiple commands at a go*****************
            /* 
            Light light = new Light();
            Stereo stereo = new Stereo();

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOnWithCDCommand stereoCommand = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

            Invoker invoker = new Invoker();

            invoker.SetCommand(lightOn);
            invoker.SetCommand(lightOff);
            invoker.SetCommand(stereoCommand);
            invoker.SetCommand(stereoOffCommand);

            invoker.RunCommand();
            */
        }
    }
}
