using NUnit.Framework;
using System.Collections.Generic;
using Kata;

namespace AlgorithmAndDataStructTest;

[TestFixture]
public class BankOCRShould
{
    BankOCR bank = new BankOCR();

    [SetUp]
    public void Setup()
    {
        
    }

    [Test(Description = "IsValid")]
    public void TestIsValide() //bank.DefineStatusCode("3458?2865"
    {
        Assert.AreEqual(bank.IsValidAccountNumber("345882865"), true);
        Assert.AreEqual(bank.IsValidAccountNumber("490067715"), false);
    }

    [Test(Description = "DefineStatus")]
    public void TestDefineStatus() //bank.DefineStatusCode("3458?2865"
    {
        Assert.AreEqual(bank.DefineStatusCode("490067715"), "490067715 ERR");
        Assert.AreEqual(bank.DefineStatusCode("3458?2865"), "3458?2865 ILL");
        Assert.AreEqual(bank.DefineStatusCode("345882865"), "345882865");
    }

}