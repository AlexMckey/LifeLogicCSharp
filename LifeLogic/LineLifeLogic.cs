using System;
using System.Collections.Generic;
using System.Text;

namespace LifeLogic {
    public class LineLifeLogic {
        public int Size { get; private set; }
        public bool[] Arr { get; }
        public bool[] Rule { get; } = new bool[8];

        public LineLifeLogic (int size) {
            this.Size = size;
            this.Arr = new bool[size];
        }

        public LineLifeLogic (bool[] bools) {
            this.Size = bools.Length;
            this.Arr = bools;
        }

        public void SetRandom () {
            Random random = new Random ();
            for (int i = 0; i < Size; i++) {
                Arr[i] = random.Next (2) == 1;
            }
        }

        public void SetMiddleOne () {
            Arr[Size / 2] = true;
        }

        public override string ToString () {
            var sb = new StringBuilder (Size);
            foreach (var item in Arr) {
                sb.Append (item ? "#" : " ");
            }
            return sb.ToString ();
        }
    }
}