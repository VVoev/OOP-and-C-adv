using System;
using System.Collections.Generic;
using WarMachinesFromScratch.Interfaces;

namespace WarMachinesFromScratch.Engine
{
    class Command : ICommand
    {
        private const  char SplitComandSymbol = ' ';

        private string name;
        private IList<string> parameters;

        private Command(string input)
        {
            this.TranslateInput(input);
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name", "Name cannot be Null");
                }
                this.name = value;
            }
        }

        public IList<string> Parameters
        {
            get
            {
                return this.parameters;
            }
            private set
            {
                if(value== null)
                {
                    throw new ArgumentException("List of strings cannot be null");
                }
                this.parameters = value;
            }
        }
        private static Command Parse(string input)
        {
            return new Command(input);
        }
        private void TranslateInput(string input)
        {
            var indexOFFirstSeparator = input.IndexOf(SplitComandSymbol);
            this.Name = input.Substring(0, indexOFFirstSeparator);
            this.Parameters = input.Substring(indexOFFirstSeparator + 1).Split(new[] { SplitComandSymbol }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
