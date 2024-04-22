using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

  public Action<Item> onItemAdded;
  [SerializeField] InventoryUI targetInventoryUI;

  [SerializeField] List<Item> StartItems = new List<Item>();
  public List<Item> InventoryItems { get; private set; }

  void Start() {
    targetInventoryUI.onClickToInventory += OnClickToInventory;
    InventoryItems = new List<Item>();

    if (StartItems.Count == 0) {
      return;
    }

    for (var i = 0; i < StartItems.Count; i++) {
      AddItem(StartItems[i]);
    }
  }

  void OnClickToInventory(Item obg) {
    FindObjectOfType<PlayerWeapons>().SetWeapon(obg);
  }

  public void AddItem(Item item) {
    InventoryItems.Add(item);

    onItemAdded.Invoke(item);
  }
}
