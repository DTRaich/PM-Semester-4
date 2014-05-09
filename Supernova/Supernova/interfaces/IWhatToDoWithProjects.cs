using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.interfaces
{
    interface IWhatToDoWithProjects
    {
        bool saveProjects();
        bool cancelProjects();
        bool loadProjects();
    }
}
