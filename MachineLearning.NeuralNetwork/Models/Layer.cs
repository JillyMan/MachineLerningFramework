﻿using MachineLearning.NeuralNetwork.ActivateFunctions;
using System;

namespace MachineLearning.NeuralNetwork.Models
{
	public class Layer
	{
		private static readonly Random R = new Random();

		private readonly double[,] _weights;

		public double this[int i, int j]
		{
			get => _weights[i, j];
			set => _weights[i, j] = value;
		}

		private readonly int _inputNeuronCount;
		private readonly int _outputNeuronCount;

		public Layer(int inputCount, int outputCount)
		{
			_inputNeuronCount = inputCount + 1;
			_outputNeuronCount = outputCount;

			_weights = new double[inputCount, outputCount];

			for (var i = 0; i < inputCount; ++i)
			{
				for (var j = 0; j < outputCount; ++j)
				{
					_weights[i, j] = R.NextDouble();
				}
			}
		}

        //todo: optimize this function, because copy array that not good.
		public double[] CalcOutputValues(double[] inputs, IActivateFunction activateFunc)
		{
			if (_inputNeuronCount != inputs?.Length)
				throw new ArgumentOutOfRangeException();

			var inputsWithHelpNeuron = new double[_inputNeuronCount];
			inputsWithHelpNeuron[0] = 1d;
			Array.Copy(inputs, 0, inputsWithHelpNeuron, 1, inputs.Length);

			var result = new double[_outputNeuronCount];

			for (var i = 0; i < _inputNeuronCount; ++i)
            {
                var valueInputNeuron = inputsWithHelpNeuron[i];

                for (var j = 0; j < _outputNeuronCount; ++j)
				{
					result[i] += activateFunc.Activate(valueInputNeuron * _weights[i, j]);
				}
			}

			return result;
		}
	}
}
