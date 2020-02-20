﻿using System;
using System.Runtime.Serialization;

namespace TicTacToe
{
    [Serializable]

    // a new comment amended again


    internal class InvalidMoveException : Exception
    {
        public InvalidMoveException()
        {
        }
        public InvalidMoveException(string message) : base(message)
        {
        }

        public InvalidMoveException(string message, Exception innerException) : base(message, innerException)
        {
        }


        protected InvalidMoveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    // I don't want to include this comment
    
    
}
