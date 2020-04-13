using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int NeuronCount => Neurons?.Count ?? 0;
        public NeuronType Type;
        public static IEnumerable<object> Last { get; internal set; }

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            // RODO: Проверка на соответствие типу

            Neurons = neurons;
            this.Type = type;
        }
        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach (var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }
        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
