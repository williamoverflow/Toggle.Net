﻿using NUnit.Framework;
using SharpTestsEx;
using Toggle.Net.Internal;
using Toggle.Net.Specifications;

namespace Toggle.Net.Tests.Toggle
{
	public class MultipleTest
	{
		[Test]
		public void ShouldSupportMultipleFeatures()
		{
			const string trueFlag = "someFlag";
			const string falseFlag = "someOtherFlag";

			var toggle = new ToggleChecker(new InMemoryProvider(
				new Feature(trueFlag, new TrueSpecification()),
				new Feature(falseFlag, new FalseSpecification())
			));

			toggle.IsEnabled(trueFlag).Should().Be.True();
			toggle.IsEnabled(falseFlag).Should().Be.False();
		}
	}
}