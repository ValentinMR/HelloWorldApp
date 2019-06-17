using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    /// <summary>
    /// Factory to instantiate the correct target output that is going to be used to print the message
    /// </summary>
    public class WriterFactory
    {
        private string target;
        public WriterFactory(string target)
        {
            this.target = target;
        }

        /// <summary>
        /// Instantiates concrete class
        /// </summary>
        /// <returns></returns>
        public IWriter Create()
        {
            IWriter objWriter;
            switch (target.ToUpper())
            {
                case "CONSOLE":
                    objWriter = new ConsoleWriter();
                    break;
                default:
                    objWriter = new ConsoleWriter();
                    break;
            }
            return objWriter;
        }

    }
}
