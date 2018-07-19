using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageKnight.Model
{
    public interface IBoard
    {
        double PixelHeight { get; }

        double PixelWidth { get; }

        int Height { get; }

        int Width { get; }

        Guid TiledMap { get; }

        bool Can(IAction action);
    }
}
