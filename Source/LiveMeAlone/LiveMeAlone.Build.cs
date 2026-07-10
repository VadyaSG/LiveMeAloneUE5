// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LiveMeAlone : ModuleRules
{
	public LiveMeAlone(ReadOnlyTargetRules Target) : base(Target)
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
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"LiveMeAlone",
			"LiveMeAlone/Variant_Platforming",
			"LiveMeAlone/Variant_Platforming/Animation",
			"LiveMeAlone/Variant_Combat",
			"LiveMeAlone/Variant_Combat/AI",
			"LiveMeAlone/Variant_Combat/Animation",
			"LiveMeAlone/Variant_Combat/Gameplay",
			"LiveMeAlone/Variant_Combat/Interfaces",
			"LiveMeAlone/Variant_Combat/UI",
			"LiveMeAlone/Variant_SideScrolling",
			"LiveMeAlone/Variant_SideScrolling/AI",
			"LiveMeAlone/Variant_SideScrolling/Gameplay",
			"LiveMeAlone/Variant_SideScrolling/Interfaces",
			"LiveMeAlone/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
