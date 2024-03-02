class Layer(int level, List<Sigmoid> nodes)
{
    public int Level{get;set;} = level;
    public List<Sigmoid> Nodes { get; set; } = nodes;
}