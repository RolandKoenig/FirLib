using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirLib.Core.Patterns.Messaging
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true)]
    public class MessageUsageExampleAttribute : Attribute
    {
        public string ExampleString { get; }

        public MessageUsageExampleAttribute(string exampleString)
        {
            this.ExampleString = exampleString;
        }
    }
}
