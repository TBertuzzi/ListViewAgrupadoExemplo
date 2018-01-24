using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewAgrupadoExemplo.Models
{
    public class GameGroup : ObservableCollection<Game>
    {
        public string Console { get; private set; }

        public GameGroup(string console)
        : base()
    {
            Console = console;
        }

        public GameGroup(string console, IEnumerable<Game> source)
        : base(source)
    {
            Console = console;
        }
    }
}
