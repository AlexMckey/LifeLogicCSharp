using System;
using LifeLogic;

namespace LineLife {
    class Program {
        static void Main (string[] args) {
            var logic = new LineLifeLogic (10);
            System.Console.WriteLine (logic.ToString ());
            logic.SetMiddleOne ();
            System.Console.WriteLine (logic.ToString ());
            logic.SetRandom ();
            System.Console.WriteLine (logic.ToString ());
            logic.SetRandom ();
            System.Console.WriteLine (logic.ToString ());
            logic.SetRandom ();
            System.Console.WriteLine (logic.ToString ());
        }
    }
}