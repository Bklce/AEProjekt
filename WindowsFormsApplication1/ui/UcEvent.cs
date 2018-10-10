using Seriendatenbank.ui.userControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ui
{
    public class UcEvent
    {
        public UcEvent(Template destination) : this(destination, false, null) {}

        public UcEvent(Template destination, bool dispose): this(destination, dispose, null) {}

        public UcEvent(Template destination, Object data) : this(destination, false, data) { }

        public UcEvent(Template destination, bool dispose, Object data) 
        {
            Dispose = dispose;
            Destination = destination;
            Data = data;
        }

        public bool Dispose
        { get; private set; }

        public Template Destination
        { get; private set; }

        public Object Data
        { get; private set; }

    }
}
