using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    public interface IGame : INotifyPropertyChanged
    {
        ITurnCollection TurnCollection { get; }

        IBoard Board { get; }

        IPlayerCollection PlayerCollection { get; }
    }
}
