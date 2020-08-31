using System;
using System.Collections.Generic;

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
    }
}