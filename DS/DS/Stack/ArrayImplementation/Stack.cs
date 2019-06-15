using System;

namespace DS.Stack.ArrayImplementation
{
    /// <summary>
    ///     Stack With Array Implementation.
    /// </summary>
    public class Stack
    {
        //default size Array .
        private static readonly int _defaultSize = 10;

        //Stack of array.
        private static int[] _stackHolder;

        //Reference of the Top.
        private static int _top = -1;

        #region Constructor

        public Stack(int size)
        {
            _stackHolder = new int[size];
        }

        public Stack()
        {
            _stackHolder = new int[_defaultSize];
        }

        #endregion

        #region Insertion And Deletion

        /// <summary>
        ///     Push in the stack.
        /// </summary>
        /// <param name="Value"></param>
        public void PushInStack(int Value)
        {
            if (IsStackFull()) throw new InvalidOperationException("Stack OverFlow");

            _top += 1;
            _stackHolder[_top] = Value;
        }

        /// <summary>
        ///     Pop From the stack.
        /// </summary>
        /// <returns></returns>
        public int PopFromStack()
        {
            if (IsStackEmpty()) throw new InvalidOperationException("Stack underFlow");

            var x = _stackHolder[_top];
            _top -= 1;
            return x;
        }
        /// <summary>
        /// Peek of Stack.
        /// </summary>
        /// <returns></returns>
        public int PeekOfStack()
        {
            if (IsStackEmpty()) { throw new InvalidOperationException("No Peek Found");}

            return _stackHolder[_top];
        }

        /// <summary>
        /// Display
        /// </summary>
        public void Display()
        {
            if (IsStackEmpty()) { Console.Write("Empty Stack."); return;}
            for (var i = 0; i <= _top; i++)
            {
                Console.Write("\t"+_stackHolder[i]);
            }
        }
        #endregion

        #region Helper Function

        private bool IsStackEmpty()
        {
            return _top == -1;
        }

        private bool IsStackFull()
        {
            return _top >= _stackHolder.Length - 1;
        }

        #endregion
    }
}