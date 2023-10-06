namespace P2_2_Figuras;

public class Rectangulo : Figura
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

    /*getter --> devuelve enteros
    public int GetBase()
    {
        return _base;
    }

    //setter
    public void SetAltura(int altura)
    {
        this._altura = altura;
    }
    */
}