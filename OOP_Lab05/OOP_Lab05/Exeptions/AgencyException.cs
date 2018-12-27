using System;
namespace OOP_Lab05
{
    class AgencyException : CustomException
    {
        public string ErrorName { get; set; }
        public int ErrorId { get; set; }

        public AgencyException(string message, string errorName, int errorId)
            : base(message, "Agency")
        {
            this.ErrorName = errorName;
            this.ErrorId = errorId;
        }
    }
}
