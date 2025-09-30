using Xunit;

namespace Checker.Tests;

public class CheckerTests
{
    [Fact]
    public void NotOkWhenAnyVitalIsOutOfRange()
    {
        Assert.False(Checker.VitalsOk(99f, 102, 70));
    }

    [Fact]
    public void OkWhenAllVitalsWithinRange()
    {
        Assert.True(Checker.VitalsOk(98.1f, 70, 98));
    }

    [Fact]
    public void TemperatureTooLow_ShouldReturnFalse()
    {
        Assert.False(Checker.VitalsOk(94.9f, 70, 98));
    }

    [Fact]
    public void TemperatureTooHigh_ShouldReturnFalse()
    {
        Assert.False(Checker.VitalsOk(102.1f, 70, 98));
    }

    [Fact]
    public void TemperatureAtLowerBound_ShouldReturnTrue()
    {
        Assert.True(Checker.VitalsOk(95f, 70, 98));
    }

    [Fact]
    public void TemperatureAtUpperBound_ShouldReturnTrue()
    {
        Assert.True(Checker.VitalsOk(102f, 70, 98));
    }

    [Fact]
    public void PulseRateTooLow_ShouldReturnFalse()
    {
        Assert.False(Checker.VitalsOk(98f, 59, 98));
    }

    [Fact]
    public void PulseRateTooHigh_ShouldReturnFalse()
    {
        Assert.False(Checker.VitalsOk(98f, 101, 98));
    }

    [Fact]
    public void PulseRateAtLowerBound_ShouldReturnTrue()
    {
        Assert.True(Checker.VitalsOk(98f, 60, 98));
    }

    [Fact]
    public void PulseRateAtUpperBound_ShouldReturnTrue()
    {
        Assert.True(Checker.VitalsOk(98f, 100, 98));
    }

    [Fact]
    public void OxygenSaturationTooLow_ShouldReturnFalse()
    {
        Assert.False(Checker.VitalsOk(98f, 70, 89));
    }

    [Fact]
    public void OxygenSaturationAtLowerBound_ShouldReturnTrue()
    {
        Assert.True(Checker.VitalsOk(98f, 70, 90));
    }
}
