using System;

namespace DS.Queue.ArrayImplementation
{
    /// <summary>
    ///     Queue Array Implementation.
    /// </summary>
    public class QueueArrayImplementation
    {
        #region Private Variables.

        //Front Pointer .
        private int _frontPointer;

        //Rear Pointer .
        private int _rearPointer;

        //Queue
        private readonly int[] _queueArray;

        //Default Size of Queue.
        private readonly int _defaultSizeOfQueue = 10;

        #endregion

        /// <summary>
        ///     Constructor.
        /// </summary>
        public QueueArrayImplementation(int sizeOfQueue)
        {
            //initially set to -1;
            _frontPointer = -1;
            _rearPointer = -1;
            //Set up the Queue Array.
            _queueArray = sizeOfQueue > 0 ? new int[sizeOfQueue] : new int[_defaultSizeOfQueue];
        }

        #region Helper Function

        /// <summary>
        ///     Check The queue is full or not .
        /// </summary>
        /// <returns></returns>
        private bool IsFull()
        {
            return _rearPointer >= _queueArray.Length - 1;
        }

        /// <summary>
        ///     Check the Queue is empty or not .
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty()
        {
            var defaultConditionOne = _frontPointer == -1;
            var defaultConditionTwo = _rearPointer == -1;
            var defaultCondition = defaultConditionTwo && defaultConditionOne;
            var queueCount = _rearPointer - _frontPointer + 1;
            var generalCondition = queueCount == 0;
            return defaultCondition || generalCondition;
        }

        /// <summary>
        ///     Returns Size of queue .
        /// </summary>
        /// <returns></returns>
        public int SizeofQueue()
        {
            return _rearPointer - _frontPointer + 1;
        }

        /// <summary>
        ///     Display .
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Front = >" + _frontPointer + "Rear =>" + _rearPointer);
            for (var i = _frontPointer; i <= _rearPointer; i++) Console.WriteLine(_queueArray[i]);
        }

        #endregion

        #region Insertion and deletion

        /// <summary>
        ///     Insertion in a Queue.
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            //if full cancel operation.
            if (IsFull()) throw new OperationCanceledException("Queue is full.");
            //Check initial condition .
            var defaultConditionOne = _frontPointer == -1;
            var defaultConditionTwo = _rearPointer == -1;
            var defaultCondition = defaultConditionTwo && defaultConditionOne;
            if (defaultCondition)
            {
                _frontPointer = 0;
                _rearPointer += 1;
                _queueArray[_rearPointer] = data;
                return;
            }

            //General Condition.
            _rearPointer += 1;
            _queueArray[_rearPointer] = data;
        }

        /// <summary>
        ///     Deletion in a Queue .
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            // if empty cancel operation.
            if (IsEmpty()) throw new OperationCanceledException("Queue is Empty.");
            //Delete the data 
            var deletedValue = _queueArray[_frontPointer];
            //Reset with some arbitrary number .
            _queueArray[_frontPointer] = 999;
            //Increment the pointer.
            _frontPointer += 1;
            return deletedValue;
        }

        #endregion
    }
}