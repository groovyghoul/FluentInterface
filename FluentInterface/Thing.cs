using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentInterface
{
    public class Thing : IIsStarted, IWordAdded, IFinalWordAdded, IIsComplete
    {
        private List<string> _string = new List<string>();

        private Thing()
        {
        }

        public static IIsStarted Start()
        {
            return new Thing();
        }

        public IWordAdded AddWord(string word)
        {
            _string.Add(word);
            return this;
        }

        public IFinalWordAdded FinalWord(string word)
        {
            _string.Add(word);
            return this;
        }

        public void Complete()
        {
            foreach (var word in _string)
            {
                Console.WriteLine(word);
            }
        }
    }
}
