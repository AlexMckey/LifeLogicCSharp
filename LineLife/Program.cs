﻿using System;
using LifeLogic;

namespace LineLife {
    class Program {
        static void Main (string[] args) {
            // var logic = new LineLifeLogic (10);
            // System.Console.WriteLine (logic.ToString ());
            // logic.SetMiddleOne ();
            // System.Console.WriteLine (logic.ToString ());
            // logic.SetRandom ();
            // System.Console.WriteLine (logic.ToString ());
            // logic.SetRandom ();
            // System.Console.WriteLine (logic.ToString ());
            // logic.SetRandom ();
            // System.Console.WriteLine (logic.ToString ());
            var fullRawLogic = new LineLifeLogic (80);
            // System.Console.WriteLine (fullRawLogic.ToString ());
            // fullRawLogic.SetRandom ();
            // System.Console.WriteLine (fullRawLogic.ToString ());
            // fullRawLogic.Clear ();
            fullRawLogic.SetMiddleOne ();
            fullRawLogic.SetRandom ();
            System.Console.WriteLine (fullRawLogic.ToString ());
            fullRawLogic.SetRule (123); // мигание
            fullRawLogic.SetRule (22); // треугольник Серпинского
            fullRawLogic.SetRule (999); // движение (сдвиг) вправо

            while (true) {
                fullRawLogic.Next ();
                System.Console.WriteLine (fullRawLogic.ToString ());
                System.Console.ReadKey ();
            }
        }
    }
}