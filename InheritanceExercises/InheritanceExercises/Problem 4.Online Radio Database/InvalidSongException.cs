using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class InvalidSongException : Exception

    {
        private const string message = "Invalid song.";

        public InvalidSongException()
        {
        }

        public InvalidSongException(string message) : base(message)
        {
        }

       
    }
}
