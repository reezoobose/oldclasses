using DS.SingleLinkedList;

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
            var list = new SingleLinkListUserInterface<int>();
            while (true){ list.UserChoice();}
        }
    }
}
