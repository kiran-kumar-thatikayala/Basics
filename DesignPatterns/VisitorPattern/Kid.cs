namespace VisitorPattern
{
    public class Kid : IElement
    {
        public Kid(string name)
        {
            Name = name;
        }
        public string Name { get; set; } 
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
