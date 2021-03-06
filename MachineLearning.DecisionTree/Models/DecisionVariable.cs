﻿namespace MachineLearning.DecisionTree.Models
{
	public class DecisionVariable
	{
		public string Name { get; }

		public int RangeLength => NameRange.Length;

		public string[] NameRange { get; set; }

		public DecisionVariable(string name, params string[] nameRange)
		{
			Name = name;
			NameRange = nameRange;
		}
	}
}
