﻿using System;
using System.Collections.Generic;
using System.Text;
namespace CabInvoiceGenerator_TDD
{
    public class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }

        ExceptionType type;
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
