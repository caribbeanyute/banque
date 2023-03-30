using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class AccountTests
{
    [TestMethod]
    public void Deposit_WhenAmountIsPositive_ShouldIncreaseBalance()
    {
        // Arrange
        Account account = new Account();
        decimal initialBalance = account.AccountBalance;
        decimal depositAmount = 1000;

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.AreEqual(initialBalance + depositAmount, account.AccountBalance);
    }

    [TestMethod]
    public void Deposit_WhenAmountIsNegative_ShouldThrowException()
    {
        // Arrange
        Account account = new Account();
        decimal depositAmount = -1000;

        // Act and Assert
        Assert.ThrowsException<ApplicationException>(() => account.Deposit(depositAmount));
    }

    [TestMethod]
    public void Withdraw_WhenAmountIsPositive_ShouldDecreaseBalance()
    {
        // Arrange
        Account account = new Account();
        decimal initialBalance = account.AccountBalance;
        decimal withdrawAmount = 1000;

        // Act
        account.Withdraw(withdrawAmount);

        // Assert
        Assert.AreEqual(initialBalance - withdrawAmount, account.AccountBalance);
    }

    [TestMethod]
    public void Withdraw_WhenAmountIsNegative_ShouldThrowException()
    {
        // Arrange
        Account account = new Account();
        decimal withdrawAmount = -1000;

        // Act and Assert
        Assert.ThrowsException<ApplicationException>(() => account.Withdraw(withdrawAmount));
    }

    [TestMethod]
    public void Withdraw_WhenAmountExceedsBalance_ShouldThrowException()
    {
        // Arrange
        Account account = new Account();
        decimal withdrawAmount = account.AccountBalance + 1000;

        // Act and Assert
        Assert.ThrowsException<ApplicationException>(() => account.Withdraw(withdrawAmount));
    }

    [TestMethod]
    public void ToMoneyFormat_ShouldReturnFormattedString()
    {
        // Arrange
        Account account = new Account();
        decimal balance = account.AccountBalance;
        string expectedFormattedString = balance.ToString("C");

        // Act
        string actualFormattedString = account.ToMoneyFormat();

        // Assert
        Assert.AreEqual(expectedFormattedString, actualFormattedString);
    }
}
