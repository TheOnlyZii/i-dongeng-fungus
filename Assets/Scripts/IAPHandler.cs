using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Soomla.Store;

public class IAPHandler : MonoBehaviour {

	private static IAPHandler iapHandler = null;
	public static string errorMsg = "Status:";

	public static List<LifetimeVG> LifetimeVGList = null;
	
	// Use this for initialization
	void Awake() {
		if (iapHandler == null) {
			iapHandler = this;
			GameObject.DontDestroyOnLoad(this.gameObject);
		}else {
			Destroy(this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {

		SoomlaStore.Initialize(new StoreAssets());

		StoreEvents.OnSoomlaStoreInitialized += OnSoomlaStoreInitialized;
		StoreEvents.OnMarketPurchase += OnMarketPurchase;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnSoomlaStoreInitialized()
	{

	}

	public void OnMarketPurchase(PurchasableVirtualItem pvi, string payload, Dictionary<string, string> extra)
	{
		switch(pvi.ID)
		{
		case StoreAssets.DONGENG_ALL_EPISODE_LIFETIME_ID :

			break;
		}
	}

	//buy when button is pressed
	public void BuyAllEpisode()
	{
		StoreInventory.BuyItem (StoreAssets.DONGENG_ALL_EPISODE.ItemId);
	}

}
