using System;
using System.Diagnostics;

namespace Checker;

class Checker
{
    public static bool VitalsOk(float temperature, int pulseRate, int oxygenSaturation)
    {
        if (!IsTemperatureOk(temperature))
        {
            Alert("Temperature critical!");
            return false;
        }

        if (!IsPulseRateOk(pulseRate))
        {
            Alert("Pulse Rate is out of range!");
            return false;
        }

        if (!IsOxygenSaturationOk(oxygenSaturation))
        {
            Alert("Oxygen Saturation out of range!");
            return false;
        }

        Console.WriteLine("Vitals received within normal range");
        Console.WriteLine(
            "Temperature: {0} Pulse: {1}, SO2: {2}",
            temperature,
            pulseRate,
            oxygenSaturation
        );
        return true;
    }

    private static bool IsTemperatureOk(float temperature) =>
        temperature >= 95 && temperature <= 102;

    private static bool IsPulseRateOk(int pulseRate) => pulseRate >= 60 && pulseRate <= 100;

    private static bool IsOxygenSaturationOk(int oxygenSaturation) => oxygenSaturation >= 90;

    private static void Alert(string message)
    {
        Console.WriteLine(message);
        for (int i = 0; i < 6; i++)
        {
            Console.Write("\r* ");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\r *");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
