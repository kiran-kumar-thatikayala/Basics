namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Kid kid);
        void Visit(Teacher kid);

    }
}
