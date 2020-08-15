using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using ConsoleApp4;
using FuelStorageCs;

namespace ConsoleApp4
{  }

    class Program
    {
        static void Main(string[] args)
        {
        Engine E1 = new Engine(200, "chev", 1, true);
        FuelStorage F1 = new FuelStorage(20, 11.5, true);
        Wheel W1 = new Wheel(1, "Left back", true);
        Wheel W2 = new Wheel(1, "Left front", true);
        Wheel W3 = new Wheel(1, "Right front", false);
        Wheel W4 = new Wheel(1, "Right back", true);
        Wheels Car1 = new Wheels();
        Car1.Add(W1);
        Car1.Add(W2);
        Car1.Add(W3);
        Car1.Add(W4);
        Car1.WheelsStatus();
        E1.Start(F1);
        Creation C1 = new Creation("Chevrolet", "USA", 2001, 7);
        Machine M1 = new Machine(E1, F1, Car1, C1);
        M1.starting(E1, F1, Car1);

        Engine E2 = new Engine(500, "bwm", 1, true);
        FuelStorage F2 = new FuelStorage(25, 0, true);
        Wheel W5 = new Wheel(1, "Left back", true);
        Wheel W6 = new Wheel(1, "Left front", true);
        Wheel W7 = new Wheel(1, "Right front", true);
        Wheel W8 = new Wheel(1, "Right back", true);
        Wheels Car2 = new Wheels();
        Car2.Add(W5);
        Car2.Add(W6);
        Car2.Add(W7);
        Car2.Add(W8);
        Car2.WheelsStatus();
        E2.Start(F2);
        Creation C2 = new Creation("BMW", "USA", 2008, 12);
        Machine M2 = new Machine(E2, F2, Car2, C2);
        M2.starting(E2, F2, Car2);

        Engine E3 = new Engine(350, "mustang", 1, false);
        FuelStorage F3 = new FuelStorage(15, 5, true);
        Wheel W9 = new Wheel(1, "Left back", true);
        Wheel W10 = new Wheel(1, "Left front", true);
        Wheel W11 = new Wheel(1, "Right front", true);
        Wheel W12 = new Wheel(1, "Right back", true);
        Wheels Car3 = new Wheels();
        Car3.Add(W9);
        Car3.Add(W10);
        Car3.Add(W11);
        Car3.Add(W12);
        Car3.WheelsStatus();
        E3.Start(F3);
        Creation C3 = new Creation("Mustang", "USA", 1998, 4);
        Machine M3 = new Machine(E3, F3, Car3, C3);
        M3.starting(E3, F3, Car3);
    }
    }

