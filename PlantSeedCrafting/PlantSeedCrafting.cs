using RaftModLoader;
﻿using UnityEngine;
using HMLLibrary;
using HarmonyLib;

public class PlantSeedCrafting : Mod
{
    public void Start()
    {
		Item_Base[] strawberryItem = new Item_Base[] { ItemManager.GetItemByName("Strawberry") };
		Item_Base[] watermelonItem = new Item_Base[] { ItemManager.GetItemByName("Watermelon") };
		Item_Base[] pineappleItem = new Item_Base[] { ItemManager.GetItemByName("Pineapple") };
		Item_Base[] coconutItem = new Item_Base[] { ItemManager.GetItemByName("Coconut") };
		Item_Base[] bananaItem = new Item_Base[] { ItemManager.GetItemByName("Banana") };
		Item_Base[] mangoItem = new Item_Base[] { ItemManager.GetItemByName("Mango") };
		Item_Base[] plankItem = new Item_Base[] { ItemManager.GetItemByName("Plank") };
		Item_Base[] blackFlowerItem = new Item_Base[] { ItemManager.GetItemByName("Flower_Black") };
		Item_Base[] blueFlowerItem = new Item_Base[] { ItemManager.GetItemByName("Flower_Blue") };
		Item_Base[] redFlowerItem = new Item_Base[] { ItemManager.GetItemByName("Flower_Red") };
		Item_Base[] yellowFlowerItem = new Item_Base[] { ItemManager.GetItemByName("Flower_Yellow") };
		Item_Base[] whiteFlowerItem = new Item_Base[] { ItemManager.GetItemByName("Flower_White") };

		//Banana
		CreateRecipe(ItemManager.GetItemByName("Seed_Banana"), 1, new CostMultiple(bananaItem, 1));
		//Birch
		CreateRecipe(ItemManager.GetItemByName("Seed_Birch"), 1, new CostMultiple(plankItem, 10));
		//Mango
		CreateRecipe(ItemManager.GetItemByName("Seed_Mango"), 1, new CostMultiple(mangoItem, 1));
		//Palm
		CreateRecipe(ItemManager.GetItemByName("Seed_Palm"), 1, new CostMultiple(coconutItem, 1));
		//Pineapple
		CreateRecipe(ItemManager.GetItemByName("Seed_Pineapple"), 1, new CostMultiple(pineappleItem, 1));
		//Pine
		CreateRecipe(ItemManager.GetItemByName("Seed_Pine"), 1, new CostMultiple(plankItem, 10));
		//Strawberry
		CreateRecipe(ItemManager.GetItemByName("Seed_Strawberry"), 1, new CostMultiple(strawberryItem, 1));
		//Watermelon
		CreateRecipe(ItemManager.GetItemByName("Seed_Watermelon"), 1, new CostMultiple(watermelonItem, 1));
		//Black Flower
		CreateRecipe(ItemManager.GetItemByName("Seed_Flower_Black"), 1, new CostMultiple(blackFlowerItem, 1));
		//Blue Flower
		CreateRecipe(ItemManager.GetItemByName("Seed_Flower_Blue"), 1, new CostMultiple(blueFlowerItem, 1));
		//Red Flower
		CreateRecipe(ItemManager.GetItemByName("Seed_Flower_Red"), 1, new CostMultiple(redFlowerItem, 1));
		//Yellow Flower
		CreateRecipe(ItemManager.GetItemByName("Seed_Flower_Yellow"), 1, new CostMultiple(yellowFlowerItem, 1));
		//White Flower
		CreateRecipe(ItemManager.GetItemByName("Seed_Flower_White"), 1, new CostMultiple(whiteFlowerItem, 1));

		Debug.Log("Mod PlantSeedCrafting has been loaded!");
    }

	public static void CreateRecipe(Item_Base pResultItem, int pAmount, params CostMultiple[] pCosts)
	{
		Traverse.Create(pResultItem.settings_recipe).Field("newCostToCraft").SetValue(pCosts);
		Traverse.Create(pResultItem.settings_recipe).Field("learned").SetValue(true);
		Traverse.Create(pResultItem.settings_recipe).Field("learnedFromBeginning").SetValue(true);
		Traverse.Create(pResultItem.settings_recipe).Field("craftingCategory").SetValue(CraftingCategory.Resources);
		Traverse.Create(pResultItem.settings_recipe).Field("amountToCraft").SetValue(pAmount);
	}

	public void OnModUnload()
    {
        Debug.Log("Mod PlantSeedCrafting has been unloaded!");
    }
}