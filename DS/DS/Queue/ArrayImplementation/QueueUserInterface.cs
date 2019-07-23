using System;

namespace DS.Queue.ArrayImplementation
{
    /// <summary>
    ///     User Interface .
    /// </summary>
    public class QueueUserInterface
    {
        /// <summary>
        ///     Queue.
        /// </summary>
        private static QueueArrayImplementation _queue;

        /// <summary>
        ///     Queue User interface .
        /// </summary>
        public QueueUserInterface()
        {
            Console.Write("\n\nEnter the initial size of Queue : ");
            var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            _queue = new QueueArrayImplementation(input);
        }

        /// <summary>
        ///     User choice .
        /// </summary>
        public void UserChoice()
        {
            Console.WriteLine("\n======== User Choice ========");
            //Ask user for make a choice .
            Console.WriteLine("Actions can be performed on the list.\n\n");

            Console.WriteLine("======== ======== ========");
            Console.WriteLine(" [0] : Exit Program.");
            Console.WriteLine(" [1] : Enqueue");
            Console.WriteLine(" [2] : Dequeue");
            Console.WriteLine(" [3] : Display");
            Console.WriteLine(" [4] : Size");
            Console.Write("\n\nEnter Your Choice : ");
            //Select choice.
            var choice = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Not Integer."));
            //Switch over choices .
            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    try
                    {
                        Console.Write("\nInsert the Data: ");
                        var input = Console.ReadLine();
                        _queue.Enqueue(int.Parse(input ?? throw new InvalidOperationException()));
                    }
                    catch (Exception e)
                    {
                        Console.Write("\nUnable to Insert data: " + e);
                    }

                    break;
                case 2:
                    try
                    {
                        var deletedData = _queue.Dequeue();
                        Console.Write("\nData Removed: " + deletedData);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to remove data " + e);
                    }

                    break;
                case 3:
                    _queue.Display();
                    break;
                case 4:
                    Console.WriteLine("Size Of the Queue: " + _queue.SizeofQueue());
                    break;
            }
        }
    }
}