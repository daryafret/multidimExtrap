﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            //t.runDefWayTests();
            t.runRandomForestTestsLearnOnAll();
            //t.runRandomForestTestsLearnOnAll();
            //if (args.Length != 3)
            //{
            //    Console.WriteLine("Missing input parameters.");
            //    Console.WriteLine("Command line should be in format: Solver.exe <config file> <file with calculated points> <file for output points>");
            //    Console.ReadKey();
            //    return;
            //}

            //Parser parser = new Parser(args[0], args[1]);
            //int res = parser.doParse();
            //if (res != 0)
           // {
                // Console.ReadKey();
            //    return;
           // }
            

             /*double[][] xf = new double[][] 
            {
                new double[] { 0, 0, 0 },
                new double[] { 0, 1, 1 },
                new double[] { 0, 2, 2 },
                new double[] { 1, 0, 1 },
                new double[] { 1, 1, 2 },
                new double[] { 1, 2, 3 },
                new double[] { 2, 0, 2 },
                new double[] { 2, 1, 2 },
                new double[] { 2, 2, 4 }
            };*/
            //Shepard model = new Shepard(parser.FunctionDimension, parser.Points);
            
            //double[] x = new double[] { 0.5, 0.5, 0 };
            //model.Calculate(x);
            //Console.WriteLine("f({0}, {1}) = {2}", x[0], x[1], x[2]);

            /*Analyzer analyzer = new Analyzer(model, parser.Points);

            double[][] xx = analyzer.Result;
            double[][] new_points = new double[parser.PredictionPointAmount][];
            for (int i = 0; i < parser.PredictionPointAmount; i++)
            {
                new_points[i] = new double[xx[i].Length];
                Array.Copy(xx[i], new_points[i], xx[i].Length);
                model.Calculate(new_points[i]);
                // Console.WriteLine(String.Join(", ", xx[i]));
            }

            Parser.keepSolution(args[2], new_points);*/

            Console.ReadKey();
        }
    }
}
