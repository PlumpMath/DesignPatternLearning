﻿using System;

namespace BridgePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HandsetBrand ab;
            ab = new Android();
            ab.SetHandsetSoft(new HansetGame());
            ab.Run();

            ab.SetHandsetSoft(new HansetAddresslist());
            ab.Run();

            ab = new Ios();
            ab.SetHandsetSoft(new HansetGame());
            ab.Run();

            ab.SetHandsetSoft(new HansetAddresslist());
            ab.Run();

            Console.Read();
        }
    }
}