using System;

namespace DS.Stack.LinkedListImplementation
{
    internal class StackUserInterface<T>
    {
        //Stack
        private static Stack<T> _stack;


        public StackUserInterface()
        {
            _stack = new Stack<T>();
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
                    Console.Write("\nPush In The Stack.");
                    try
                    {
                        var value = Console.ReadLine();
                        var converted = (T) Convert.ChangeType(value, typeof(T));
                        _stack.PushInStack(converted);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("" + exception);
                    }

                    break;
                case 2:
                    try
                    {
                        Console.Write("\nDeleted Value : " + _stack.PopFromStack());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }


                    break;
                case 3:
                    try
                    {
                        _stack.Display();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }

                    break;
                case 4:
                    try
                    {
                        Console.Write("\nCurrent Peek Value : " + _stack.PeekOfStack());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                    break;
            }
        }
    }
}