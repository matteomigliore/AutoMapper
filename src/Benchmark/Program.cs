﻿using System;
using System.Collections.Generic;
using Benchmark.Flattening;

namespace Benchmark
{
	public class Program
	{
		static void Main(string[] args)
		{
			var mappers = new Dictionary<string, IObjectToObjectMapper[]>
				{
					{ "Flattening", new IObjectToObjectMapper[] { new FlatteningMapper(), new ManualMapper() } }
				};
		

			foreach (var pair in mappers)
			{
				foreach (var mapper in pair.Value)
				{
					new BenchEngine(mapper, pair.Key).Start();
				}
			}
		}
	}
}