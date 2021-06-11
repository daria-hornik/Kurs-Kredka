using System;
using Xunit;
using DariaHornikLab1Zadanie;

namespace DariaHornikLab8.Tests
{
    public class CusomerShould
    {
        [Fact]
        public void CustomersInsitiveData_IsCorrect()
        {
            Customer customer = new Customer();
            customer.name = "Katarzyna";
            customer.surname = "Nowak";
            customer.pin = "1234";

            Assert.Equal(customer.name + " " + customer.surname + " " + customer.pin, customer.CustomersInsitiveData());
        }

        [Theory]
        [InlineData("Kasia", "Nowak", "1234")]
        [InlineData("Stanis³aw", "Nowacki", "1324")]
        [InlineData("Dylan", "Puszyñski", "9339")]
        public void CustomersInsitiveData_IsCorrectForManyClients(string name, string suroname, string pin)
        {
            Customer customer = new Customer();
            customer.name = name;
            customer.surname = suroname;
            customer.pin = pin;

            Assert.Equal(customer.name + " " + customer.surname + " " + customer.pin, customer.CustomersInsitiveData());
        }

        [Fact]
        public void TopUpAccount_IsCorrect()
        {
            Customer customer = new Customer();
            customer.TopUpAccount(200);

            Assert.Equal(200, customer.accountBalance);
        }

        [Theory]
        [InlineData(400)]
        [InlineData(300)]
        [InlineData(3322)]
        public void TopUpAccount_IsCorrectForMany(float money)
        {
            Customer customer = new Customer();
            customer.TopUpAccount(money);

            Assert.Equal(money, customer.accountBalance);
        }

        [Fact]
        public void IsEnoughtToMakeTransfer_IsCorrect()
        {
            Customer customer = new Customer();
            customer.accountBalance = 2034.43f;

            Assert.True(customer.IsEnoughtToMakeTransfer(2034.43f));
        }
    }
}
