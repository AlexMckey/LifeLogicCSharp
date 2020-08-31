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
            var fullRawLogic = new LineLifeLogic (80);
            System.Console.WriteLine (fullRawLogic.ToString ());
            fullRawLogic.SetMiddleOne ();
            System.Console.WriteLine (fullRawLogic.ToString ());
            fullRawLogic.SetRandom ();
            System.Console.WriteLine (fullRawLogic.ToString ());
        }
    }
}