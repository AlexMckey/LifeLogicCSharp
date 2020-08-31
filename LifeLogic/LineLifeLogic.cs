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
                sb.Append (item ? "#" : ".");
            }
            return sb.ToString ();
        }

        public void SetRule (int progNum) {
            var num = progNum % 256;
            for (int i = 0; i < 8; i++) {
                Rule[i] = num % 2 == 1;
                num /= 2;
            }
        }

        public void Next () {
            var newArr = new bool[Size];
            for (int i = 0; i < Size; i++) {
                var ruleIdx = 4 * (Arr[(i - 1 + Size) % Size] ? 1 : 0) +
                    2 * (Arr[i] ? 1 : 0) +
                    1 * (Arr[(i + 1) % Size] ? 1 : 0);
                newArr[i] = Rule[ruleIdx];
            }
            Array.Copy (newArr, Arr, Size);
        }
    }
}