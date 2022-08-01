using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Parameters;
using BenchmarkDotNet.Running;
using GradeTaskApp.SingleLinkList;

namespace Benchmark
{
	[SimpleJob(launchCount: 1, warmupCount: 3, targetCount: 10)]
	[MemoryDiagnoser]
	[RankColumn]
	public class SingleLinkSortBenchmark
	{
		private SingleLinkList<int> _rostList = new SingleLinkList<int>();
		private SingleLinkList<int> _nataliaList = new SingleLinkList<int>();
		private SingleLinkList<int> _denisList = new SingleLinkList<int>();
		private SingleLinkList<int> _kostyaSimple = new SingleLinkList<int>();
		//private SingleLinkList<int> _kostyaQuick = new SingleLinkList<int>();
		//private SingleLinkList<int> _kostyaSimpleOptimized = new SingleLinkList<int>();


		public SingleLinkSortBenchmark() {
			var rand = new Random((int)DateTime.Now.Ticks);
			for (int i = 0; i < 10000; i++)
			{
				int number = rand.Next(0, 9000);
				_rostList.Add(number);
				_nataliaList.Add(number);
				_denisList.Add(number);
				_kostyaSimple.Add(number);
				//_kostyaQuick.Add(number);
				//_kostyaSimpleOptimized.Add(number);
			}
		}

		//[Benchmark(Description = "Kostya simple optimized by rost")]
		//public void KostyaSimpleOptimizedTest()
		//{
		//	_kostyaSimpleOptimized.SimpleSortOptimezed();
		//}

		[Benchmark(Description = "Kostya simple")]
		public void KostyaSimpleTest()
		{
			_kostyaSimple.SimpleSort();
		}

		[Benchmark(Description = "Rost")]
		public void RostTest() {
			_rostList.Sort();
		}

		[Benchmark(Description = "Natalia")]
		public void NataliaTest() {
			_nataliaList.BubbleSort();
		}

		[Benchmark(Description = "Denis")]
		public void DenisTest() {
			_denisList.Order();
		}
		
	}
}
