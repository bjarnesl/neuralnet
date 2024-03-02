// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

List<int> inputs = [0,1,1,1,1,1,0,0];

var firstLayer =  new Layer(0, [
            new Sigmoid(0, 0,inputs,[0,1,1,0,0,0,0,0],0),
            new Sigmoid(0, 1,inputs,[0,0,0,1,1,0,0,0],0),
            new Sigmoid(0, 2,inputs,[0,0,0,0,0,1,1,0],0),
            new Sigmoid(0, 3,inputs,[1,0,0,0,0,0,0,1],0)
            ]);

var inputToSecondLayer = firstLayer.Nodes.Select(n => n.Output()).ToList();
var secondLayer =  new Layer(1, [
            new Sigmoid(1, 0,inputToSecondLayer, [1,-1,0,0], 0), // East
            new Sigmoid(1, 1,inputToSecondLayer, [0,1,-1,0], 0), // Sout
            new Sigmoid(1, 2,inputToSecondLayer, [0,0,1,-1], 0), // West
            new Sigmoid(1, 3,inputToSecondLayer, [-1,0,0,1], 0), // North
]);

var myNet = new Net(){Layers = [firstLayer,secondLayer]};

var output = myNet.Layers.Last().Nodes.Select(n => n.Output());
Console.WriteLine(string.Join(",", output));

Console.WriteLine("Goodbye, cruel world");