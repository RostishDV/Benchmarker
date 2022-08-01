using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Loggers;
using System;
using System.IO;

namespace Benchmark
{
	public class Program
	{
		public static void Main(string[] args) 
		{
			//Available Benchmark:
			//	0 -> SingleLinkSortBenchmark
			//	1 -> AnyBanchmarker
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
		}
	}
}