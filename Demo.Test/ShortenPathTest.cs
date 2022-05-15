using System.Collections.Generic;
using NUnit.Framework;
using Demo;
using System;
[TestFixture]
public class ShortenPathTest
{
    [Test]
    public void Example1()
    {
        Assert.AreEqual("/foo/bar/baz", Challenge.ShortenPath("/foo/../test/../test/../foo//bar/./baz"));
    }
    [Test]
    public void Example2()
    {
        Assert.AreEqual("/foo/bar/baz", Challenge.ShortenPath("/foo/bar/baz"));
    }
    [Test]
    public void Example3()
    {
        Assert.AreEqual("foo/bar/baz", Challenge.ShortenPath("foo/bar/baz"));
    }
    [Test]
    public void Example4()
    {
        Assert.AreEqual("/foo/bar/baz", Challenge.ShortenPath("/../../foo/bar/baz"));
    }
    [Test]
    public void Example5()
    {
        Assert.AreEqual("../../foo/bar/baz", Challenge.ShortenPath("../../foo/bar/baz"));
    }
    [Test]
    public void Example6()
    {
        Assert.AreEqual("/bar/baz", Challenge.ShortenPath("/../../foo/../../bar/baz"));
    }
    [Test]
    public void Example7()
    {
        Assert.AreEqual("../../../bar/baz", Challenge.ShortenPath("../../foo/../../bar/baz"));
    }
}