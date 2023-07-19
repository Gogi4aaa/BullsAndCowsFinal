using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCowsFinal.Models
{
    public abstract class Player
    {
        protected Useful _useful;
        public Player(string name)
        {
            this._useful = new Useful();
            this.Name = name;
            this.History = new List<KeyValuePair<string, int[]>>();
        }
        public string Name { get; private set; }

        public abstract string Signature { get; protected set; }

        public List<KeyValuePair<string, int[]>> History { get; private set; }

        public abstract string Say();
    }
}