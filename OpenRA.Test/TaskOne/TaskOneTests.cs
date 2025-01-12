using System.Reflection;
using NUnit.Framework;
using OpenRA.Primitives;

namespace OpenRA.Test
{
	[TestFixture]
	public class TaskOneTests
	{
		[TestCase(TestName = "Actor contains a non-public method named Initialize")]
		public void NewInitializeMethodTest()
		{
			var hasInitialize = typeof(Actor).GetMethod("Initialize", BindingFlags.NonPublic | BindingFlags.Instance);
			Assert.IsNotNull(hasInitialize, "Actor does not contain an Initialize method");
		}

		[TestCase(TestName = "Actor constructor only has correct parameters only")]
		public void ActorConstructorParamTest()
		{
			var correctConstructor = typeof(Actor).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance,
													new[] { typeof(World), typeof(string), typeof(TypeDictionary) });

			Assert.IsNotNull(correctConstructor, "Actor has incorrect constructor parameters");
		}
	}
}
