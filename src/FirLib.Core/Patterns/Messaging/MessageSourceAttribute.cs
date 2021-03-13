using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirLib.Core.Patterns.Messaging
{
    public class MessagePossibleSourceAttribute : Attribute
    {
        public string[] PossibleSourceThreads { get; }

        public MessagePossibleSourceAttribute(params string[] possibleSourceThreads)
        {
            this.PossibleSourceThreads = possibleSourceThreads;
        }
    }
}