using Xunit;

namespace VirtualMemorySharp.Tests;

public class InfoTests
{
	[Fact]
	public void VersionTest()
	{
		Assert.False(string.IsNullOrWhiteSpace(VirtualMemory.Version));
	}
}
