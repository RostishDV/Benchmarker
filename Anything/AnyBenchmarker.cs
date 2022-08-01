using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.Anything
{
	[MemoryDiagnoser]
	[RankColumn]
	public class AnyBenchmarker
	{
		private readonly List<int> list = new List<int>();
		public AnyBenchmarker() {
			for (int i = 0; i < 10000; i++) { list.Add(i); }
		}
		
		[Benchmark(Description ="for i < len")]
		public int Foriinrange() {
			var sum = 0;
			for (int i = 0; i < list.Count; i++)
			{
				sum += list[i];
			}
			return sum;
		}

		[Benchmark(Description = "foreach")]
		public int internConcatString() {
			var sum = 0;
			foreach (int i in list)
			{
				sum += i;
			}
			return sum;
		}

	}
}
