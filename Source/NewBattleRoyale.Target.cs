using UnrealBuildTool;
using System.Collections.Generic;

public class NewBattleRoyaleTarget : TargetRules
{
	public NewBattleRoyaleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "NewBattleRoyale" } );
	}
}
