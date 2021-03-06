﻿using NUnit.Framework;
using SharpTestsEx;
using Toggle.Net.Internal;
using Toggle.Net.Providers.TextFile;
using Toggle.Net.Tests.TextFile.Helpers;

namespace Toggle.Net.Tests.TextFile
{
	public class RemarkTest
	{
		[Test]
		public void ShouldBeAbleToWriteRemarks()
		{
			var content = new[]
			{
				"#this should not throw",
				"someflag=true",
				" # and neither should this"
			};
			var toggleChecker = new ToggleChecker(new FileProvider(new FileReaderHardCoded(content)));
			toggleChecker.IsEnabled("someflag")
				.Should().Be.True();
		}

		[Test]
		public void ShouldAllowBlankLines()
		{
			var content = new[]
			{
				"				 ",
				"someflag=true",
				"",
				string.Empty
			};
			var toggleChecker = new ToggleChecker(new FileProvider(new FileReaderHardCoded(content)));
			toggleChecker.IsEnabled("someflag")
				.Should().Be.True();
		}
	}
}