using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuralNetwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Tests
{
    [TestClass()]
    public class PictureConverterTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            var converter = new PictureConverter();
            var inputs = converter.Convert(@"D:\Projects\neural network ii\NeuralNetworks\NeuralNetworkTests\Images\Parasitized.png");
            converter.Save("D:\\Projects\\neural network ii\\Image test\\image.png", inputs);
        }
    }
}