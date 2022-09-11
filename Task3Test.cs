using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task3.Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(3.73772172), Is.EqualTo(-1.0).Within(1e-5));
        That(F(-1.0), Is.EqualTo(0.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(2020), Is.EqualTo(366));
        That(NumberOfDays(300), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('Ю', 2, -1), Is.EqualTo('В'));
        That(Rotate2('C', 1, 2), Is.EqualTo('В'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(27), Is.EqualTo("двадцать семь лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}
