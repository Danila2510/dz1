using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public interface IModel
    {
        string Result { get; set; }
        void Save();
        void Load();
        void Search();
    }
}
