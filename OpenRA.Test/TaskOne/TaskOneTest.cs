using System;
using NUnit.Framework;

namespace OpenRA.Test
{
	[TestFixture]
	public class TaskOneTest
	{
		[TestCase(TestName = "Game can initialize without throwing Exception")]
		public void TestOne()
		{
			try
			{
				Game.InitializeMod("ra", new Arguments("Engine.EngineDir = ..", "Game.Mod = ra"));
				Game.AfterGameStart += () => Game.Exit();
			}
			catch (Exception e)
			{
				Assert.Fail("Game initialization failed");
			}
		}
	}
}
