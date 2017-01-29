using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrototype
{
    public class ChessPiece
    {
        private string _key, _value;
        private Tuple<int, int> _coordinates;
        private Tuple<int,int> Coordinates { get; set; }

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public ChessPiece()
        {
            this.Key = "";
            this.Value = "";
            this.Coordinates = new Tuple<int, int>(0, 0);
        }
        public void PieceInit(string key, string value, Tuple<int,int> coordinates)
        {
            this.Key = key;
            this.Value = value;
            this.Coordinates = coordinates;
        }
        
    }
}
