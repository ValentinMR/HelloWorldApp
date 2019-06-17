using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    /// <summary>
    /// Interface that must be implemented by classes that write to target
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Writes a string message
        /// </summary>
        /// <param name="info">Content of the message</param>
        void WriteMessage(string info);
    }
}
