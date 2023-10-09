using System.Drawing;

namespace P2_2_Figuras;

internal class Circulo : Figura
{
    protected double _radio;

    public Circulo(double _radio, Color color)
    {
        this._radio = _radio;
        this._color = color;
    }

    public override double GetArea()
    {
        return Math.PI * (this._radio * this._radio);
    }

    //getter --> devuelve enteros
    public double GetBase()
    {
        return this._radio;
    }

    //setter
    public void SetAltura(int radio)
    {
        this._radio = radio;
    }

    //tostring
    public override string ToString()
    {
        return $"FIGURA RECTANGULO: RADIO: {_radio} COLOR: {_color} AREA: {GetArea()}";
    }
}