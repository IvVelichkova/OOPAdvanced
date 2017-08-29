using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException() : base()
        {
        }
        public InvalidSongNameException(string message) : base(message)
        {
        }
        public InvalidSongNameException(int minNameLength, int maxNameLength)
            : base($"Song name should be between {minNameLength} and {maxNameLength} symbols.")
        {
        }
    }
}
