using DS.CircularLinkedList;
using DS.SingleLinkedList;
using DS.DoublyLinkedList;

namespace DS
{
    internal class Program
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
            var list = new CircularLinkedListUserInterface<int>();
            while (true) { list.UserChoice(); }
        }
    }
}
