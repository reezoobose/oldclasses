using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Binary_Tree
{
    /// <summary>
    /// Binary Tree Node .
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeNode<T>
    {
        /// <summary>
        /// Left child Node .
        /// </summary>
        public BinaryTreeNode<T> LeftChildNode = null;

        /// <summary>
        /// Right Child Node.
        /// </summary>
        public BinaryTreeNode<T> RightChildNode = null;

        /// <summary>
        /// Info part .
        /// </summary>
        public T Info { get; }

        public BinaryTreeNode(T info)
        {
            Info = info;
        }

        public override string ToString()
        {
            return Info.ToString();
        }

        /// <summary>
        /// Greater Than Operator overload.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator >(BinaryTreeNode<T> lhs, BinaryTreeNode<T> rhs)
        {
            //Argument Type of class.
            var classType = typeof(T);

            //basic types are == Integer, Float , Character & string.
            //TODO: Add Required Type for further modification.
            if (classType == typeof(int))
            {
                return Convert.ToInt32(lhs.Info) > Convert.ToInt32(rhs.Info);
            }
            else if (classType == typeof(double))
            {
                return Convert.ToDouble(lhs.Info) > Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(float))
            {
                return Convert.ToDouble(lhs.Info) > Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(string))
            {
                var leftHandSide = (string)(object)(T)lhs.Info;
                var rightHandSide = (string)(object)(T)rhs.Info;
                return leftHandSide.Length > rightHandSide.Length;
            }
            else if (classType == typeof(char))
            {
                return Convert.ToChar(lhs.Info) > Convert.ToChar(rhs.Info);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Less Than Operator overload.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator <(BinaryTreeNode<T> lhs, BinaryTreeNode<T> rhs)
        {
            //Argument Type of class.
            var classType = typeof(T);

            //basic types are == Integer, Float , Character & string.
            //TODO: Add Required Type for further modification.
            if (classType == typeof(int))
            {
                return Convert.ToInt32(lhs.Info) < Convert.ToInt32(rhs.Info);
            }
            else if (classType == typeof(double))
            {
                return Convert.ToDouble(lhs.Info) < Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(float))
            {
                return Convert.ToDouble(lhs.Info) < Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(string))
            {
                var leftHandSide = (string)(object)(T)lhs.Info;
                var rightHandSide = (string)(object)(T)rhs.Info;
                return leftHandSide.Length < rightHandSide.Length;
            }
            else if (classType == typeof(char))
            {
                return Convert.ToChar(lhs.Info) < Convert.ToChar(rhs.Info);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Less than equal.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator <=(BinaryTreeNode<T> lhs, BinaryTreeNode<T> rhs)
        {
            //Argument Type of class.
            var classType = typeof(T);

            //basic types are == Integer, Float , Character & string.
            //TODO: Add Required Type for further modification.
            if (classType == typeof(int))
            {
                return Convert.ToInt32(lhs.Info) <= Convert.ToInt32(rhs.Info);
            }
            else if (classType == typeof(double))
            {
                return Convert.ToDouble(lhs.Info) <= Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(float))
            {
                return Convert.ToDouble(lhs.Info) <= Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(string))
            {
                var leftHandSide = (string)(object)(T)lhs.Info;
                var rightHandSide = (string)(object)(T)rhs.Info;
                return leftHandSide.Length <= rightHandSide.Length;
            }
            else if (classType == typeof(char))
            {
                return Convert.ToChar(lhs.Info) <= Convert.ToChar(rhs.Info);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Greater than equal operator .
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator >=(BinaryTreeNode<T> lhs, BinaryTreeNode<T> rhs)
        {

            //Argument Type of class.
            var classType = typeof(T);

            //basic types are == Integer, Float , Character & string.
            //TODO: Add Required Type for further modification.
            if (classType == typeof(int))
            {
                return Convert.ToInt32(lhs.Info) >= Convert.ToInt32(rhs.Info);
            }
            else if (classType == typeof(double))
            {
                return Convert.ToDouble(lhs.Info) >= Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(float))
            {
                return Convert.ToDouble(lhs.Info) >= Convert.ToDouble(rhs.Info);
            }
            else if (classType == typeof(string))
            {
                var leftHandSide = (string)(object)(T)lhs.Info;
                var rightHandSide = (string)(object)(T)rhs.Info;
                return leftHandSide.Length >= rightHandSide.Length;
            }
            else if (classType == typeof(char))
            {
                return Convert.ToChar(lhs.Info) >= Convert.ToChar(rhs.Info);
            }
            else
            {
                return false;
            }
        }

    }
}
