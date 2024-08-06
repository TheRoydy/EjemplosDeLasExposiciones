namespace clases
{
    public interface IAuto
    {
        object nombreAuto { get; }
        object color { get; }
        object ruedas { get; }
        object motor { get; }

        void avanzar();
        void estacionar();
        void retoceder();
    }
}