namespace BullsAndCowsFinal.Models
{
    public class Computer : Player
    {
        private Random _rand;
        private List<int> _nums;
        private string _signature;
        private int _turn;
        public Computer(string name) : base(name)
        {
            this._rand = new Random();
            this._nums = Enumerable.Range(1023, 8853)
                .Where(x => !this._useful.HasSameSymbols(x.ToString()))
                .ToList();
            this._signature = this._nums.ElementAt(_rand.Next(0, _nums.Count())).ToString();
            this._turn = 0;
        }

        public override string Signature
        {
            get => this._signature;
            protected set { this._signature = value; }
        }

        public override string Say()
        {
            if (this._turn > 0)
            {
                this._nums = this._nums
                    .Where(
                    x => Enumerable.SequenceEqual(
                        _useful.CheckNumbers(x.ToString(), this.History.ElementAt(this._turn - 1).Key),
                        this.History.ElementAt(this._turn - 1).Value))
                    .ToList();
            }

            int guess = this._nums.ElementAt(_rand.Next(0, this._nums.Count()));
            this._nums.Remove(guess);
            this._turn++;
            return guess.ToString();
        }
    }
}
