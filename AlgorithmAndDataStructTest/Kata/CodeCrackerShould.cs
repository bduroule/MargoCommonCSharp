namespace AlgorithmAndDataStructTest;
using NUnit.Framework;
using System.Collections.Generic;

using Kata;

[TestFixture]
public class CodeCrackerShould
{
    string key = "!)\"(£*%&><@abcdefghijklmno";

    [SetUp]
    public void Setup()
    {
        
    }

    [Test(Description = "Encrypt")]
    public void TestIsValide() //bank.DefineStatusCode("3458?2865"
    {
        string cresptedMessage = ")dc<djgh a£!";
        string decryptedMessage = "bonjours lea";

        Assert.AreEqual(CodeCracker.Encrypte(decryptedMessage, key), cresptedMessage);
        Assert.AreEqual(CodeCracker.Encrypte("     ", key), "     ");
    }

    [Test(Description = "Decrypte")]
    public void TestDefineStatus() //bank.DefineStatusCode("3458?2865"
    {
        string cresptedMessage = ")dc<djgh a£!";
        string decryptedMessage = "bonjours�lea";

        Assert.AreEqual(CodeCracker.Decrypte("     ", key), "�����");
        Assert.AreEqual(CodeCracker.Encrypte(cresptedMessage, key), decryptedMessage);
    }

}