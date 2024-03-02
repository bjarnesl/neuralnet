public class Sigmoid(int layer, int id, List<int> inputs, List<int> weights, int bias)
{
    public List<int> Weights { get; set; } = weights;
    public List<int> Inputs { get; set; } = inputs;
    public int Bias { get; set; } = bias;
    public int Output() {
        var output =  Inputs.Zip(Weights, (a,b) => a*b).Sum() + Bias > 0 ? 1 :0;
        Console.WriteLine($"[{layer}, {id}] => {output}");
        return output;
    }
}