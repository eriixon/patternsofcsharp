using Moq;
using NUnit.Framework;

namespace Command.Tests
{
    [TestFixture]
    public class DepositTest
    {
        private ITransaction deposit;
        private ITransaction withdrwal;
        private IAccount account;

        [SetUp]
        public void Setup()
        {
            var mockAccount = new Mock<IAccount>();
            var mockDeposit = new Mock<Deposit>();

            mockAccount.SetupProperty(a => a.Balance, 50);
            account = mockAccount.Object;
        }

        [Test]
        public void Deposit()
        {
            deposit = new Deposit(account, 50);

            deposit.Execute();
            Assert.That(account.Balance, Is.EqualTo(100));

            deposit.Undo();
            Assert.That(account.Balance, Is.EqualTo(50));
        }

        [Test]
        public void Withdrawal()
        {
            withdrwal = new Withdrawal(account, 25);

            withdrwal.Execute();
            withdrwal.Undo();

            Assert.That(account.Balance, Is.EqualTo(50));
        }
        [Test]
        public void CloneCreateDoublicateDeposite()
        {
            var deposit = new Deposit(account, 50);
            var clone = deposit.Clone();

            Assert.That(deposit.amount, Is.EqualTo(clone.amount));
        }
    }
}
