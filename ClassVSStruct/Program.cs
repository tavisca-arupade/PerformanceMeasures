﻿using System;
using BenchmarkDotNet.Running;

namespace ClassVSStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Test>();
        }
    }
    
}
