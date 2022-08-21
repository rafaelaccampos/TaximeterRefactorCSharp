using FluentAssertions;
using NUnit.Framework;
using System;

namespace TaximeterRefactoring.UnityTests
{
    public class TaximeterAfterTests
    {
        private const decimal DISTANCE = 1000;

        [TestCase(22)]
        [TestCase(23)]
        public void TaximeterAfterShouldBeAbleToCalculateRateWhenIsOvernight(int hour)
        {
            var dataAtual = new DateTime(2022, 08, 20, hour, 00, 00);
            var taximeterAfter = new TaximeterAfter();

            var getOvernightRate = taximeterAfter.GetRate(DISTANCE, dataAtual);

            getOvernightRate.Should().Be(3900);
        }

        [Test]
        public void TaximeterAfterShouldBeAbleToCalculateRateWhenIsSunday()
        {
            var dataAtual = new DateTime(2022, 08, 21, 21, 00, 00);
            var taximeterAfter = new TaximeterAfter();

            var getSundayRate = taximeterAfter.GetRate(DISTANCE, dataAtual);

            getSundayRate.Should().Be(2900);
        }

        [Test]
        public void TaximeterAfterShouldBeAbleToCalculateRateWhenIsNormalDays()
        {
            var dataAtual = new DateTime(2022, 08, 20, 21, 00, 00);
            var taximeterAfter = new TaximeterAfter();

            var getNormalDaysRate = taximeterAfter.GetRate(DISTANCE, dataAtual);

            getNormalDaysRate.Should().Be(2100);
        }
    }
}