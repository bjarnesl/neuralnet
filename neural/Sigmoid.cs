public class Sigmoid(int layer, int id, List<double> inputs, List<double> weights, double bias)
{
    public List<double> Weights { get; set; } = weights;
    public List<double> Inputs { get; set; } = inputs;
    public double Bias { get; set; } = bias;
    public double Output() {
        var output =  Inputs.Zip(Weights, (a,b) => a*b).Sum() + Bias > 0 ? 1 :0;
        var indent = string.Join("\t",Enumerable.Range(0,layer+1).Select(i => ""));
        Console.WriteLine($"{indent}[{layer}, {id}] => {output}");
        return output;
    }
}