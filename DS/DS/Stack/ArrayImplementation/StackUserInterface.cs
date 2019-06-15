using System;

namespace DS.Stack.ArrayImplementation
{
    public class StackUserInterface
    {
        //Stack
        private static Stack _stack;

        /// <summary>
        ///     Create a stack.
        /// </summary>
        private void CreateStack()
        {
            Console.Write("\n\nInitial Length Of the Stack :  ");
            var initialLength = Console.ReadLine();
            var testInt = int.TryParse(initialLength, out var initialLengthCount);
            if (!testInt) return;
            if (initialLengthCount <= 0) return;
            _stack = new Stack(initialLengthCount);
        }

        public StackUserInterface()
        {
            CreateStack();
        }

        /// <summary>
        ///     User Choice.
        /// </summary>
        public void UserChoice()
        {
            Console.WriteLine("\n======== User Choice ========");
            //Ask user for make a choice .
            Console.WriteLine("Actions can be performed on the list.\n\n");

            Console.WriteLine("======== ======== ========");
            Console.WriteLine(" [0] : Exit Program.");
            Console.WriteLine(" [1] : Push");
            Console.WriteLine(" [2] : Pop");
            Console.WriteLine(" [3] : Display");
            Console.WriteLine(" [4] : Peek");
            Console.Write("\n\nEnter Your Choice : ");
            //Select choice.
            var choice = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Invalid input"));
            //Switch over choices .
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Write("\nInsert The Value : ");
                    var insertedValue = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Received Value is not Correct"));
                    try
                    {
                        _stack.PushInStack(insertedValue);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception Raised "+e);
                    }
                    
                    break;
                case 2:
                    try
                    {
                        Console.Write("\nDeleted Value : " + _stack.PopFromStack());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception Raised " + e);
                    }
                    
                    break;
                case 3:
                    _stack.Display();
                    break;
                case 4:
                    Console.Write("\nCurrent Peek Value : " + _stack.PeekOfStack());
                    break;
            }
        }
    }
}