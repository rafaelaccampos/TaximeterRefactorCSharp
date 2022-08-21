using FluentAssertions;
using NUnit.Framework;
using System;

namespace TaximeterRefactoring.UnityTests
{
    public class TaximeterBeforeTests
    {
        private const decimal DISTANCE = 1000;

        [TestCase(22)]
        [TestCase(23)]
        public void TaximeterBeforeShouldBeAbleToCalculateRateWhenIsOvernight(int hour)
        {
            var dataAtual = new DateTime(2022, 08, 20, hour, 00, 00);
            var taximeterBefore = new TaximeterBefore();

            var getOvernightRate = taximeterBefore.Taxe(DISTANCE, dataAtual);

            getOvernightRate.Should().Be(3900);
        }

        [Test]
        public void TaximeterBeforeShouldBeAbleToCalculateRateWhenIsSunday()
        {
            var dataAtual = new DateTime(2022, 08, 21, 21, 00, 00);
            var taximeterBefore = new TaximeterBefore();

            var getSundayRate = taximeterBefore.Taxe(DISTANCE, dataAtual);

            getSundayRate.Should().Be(2900);
        }

        [Test]
        public void TaximeterBeforeShouldBeAbleToCalculateRateWhenIsNormalDays()
        {
            var dataAtual = new DateTime(2022, 08, 20, 21, 00, 00);
            var taximeterBefore = new TaximeterBefore();

            var getNormalDaysRate = taximeterBefore.Taxe(DISTANCE, dataAtual);

            getNormalDaysRate.Should().Be(2100);
        }
    }
}