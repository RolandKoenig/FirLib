using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirLib.Core.Patterns.Messaging
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MessageDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public MessageDescriptionAttribute(string description)
        {
            this.Description = description;
        }
    }
}
