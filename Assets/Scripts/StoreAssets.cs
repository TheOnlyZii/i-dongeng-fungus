using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Soomla.Store;

public class StoreAssets : IStoreAssets{

	/// <summary>
	/// see parent.
	/// </summary>
	public int GetVersion() {
		return 0;
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualCurrency[] GetCurrencies() {
		return new VirtualCurrency[]{};
	}

	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualGood[] GetGoods() {
		return new VirtualGood[] {STICKER_BUNDLE_LTVG, DONGENG_EPISODE_2_LTVG, DONGENG_ALL_EPISODE, ALL_TEMPLATE_LTVG};
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualCurrencyPack[] GetCurrencyPacks() {
		return new VirtualCurrencyPack[] {};
	}
	
	/// <summary>
	/// see parent.
	/// </summary>
	public VirtualCategory[] GetCategories() {
		return new VirtualCategory[]{};
	}

	/// <summary>
	/// see parent.
	/// </summary>
	public LifetimeVG[] GetNonConsumableItems ()
	{
		return new LifetimeVG[]{STICKER_BUNDLE_LTVG, DONGENG_EPISODE_2_LTVG, DONGENG_ALL_EPISODE, ALL_TEMPLATE_LTVG};
	}

	//Static Final Member

	public const string STICKER_BUNDLE_PRODUCT_ID = "android.test.purchased";

	public const string DONGENG_EPISODE_2_LIFETIME_ID = "android.test.purchased";

	public const string DONGENG_ALL_EPISODE_LIFETIME_ID = "android.test.purchased";

	public const string ALL_TEMPLATE_PRODUCT_ID = "android.test.purchased";

	//Buka semua sticker
	public static LifetimeVG STICKER_BUNDLE_LTVG = new LifetimeVG (
		"Sticker Bundle",
		"Membuka bundle stiker di buku stiker",
		"STICKER_BUNDLE_ID",
		new PurchaseWithMarket("STICKER_BUNDLE_PRODUCT_ID", 0.99)
	);

	public static LifetimeVG DONGENG_EPISODE_2_LTVG = new LifetimeVG(
		"Episode 2",
		"Membuka Episode 2",
		"DONGENG_EPISODE_2_ID",
		new PurchaseWithMarket("DONGENG_EPISODE_2_LIFETIME_ID", 3.99)
	);

	public static LifetimeVG DONGENG_ALL_EPISODE = new LifetimeVG(
		"Unlock All Episode",
		"Membuka semua episode di I-Dongeng",
		"DONGENG_ALL_EPISODE_ID",
		new PurchaseWithMarket("DONGENG_ALL_EPISODE_LIFETIME_ID", 9.99)
	);

	public static LifetimeVG ALL_TEMPLATE_LTVG = new LifetimeVG(
		"Unlock Sticker Template",
		"Membuka semua template di buku stiker",
		"ALL_TEMPLATE_ID",
		new PurchaseWithMarket("ALL_TEMPLATE_PRODUCT_ID", 1.99)
	);	
}
