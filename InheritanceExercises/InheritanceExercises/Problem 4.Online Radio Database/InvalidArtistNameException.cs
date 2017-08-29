using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class InvalidArtistNameException : Exception
    {
        private const string Message = "Artist name should be between 3 and 20 symbols.";
        public InvalidArtistNameException(string message) : base(message)
        {
        }
        public InvalidArtistNameException()
        {
        }
        public InvalidArtistNameException(int minNameLength, int maxNameLength)
            : base($"Artist name should be between {minNameLength} and {maxNameLength} symbols.")
        {
        }
    }
}
