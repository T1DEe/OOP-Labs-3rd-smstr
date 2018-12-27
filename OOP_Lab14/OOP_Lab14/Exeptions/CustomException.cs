﻿using System;
namespace OOP_Lab14
{
    [Serializable]
    class CustomException : Exception
    {
        public string ErrorClass { get; set; }

        public CustomException(string message, string errorClass)
            : base(message)
        {
            this.ErrorClass = errorClass;
        }
    }
}

