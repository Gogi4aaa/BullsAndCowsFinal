using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCowsFinal.Models
{
    public class Human : Player
    {
        private string signature;

        public Human(string name) : base(name)
        {
            Console.WriteLine("Type your secret number!");
            this.signature = this._useful.TakeInput();
        }

        public override string Signature 
        { 
            get => signature;
            protected set { signature = value; }
        }

        public override string Say()
        {
            return this._useful.TakeInput();
        }
    }
}
