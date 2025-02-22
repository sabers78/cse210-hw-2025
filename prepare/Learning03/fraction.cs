using System;

public class Fraction
{
    //variables
    private int _top;
    private int _bottom;


    // methods
    public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // return methods

    public string GetFractionString()
    {  
       
        string fancyFraction = ($"{_top}/{_bottom}");
        return fancyFraction;
    }

    public double GetDecimalValue()
    {
        double dividedThing = (double)_top / (double)_bottom;
        return dividedThing;
    }



    //Maybe delete?

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int newValue)
    {
        _top = newValue;
    }

    
}