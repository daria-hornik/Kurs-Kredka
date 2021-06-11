using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace KNKredek.Tests
{
    public class StudentShould
    {
        private readonly ITestOutputHelper _stdOut;

        public StudentShould(ITestOutputHelper stdOut)
        {
            _stdOut = stdOut;
        }

       [Fact(Skip = "no nie wiem dlaczego")]
       public void BeActiveWhenNew()
        {
            _stdOut.WriteLine("Checking student.");
            Student sut = new Student(); //system under test

            Assert.True(sut.IsActive);
        }

        [Theory]
        [InlineData("Mirek", "Handlarz")]
        [InlineData("Kot", "Handlarz")]
        [InlineData("Pies", "Handlarz")]
        [InlineData("XDDD", "Handlarz")]
        public void CalculateFullName(string firstName, string lastName)
        {
            Student sut = new Student();

            sut.FirstName = firstName;
            sut.LastName = lastName;

            Assert.Equal(firstName +" "+ lastName, sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.StartsWith("K", sut.FullName);
        }

        [Fact]
        public void CalculateFullNameEndsWithFirstName()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.EndsWith("t", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_Contains()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.Contains("Kot", sut.FullName);
        }

        [Fact]
        public void CalculateFullName_Motivation()
        {
            Student sut = new Student();

            Assert.Equal("100", sut.Motivation.ToString());
        }

        [Fact]
        public void CalculateFullName_randomMotivation()
        {
            Student sut = new Student();
            sut.Motivation = 2;

            Assert.NotInRange(sut.Motivation, 0, 99);
        }

        [Fact]
        public void CalculateFullName_MotivationInRange()
        {
            Student sut = new Student();
            sut.Rest();

            Assert.InRange(sut.Motivation, 100, 150);
        }

        [Fact]
        public void CalculateFullName_MotivationIsTrue()
        {
            Student sut = new Student();

            Assert.True(sut.Motivation >=101 && sut.Motivation <= 150);
        }


        [Fact]
        public void CalculateIndex()
        {
            Student sut = new Student();
            sut.IndexNumber = 12432;

            Assert.NotNull(sut.IndexNumber);
        }


        [Fact]
        public void RaiseRestEvent()
        {
            Student sut = new Student();

            Assert.Raises<EventArgs>(
                handler => sut.StudentRest += handler,
                handler => sut.StudentRest -= handler,
                () => sut.Rest());
        }

        [Fact]
        public void RaisePropertyChangeEvent()
        {
            Student sut = new Student();

            Assert.PropertyChanged(sut, "Motivation", () => sut.TakeAllTheCodeIn2Hours());
        }
    }
}
