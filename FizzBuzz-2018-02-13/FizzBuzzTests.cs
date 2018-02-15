using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_2018_02_13
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test, Category("Unit")]
        public void GivenFour_WhenAskingToString_ThenItShouldReturnFour()
        {
            // arrange // act // assert
            $"{new Integer(4)}".Should().Be("4");
        }

        [Test, Category("Unit")]
        public void GivenNine_WhenAskingToString_ThenItShouldReturnFizz()
        {
            // arrange // act // assert
            $"{new Integer(9)}".Should().Be("fizz");
        }

        [Test, Category("Unit")]
        public void GivenTen_WhenAskingToString_ThenItShouldReturnBuzz()
        {
            // arrange // act // assert
            $"{new Integer(10)}".Should().Be("buzz");
        }

        [Test, Category("Unit")]
        public void GivenThirty_WhenAskingToString_ThenItShouldReturnFizzBuzz()
        {
            // arrange // act // assert
            $"{new Integer(30)}".Should().Be("fizzbuzz");
        }
    }

    public class Integer
    {
        private readonly int _value;

        public Integer(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            const string fizz = "fizz";
            const string buzz = "buzz";

            if (_value.IsDivisibleBy(15)) return $"{fizz}{buzz}";
            if (_value.IsDivisibleBy(5)) return buzz;
            if (_value.IsDivisibleBy(3)) return fizz;

            return _value.ToString();
        }
    }

    public static class IntExtensions
    {
        public static bool IsDivisibleBy(this int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}