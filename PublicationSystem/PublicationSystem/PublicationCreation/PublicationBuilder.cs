using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
    public abstract class PublicationBuilder
    {
        public abstract Publication GetPublication();
        public abstract string PublicationCommandName { get; }
    }
}
