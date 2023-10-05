using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Liste<int> liste = new Liste<int>() { 1, 2, 3, 4, 5 };
            liste.Add(10);
            liste.Add(10);
            liste.RemoveAt(2);
            liste.Remove(10);
            bool contains = liste.Contains(3);
            Console.WriteLine(liste[0]);
            liste.ListReader();
            Console.ReadLine();
        }
    }
}
    