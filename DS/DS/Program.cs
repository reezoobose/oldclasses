//using DS.CircularLinkedList;
//using DS.SingleLinkedList;
//using DS.DoublyLinkedList;
//using DS.Stack.ArrayImplementation;

using DS.Stack.LinkedListImplementation;

namespace DS
{
    public static class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            /*
            var list = new SingleLinkListUserInterface<int>();
            while (true){ list.UserChoice();}
            */
            /*
            var list = new DoublyLinkedListUserInterface<int>();
            while (true) { list.UserChoice(); }
            */
            /*
            var list = new CircularLinkedListUserInterface<int>();
            while (true) { list.UserChoice(); }
            */
            /*
            var arrayImplementationOfStack = new StackUserInterface();
            while (true) arrayImplementationOfStack.UserChoice();
            */

            var linkedListImplementationOfStack = new StackUserInterface<int>();
            while (true) linkedListImplementationOfStack.UserChoice();
        }
    }
}
