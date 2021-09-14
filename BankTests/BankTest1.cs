using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
namespace BankTests
{
    [TestClass]
    public class BankTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            { 

            //Assert
            
            StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
            }
        }
       [TestMethod]

         public void Debit_WithAmount_BelowZero()
        {

            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //A&A

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

        }
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {

            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 100;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //A&A

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));



        }

    }
}
