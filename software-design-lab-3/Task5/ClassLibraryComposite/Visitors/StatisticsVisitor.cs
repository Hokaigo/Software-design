using ClassLibraryComposite.Interfaces;
using System;
using System.Collections.Generic;

namespace ClassLibraryComposite.Visitors
{
    public class StatisticsVisitor : ILightNodeVisitor
    {
        public int NodeCount { get; private set; }
        public int TextCount { get; private set; }
        public IDictionary<string, int> TagFrequencies { get; } = new Dictionary<string, int>();
        public int MaxLevel { get; private set; }

        public void Visit(LightTextNode textNode, int depth)
        {
            NodeCount++;
            TextCount++;
            RefreshDepth(depth);
        }

        public void Visit(LightElementNode elementNode, int depth)
        {
            NodeCount++;
            var tag = elementNode.TagName;
            TagFrequencies.TryGetValue(tag, out var current);
            TagFrequencies[tag] = current + 1;
            RefreshDepth(depth);
        }

        public void PrintStats()
        {
            Console.WriteLine("Stats:");
            Console.WriteLine($"Nodes total: {NodeCount}");
            Console.WriteLine($"Text nodes: {TextCount}");
            Console.WriteLine($"Max depth: {MaxLevel}");
            Console.WriteLine("Tags count:");
            foreach (var kv in TagFrequencies)
                Console.WriteLine($"<{kv.Key}>: {kv.Value}");
        }

        private void RefreshDepth(int d)
        {
            if (d > MaxLevel)
                MaxLevel = d;
        }
    }
}
