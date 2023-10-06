namespace P2_2_Figuras;

public class TrianguloEquilatero : Figura
{
    protected double _base, _altura;

    public TrianguloEquilatero(double _base, double _altura)
    {
        this._base = _base;
        this._altura = _altura;
    }

    public override double GetArea()
    {
        return (_base * _altura) / 2;
    }
}