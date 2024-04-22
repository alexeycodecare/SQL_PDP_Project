using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "PDP_Project/Item", order = 0)]
public class Item : ScriptableObject {
  public string Name = "Item";
  public Sprite Icon;
  public int Damage = 1;
  public GameObject Model;
}