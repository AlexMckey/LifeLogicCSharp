using System;
using System.Collections.Generic;

namespace LifeLogic {
    public class LineLifeLogic {
        int size;
        bool[] arr;
        bool[] rule = new bool[8];

        public LineLifeLogic (int size) {
            this.size = size;
            this.arr = new bool[size];
        }

        public LineLifeLogic (bool[] bools) {
            this.size = bools.Length;
            this.arr = bools;
        }

        public SetRandom () {
            Random random = new Random ();
            foreach (var v in arr) {
                v = random.Next (2) == 1;
            }
        }
    }
}