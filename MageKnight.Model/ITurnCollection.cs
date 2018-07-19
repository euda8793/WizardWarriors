using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    public interface ITurnCollection
    {
        ObservableCollection<ITurn> Turns { get; }
    }
}
