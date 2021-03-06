﻿using BenchmarkDotNet.Attributes;
using Rudz.Chess;
using Rudz.Chess.Fen;

namespace Chess.Benchmark
{
    [MemoryDiagnoser]
    public class FenBenchmark
    {
        private const string f = "rnkq1bnr/p3ppp1/1ppp3p/3B4/6b1/2PQ3P/PP1PPP2/RNB1K1NR w KQ -";

        private IGame _game;

        [Params(10000, 50000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            var pos = new Position();
            _game = new Game(pos);
        }

        [Benchmark]
        public void FenPro()
        {
            for (var i = 0; i < N; ++i)
            {
                var fp = new FenData(f);
                _game.SetFen(fp);
            }
        }

        [Benchmark(Baseline = true)]
        public void FenData()
        {
            for (var i = 0; i < N; ++i)
            {
                var fp = new FenData(f);
                _game.SetFen(fp);
            }
        }
    }
}