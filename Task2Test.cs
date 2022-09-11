using NUnit.Framework;
using System;
using static NUnit.Framework.Assert;
using static Task2.Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(6, 3, 3), Is.EqualTo(3));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(2, -1, 3), Is.EqualTo(-1));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(4, 6123746128734, 1), Is.EqualTo(6123746128734);
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(4, -6123746128734, 1), Is.EqualTo(4);
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(0, 0, 0), Is.EqualTo(0);
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(180.0 - 180.0 * 0.5), Is.EqualTo(Math.PI - Math.PI * 0.5).Within(1e-5));
        That(Deg2Rad(180.0 + 180.0 * 3), Is.EqualTo(Math.PI + Math.PI * 3).Within(1e-5));
        That(Deg2Rad(180.0 - 180.0 * 0.5 - 180.0 * 0.3), Is.EqualTo(Math.PI - Math.PI * 0.5 - Math.PI * 0.3).Within(1e-5));
        That(Deg2Rad(180.0 + 180.0 * 3 + 180.0 * 0.5), Is.EqualTo(Math.PI + Math.PI * 3 + Math.PI * 0.5).Within(1e-5));
        That(Deg2Rad(0), Is.EqualTo(0).Within(1e-5));
        That(Rad2Deg(Math.PI - Math.PI * 0.5), Is.EqualTo(180.0 - 180.0 * 0.5).Within(1e-5));
        That(Rad2Deg(Math.PI + Math.PI * 3), Is.EqualTo(180.0 + 180.0 * 3).Within(1e-5));
        That(Rad2Deg(Math.PI - Math.PI * 0.5 - Math.PI * 0.3), Is.EqualTo(180.0 - 180.0 * 0.5 - 180.0 * 0.3).Within(1e-5));
        That(Rad2Deg(Math.PI + Math.PI * 3 + Math.PI * 0.5), Is.EqualTo(180.0 + 180.0 * 3 + 180.0 * 0.5).Within(1e-5));
        That(Rad2Deg(0), Is.EqualTo(0).Within(1e-5));
    }
}
