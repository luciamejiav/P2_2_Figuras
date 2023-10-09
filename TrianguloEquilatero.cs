using System.Drawing;

namespace P2_2_Figuras;

internal class TrianguloEquilatero : Figura
{
    protected double _lado;

    public TrianguloEquilatero(double _lado, Color color)
    {
        this._lado = _lado;
        this._color = color;
    }

    public override double GetArea()
    {
        return (_lado * _lado) / 2;
    }

    //getter --> devuelve enteros
    public double GetBase()
    {
        return this._lado;
    }

    //setter
    public void SetAltura(int _lado)
    {
        this._lado = _lado;
    }

    //tostring
    public override string ToString()
    {
        return $"FIGURA TRIANGULO EQUILATERO: LADO: {_lado} COLOR: {_color} AREA: {GetArea()}";
    }
}