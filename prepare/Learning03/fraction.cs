using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public void SetTop(int top)
    {
        _topNumber = top;
    }

    public int GetTop()
    {
        return _topNumber;
    }

    public void SetBottom(int bottom)
    {
        _bottomNumber = bottom;
    }

    public int GetBottom()
    {
        return _bottomNumber;
    }

    public string GetFractionString()
    {
        return $"{_topNumber} / {_bottomNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / _bottomNumber;
    }
}