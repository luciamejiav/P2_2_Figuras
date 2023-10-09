using System.Drawing;

namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
    protected double _base, _altura;

    public Rectangulo(double _base, double altura, Color color)
    {
        this._base = _base;
        this._altura = altura;
        this._color = color;
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
        return $"FIGURA RECTANGULO: BASE: {_base}  ALTURA: {_altura} COLOR: {_color}  AREA: {GetArea()}";
    }
}