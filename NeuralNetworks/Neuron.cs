
using System;
using System.Collections.Generic;

namespace NeuralNetworks
{
    public class Neuron
    {
        public List<double> Weights { get; }
        public NeuronType NeuronType;
        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            if (inputCount <= 0)
            {
                throw new ArgumentException("Количество входов не может быть меньше либо равным нулю", nameof(inputCount));
            }
            else
            {
                NeuronType = type;
                Weights = new List<double>();
                for (int i = 0; i < inputCount; i++)
                {
                    Weights.Add(1);
                }
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }
            if (NeuronType != NeuronType.Input)
            {
                // сигмойда
                Output = Sigmoid(sum);
            }
            {
                Output = sum;
            }
            return Output;
        }
        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Pow(Math.E, -x));
            return result;
        }
        public void SetWeights(params double[] weight)
        {
            // TODO: удалить после добавления возможности обучения сети.
            for (int i = 0; i < weight.Length; i++)
            {
                Weights[i] = weight[i];
            }
        }
        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
