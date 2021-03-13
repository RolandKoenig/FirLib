using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirLib.Core.Patterns.Messaging
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MessagePropertyDescriptionAttribute : Attribute
    {
        public string Description { get; }

        public MessagePropertyDescriptionAttribute(string description)
        {
            this.Description = description;
        }
    }
}
