using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WayFinderProto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Startpunt
            //int[] start = {1,1}; 
            //// Doel
            //int[] end = {5,9};
            //// Huidige positie
            //int[] currentPosition = start;
            //// plekken die al bezocht zijn.
            //List<List<int>> stacklist = new List<List<int>>();
            //List<List<int>> visited = new List<List<int>>();
            //visited.Add(start.ToList());
            //stacklist.Add(start.ToList());


            // initalisatie van de plattegrond
            // Muur = (-,+,|), Locatie = "X", P = " "
            //string[,] floorplan =
            //{
            //        //X coördinaten
            //        //{"0","1","2","3","4","5","6","7","8","9","10"}
            //        {"+","-","-","+","-","-","-","+","-","-","+" },//0 Y coördinaten
            //        {"|","X"," ","|","X","X","X","|"," ","X","|" },//1
            //        {"|","X"," "," "," "," "," "," "," ","X","|" },//2
            //        {"|","X"," ","|","X","X","X","|"," ","X","|" },//3
            //        {"|","X"," ","|","-","-","-","|"," ","X","|" },//4
            //        {"|","X"," ","|","X","X","X","|"," ","X","|" },//5
            //        {"|","X"," "," "," "," "," "," "," ","X","|" },//6
            //        {"+","-","-","-","-","-","-","-","-","-","+" } //7
            //};
            


            int[] start = { 1, 1 };

            int[] end = { 3, 1 };

            Console.WriteLine(Functions.Navigation(start, end));
            Console.ReadLine();



            //Console.WriteLine($"[{currentPosition[0]},{currentPosition[1]}]");
            //while (currentPosition[0] != end[0] || currentPosition[1] != end[1])
            //{
            //    bool InStack = false;
            //    int[] next = NextStep(currentPosition, end, floorplan);
            //    Console.WriteLine($"[{next[0]},{next[1]}]");
            //    currentPosition = next;
            //    visited.Add(next.ToList());

            //    foreach(List<int> i in stacklist)
            //    {
            //        if (i.SequenceEqual(next.ToList()))
            //        {
            //            InStack = true;
            //        }
            //    }

            //    if(InStack == false)
            //    {
            //        stacklist.Add(next.ToList());
            //    }

            //    if (InStack)
            //    {
            //        while (!next.SequenceEqual(stacklist.Last().ToArray()))
            //        {
            //            stacklist.RemoveAt(stacklist.Count()-1);
            //        }

            //        InStack = false;
            //    }
            //}
            
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("juiste route");
            //foreach (List<int> i in stacklist)
            //{
            //    Console.WriteLine($"[{i[0]},{i[1]}]");
            //}


            //Functions.FloorDraw(floorplan);

            //foreach(List<int> i in stacklist)
            //{
            //    int[] step = i.ToArray();

            //    if (floorplan[step[0],step[1]] != "X")
            //    {
            //        floorplan[step[0], step[1]] = "*";
            //    }
                
            //}

            
            

            //Functions.FloorDraw(floorplan); // tekent de plattegrond
            //Console.WriteLine(Functions.DescriptionMaker(stacklist));
            //Console.ReadLine();
            
        }

    }
}
