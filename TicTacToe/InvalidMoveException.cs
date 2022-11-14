using System;
using System.Runtime.Serialization;
// main branch comment
// another main
namespace TicTacToe
{ 
    [Serializable]
    internal class InvalidMoveException : Exception
    {
        public InvalidMoveException()
        {
        }
        public InvalidMoveException(string message) : base(message)
        {
        }

        public InvalidMoveException(string message, Exception innerException) : base(message, innerExcepti
        {
        }

        protected InvalidMoveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
