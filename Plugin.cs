using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace ChestSnap
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class Plugin : BaseUnityPlugin
	{
		public const string ModName = "ChestSnap", ModVersion = "0.0.4", ModGUID = "com.Frogger." + ModName;
		private static Harmony harmony = new(ModGUID);
		public static Plugin _self;

		void Awake()
		{
			_self = this;
			harmony.PatchAll();
		}


		[HarmonyPatch]
		public class Patch
		{
			[HarmonyPatch(typeof(ZNetScene), "Awake"), HarmonyPostfix]
			public static void ZNetSceneAwakePatch()
			{
				SnappointHelper.AddSnappoints("piece_chest_wood", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				#region loot_chests
				/*#region wood
				SnappointHelper.AddSnappoints("Chest", new Vector3[]
				{
					new (0.45f, 0f, 0.28f),
					new (0.45f, 0f, -0.28f),
					new (-0.45f, 0f, 0.28f),
					new (-0.45f, 0f, -0.28f),
					new (0.5f, 0.52f, 0.35f),
					new (0.5f, 0.52f, -0.35f),
					new (-0.5f, 0.52f, 0.35f),
					new (-0.5f, 0.52f, -0.35f)
				});
				SnappointHelper.AddSnappoints("loot_chest_wood", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("shipwreck_karve_chest", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_blackforest", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_heath", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_meadows", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_meadows_buried", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_mountains", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_swamp", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				#endregion
				#region stone
				SnappointHelper.AddSnappoints("loot_chest_stone", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("stonechest", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_fCrypt", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_forestcrypt", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_mountaincave", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_plains_stone", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_sunkencrypt", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				SnappointHelper.AddSnappoints("TreasureChest_trollcave", new Vector3[]
				{
					new (0.8f, 0f, 0.37f),
					new (0.8f, 0f, -0.37f),
					new (-0.8f, 0f, 0.37f),
					new (-0.8f, 0f, -0.37f),
					new (0.65f, 0.8f, 0.35f),
					new (0.65f, 0.8f, -0.35f),
					new (-0.65f, 0.8f, 0.35f),
					new (-0.65f, 0.8f, -0.35f)
				});
				#endregion*/
				#endregion
				SnappointHelper.AddSnappoints("piece_chest", new Vector3[]
				{
					new (0.9f, 0f, 0.47f),
					new (0.9f, 0f, -0.47f),
					new (-0.9f, 0f, 0.47f),
					new (-0.9f, 0f, -0.47f),
					new (0.7f, 1.1f, 0.47f),
					new (0.7f, 1.1f, -0.47f),
					new (-0.7f, 1.1f, 0.47f),
					new (-0.7f, 1.1f, -0.47f)
				});
				SnappointHelper.AddSnappoints("piece_chest_private", new Vector3[]
				{
					new (0.45f, 0f, 0.25f),
					new (0.45f, 0f, -0.25f),
					new (-0.45f, 0f, 0.25f),
					new (-0.45f, 0f, -0.25f),
					new (0.36f, 0.55f, 0.23f),
					new (0.36f, 0.55f, -0.23f),
					new (-0.36f, 0.55f, 0.23f),
					new (-0.36f, 0.55f, -0.23f)
				});
				SnappointHelper.AddSnappoints("piece_chest_blackmetal", new Vector3[]
				{
					new (1.1f, 0f, 0.7f),
					new (1.1f, 0f, -0.7f),
					new (-1.1f, 0f, 0.7f),
					new (-1.1f, 0f, -0.7f),
					new (0.85f, 1.07f, 0.6f),
					new (0.85f, 1.07f, -0.6f),
					new (-0.85f, 1.07f, 0.6f),
					new (-0.85f, 1.07f, -0.6f)
				});
				SnappointHelper.AddSnappoints("rk_crate", new Vector3[]
				{
					new (0.3f, 0f, 0.3f),
					new (0.3f, 0f, -0.3f),
					new (-0.3f, 0f, 0.3f),
					new (-0.3f, 0f, -0.3f),
					new (0.3f, 0.62f, 0.3f),
					new (0.3f, 0.62f, -0.3f),
					new (-0.3f, 0.62f, 0.3f),
					new (-0.3f, 0.62f, -0.3f)
				});
				SnappointHelper.AddSnappoints("rk_crate2", new Vector3[]
				{
					new (0.5f, -0.018f, 0.5f),
					new (0.5f, -0.018f, -0.5f),
					new (-0.5f, -0.018f, 0.5f),
					new (-0.5f, -0.018f, -0.5f),
					new (0.5f, 1.042f, 0.5f),
					new (0.5f, 1.042f, -0.5f),
					new (-0.5f, 1.042f, 0.5f),
					new (-0.5f, 1.042f, -0.5f)
				});
				SnappointHelper.AddSnappoints("piece_chest_treasure", new Vector3[]
				{
					new (0.55f, -0.018f, 0.36f),
					new (0.55f, -0.018f, -0.36f),
					new (-0.55f, -0.018f, 0.36f),
					new (-0.55f, -0.018f, -0.36f),
					new (0.4f, 0.55f, 0.3f),
					new (0.4f, 0.55f, -0.3f),
					new (-0.4f, 0.55f, 0.3f),
					new (-0.4f, 0.55f, -0.3f)
				});
				SnappointHelper.AddSnappoints("MS_piece_chest_branch", new Vector3[]
				{
					new (-0.55f, 0.05f, 0.74f),
					new (-0.55f, 0.05f, -0.28f),
					new (-0.55f, 0.8f, 0.74f),
					new (-0.55f, 0.8f, -0.28f),
					new (1f, 0.05f, 0.74f),
					new (1f, 0.05f, -0.28f),
					new (1f, 0.8f, 0.74f),
					new (1f, 0.8f, -0.28f)
				});
				SnappointHelper.AddSnappoints("MS_piece_chest_redstone", new Vector3[]
				{
					new (1f, 0f, 0.4f),
					new (1f, 0f, -0.4f),
					new (-1f, 0f, 0.4f),
					new (-1f, 0f, -0.4f),
					new (0.85f, 0.65f, 0.4f),
					new (0.85f, 0.65f, -0.4f),
					new (-0.85f, 0.65f, 0.4f),
					new (-0.85f, 0.65f, -0.4f)
				});
				SnappointHelper.AddSnappoints("piece_appleBox", new Vector3[]
				{
					new (-0.34f, -0.87f, 0.68f),
					new (0.45f, -0.87f, 0.68f),
					new (-0.34f, -0.87f, -0.53f),
					new (0.45f, -0.87f, -0.53f),
					new (-0.34f, -0.3f, 0.68f),
					new (0.45f, -0.3f, 0.68f),
					new (-0.34f, -0.3f, -0.53f),
					new (0.45f, -0.3f, -0.53f)
				});
				SnappointHelper.AddSnappoints("piece_garlicBox", new Vector3[]
				{
					new (-0.34f, -0.87f, 0.68f),
					new (0.45f, -0.87f, 0.68f),
					new (-0.34f, -0.87f, -0.53f),
					new (0.45f, -0.87f, -0.53f),
					new (-0.34f, -0.3f, 0.68f),
					new (0.45f, -0.3f, 0.68f),
					new (-0.34f, -0.3f, -0.53f),
					new (0.45f, -0.3f, -0.53f)
				});
				SnappointHelper.AddSnappoints("piece_pepperBox", new Vector3[]
				{
					new (-0.34f, -0.87f, 0.68f),
					new (0.45f, -0.87f, 0.68f),
					new (-0.34f, -0.87f, -0.53f),
					new (0.45f, -0.87f, -0.53f),
					new (-0.34f, -0.3f, 0.68f),
					new (0.45f, -0.3f, 0.68f),
					new (-0.34f, -0.3f, -0.53f),
					new (0.45f, -0.3f, -0.53f)
				});
				SnappointHelper.AddSnappoints("piece_potatoBox", new Vector3[]
				{
					new (-0.34f, -0.87f, 0.68f),
					new (0.45f, -0.87f, 0.68f),
					new (-0.34f, -0.87f, -0.53f),
					new (0.45f, -0.87f, -0.53f),
					new (-0.34f, -0.3f, 0.68f),
					new (0.45f, -0.3f, 0.68f),
					new (-0.34f, -0.3f, -0.53f),
					new (0.45f, -0.3f, -0.53f)
				});
				SnappointHelper.AddSnappoints("piece_saltBox", new Vector3[]
				{
					new (-0.34f, -0.87f, 0.68f),
					new (0.45f, -0.87f, 0.68f),
					new (-0.34f, -0.87f, -0.53f),
					new (0.45f, -0.87f, -0.53f),
					new (-0.34f, -0.3f, 0.68f),
					new (0.45f, -0.3f, 0.68f),
					new (-0.34f, -0.3f, -0.53f),
					new (0.45f, -0.3f, -0.53f)
				});
				SnappointHelper.AddSnappoints("piece_tomatoBox", new Vector3[]
				{
					new (-0.34f, -0.87f, 0.68f),
					new (0.45f, -0.87f, 0.68f),
					new (-0.34f, -0.87f, -0.53f),
					new (0.45f, -0.87f, -0.53f),
					new (-0.34f, -0.3f, 0.68f),
					new (0.45f, -0.3f, 0.68f),
					new (-0.34f, -0.3f, -0.53f),
					new (0.45f, -0.3f, -0.53f)
				});
				SnappointHelper.AddSnappoints("piece_cultivatedGround", new Vector3[]
				{
					new (-1.5f, 0f, 2.3f),
					new (1.5f, 0f, 2.3f),
					new (-1.5f, 0f, -2.26f),
					new (1.5f, 0f, -2.26f),
					new (-0.34f, 1f, 2.3f),
					new (0.45f, 1f, 2.3f),
					new (-0.34f, 1f, -2.26f),
					new (0.45f, 1f, -2.26f)
				});
				SnappointHelper.AddSnappoints("piece_cultivatedGround_big", new Vector3[]
				{
					new (-2.9f, 0f, 2.3f),
					new (1.5f, 0f, 2.3f),
					new (-2.9f, 0f, -2.26f),
					new (1.5f, 0f, -2.26f),
					new (-2.9f, 1f, 2.3f),
					new (0.45f, 1f, 2.3f),
					new (-2.9f, 1f, -2.26f),
					new (0.45f, 1f, -2.26f)
				});
				SnappointHelper.AddSnappoints("piece_cultivatedGround_small", new Vector3[]
				{
					new (-0.15f, 0f, 2.3f),
					new (1.5f, 0f, 2.3f),
					new (-0.15f, 0f, -2.26f),
					new (1.5f, 0f, -2.26f),
					new (-0.15f, 1f, 2.3f),
					new (0.45f, 1f, 2.3f),
					new (-0.15f, 1f, -2.26f),
					new (0.45f, 1f, -2.26f)
				});
				SnappointHelper.AddSnappoints("piece_cultivatedGround_small_small", new Vector3[]
				{
					new (-0.15f, 0f, 0.175f),
					new (1.5f, 0f, 2.3f),
					new (-0.15f, 0f, 0.175f),
					new (1.5f, 0f, -2.26f),
					new (-0.15f, 1f, 0.175f),
					new (1.5f, 1f, 0.175f),
					new (-0.15f, 1f, -2.26f),
					new (1.5f, 1f, -2.26f)
				});
			}
		}

		public void Debug(string msg)
		{
			Logger.LogInfo(msg);
		}
	}
}