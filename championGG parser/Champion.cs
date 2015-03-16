using System.Collections.Generic;

namespace championGG_parser
{
    class Champion
    {
        #region variables
        public List<Position> positions;
        public string name
        {
            get;
            private set;
        }
        #endregion

        #region constructors
        public Champion(string name, string[] positions)
        {
            this.positions = new List<Position>();
            this.name = name;
            foreach (var item in positions)
            {
                this.positions.Add(new Position(item));
            }
        }
        #endregion
    }
}
