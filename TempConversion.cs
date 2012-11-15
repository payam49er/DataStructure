using System;


//This class converts Kelvin, F, C to each other

public class Convert
{
	
    //Method to converts Celsius to Kelvin
    public float ConvertToKelvin(float tempC)
    {
       var kelvin = tempC + 273.15;
       return kelvin;
    }

    //Method to converts Kelvin to Celsius
    public float ConvertToCelsius(float tempK)
    {
        var Celsius = tempK - 273.15;
        return Celsius;
    }

    //Method to convert Celsius to Fahrenheit
    public float ConvertToFahrenheit(float tempC)
    {
        var fahrenheit = (tempC * 1.8) + 32.00;
        return fahrenheit;
    }

    
}

class TempConversion
{
    static void Main()
    {
        Convert myTemp = new Convert();
        Console.WriteLine("Please insesrt your temp in Celsius:");
        var temp = (float)Convert.ToDouble(System.Console.ReadLine());
        var tempinKelvin = myTemp.ConvertToKelvin(temp);
        Console.WriteLine("Your tempreture in Kelvin is:{0}", tempinKelvin);

    }





}
