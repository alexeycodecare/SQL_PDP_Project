using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
  public Action<Item> onClickToInventory;

  [SerializeField] Inventory targetInventory;
  [SerializeField] RectTransform itemsPanel;

  readonly List<GameObject> drawnIcons = new List<GameObject>();

  void Start() {
    targetInventory.onItemAdded += OnItemAdded;
  }

  void OnItemAdded(Item obg) => Redraw();

  void onClickIcon(Item item) {
    onClickToInventory.Invoke(item);
  }

  void Redraw() {
    CleanDrawn();

    if (targetInventory.InventoryItems.Count == 0) {
      return;
    }

    for (var i = 0; i < targetInventory.InventoryItems.Count; i++) {

      var item = targetInventory.InventoryItems[i];

      var icon = new GameObject("Icon");
      icon.AddComponent<Button>().onClick.AddListener(() => onClickIcon(item));
      icon.AddComponent<Image>().sprite = item.Icon;
      icon.transform.SetParent(itemsPanel);

      drawnIcons.Add(icon);
    }
  }

  void CleanDrawn() {
    for (var i = 0; i < drawnIcons.Count; i++) {
      Destroy(drawnIcons[i]);
    }
    drawnIcons.Clear();
  }

}
