// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EvilForces : ModuleRules
{
	public EvilForces(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"EvilForces",
			"EvilForces/Variant_Platforming",
			"EvilForces/Variant_Combat",
			"EvilForces/Variant_Combat/AI",
			"EvilForces/Variant_SideScrolling",
			"EvilForces/Variant_SideScrolling/Gameplay",
			"EvilForces/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
