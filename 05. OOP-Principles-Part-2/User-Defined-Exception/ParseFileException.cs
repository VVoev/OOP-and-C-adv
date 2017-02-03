using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OOP_Principles_Part_2.User_Defined_Exception
{
    class ParseFileException : ApplicationException
    {
        private readonly string fileName;
        private readonly long? lineNumber;

        public ParseFileException(string msg,string filename,long ?lineNumber,Exception causeException)
            :base(msg,causeException)
        {
            this.fileName = filename;
            this.lineNumber = lineNumber;
        }

        public ParseFileException(string msg,string fileName,Exception causeException)
            :this(msg,fileName,0,causeException)
        {

        }

        public string FileName { get { return this.fileName; } }
        public long? LineNumber { get { return this.lineNumber; } }

        public override string Message
        {
            get
            {
                if (this.lineNumber != null)
                {
                    string result = string.Format($"{base.Message} file {this.FileName} line {this.LineNumber}");
                    return result;
                }
                else
                {
                    string result = string.Format($"{base.Message} file {this.FileName}");
                    return result;
                }
            }
        }


    }
}
