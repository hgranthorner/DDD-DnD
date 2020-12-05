using System;
using System.Linq;
using Core;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class AbilityTests
    {
        private readonly Random _random = new Random();

        [Fact]
        public void AbilityModifierIsCalculatedCorrectly()
        {
            var ability = new Ability();
            // foreach (var val in Enumerable.Range(6, 10))
            // {
                ability.Score = 7;
                var s = ability.Score;
                var mod = s switch
                {
                    6 or 7 => -2,
                    8 or 9 => -1,
                    10 or 11 => 0,
                    12 or 13 => 1,
                    14 or 15 => 2,
                    _ => throw new Exception()
                };

                ability.Modifier.Should().Be(mod);   
            // }
        }
    }
}