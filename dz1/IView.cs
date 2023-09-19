using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public interface IView
    {
        string imya { get; set; }
        string vozrast { get; set; }
        string rezon { set; }
        string poisk { get; set; }

        event EventHandler<EventArgs> EventSave;
        event EventHandler<EventArgs> EventLoad;
        event EventHandler<EventArgs> EventSearch;

    }
}
