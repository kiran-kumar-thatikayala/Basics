namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
        void Visit(Kid kid);
        void Visit(Teacher kid);

    }
}
