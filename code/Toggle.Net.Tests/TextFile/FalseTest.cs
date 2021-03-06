﻿using NUnit.Framework;
using SharpTestsEx;
using Toggle.Net.Internal;
using Toggle.Net.Providers.TextFile;
using Toggle.Net.Tests.TextFile.Helpers;

namespace Toggle.Net.Tests.TextFile
{
	public class FalseTest
	{
		[Test]
		public void ShouldBeDisabled()
		{
			var content = new[] { "someflag=false" };
			var toggleChecker = new ToggleChecker(new FileProvider(new FileReaderHardCoded(content)));
			toggleChecker.IsEnabled("someflag")
				.Should().Be.False();
		} 
	}
}