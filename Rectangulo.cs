namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
    protected double _base, _altura;

    public Rectangulo(double _base, double _altura)
    {
        this._base = _base;
        this._altura = _altura;
    }

    public override double GetArea()
    {
        return _base * _altura;
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
        return $"FIGURA RECTANGULO: BASE: {_base}  ALTURA: {_altura} COLOR:  AREA: {GetArea()}";
    }
}