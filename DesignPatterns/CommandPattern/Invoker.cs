using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Invoker
    {
        private ICommand command;
        private Stack<ICommand> undoStack;
        private Stack<ICommand> redoStack;

        public Invoker()
        {
            undoStack = new Stack<ICommand>();
            redoStack = new Stack<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
            undoStack.Push(command);
            redoStack.Clear();
        }
        public void RunCommand()
        {
            command.Execute();
        }

        public void Undo()
        {
            if (undoStack.Count <=0)
            {
                return;
            }
            else
            {
                undoStack.Peek().Undo();
                redoStack.Push(undoStack.Peek());
                undoStack.Pop();
            }
        }

        public void Redo()
        {
            if (redoStack.Count <= 0)
            {
                return;
            }
            else
            {
                redoStack.Peek().Redo();
                undoStack.Push(redoStack.Peek());
                redoStack.Pop();
            }
        }
    }
}
