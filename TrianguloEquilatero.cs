namespace P2_2_Figuras;

internal class TrianguloEquilatero : Figura
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

    //getter --> devuelve enteros
    public double GetBase()
    {
        return this._base;
    }

    //setter
    public void SetAltura(int altura)
    {
        this._altura = altura;
    }

    //tostring
    public override string ToString()
    {
        return $"FIGURA TRIANGULO EQUILATERO: BASE: {_base}  ALTURA: {_altura} COLOR:  AREA: {GetArea}";
    }
}