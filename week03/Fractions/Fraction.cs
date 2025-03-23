using System;

public class Fraction
{
    // Private attributes for numerator and denominator
    private int _top;
    private int _bottom;

    // No-argument constructor - initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with numerator only - denominator defaults to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with both numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as a string (e.g. "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction (e.g. 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
