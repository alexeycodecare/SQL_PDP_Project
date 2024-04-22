using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
  [SerializeField] private Transform _weaponsTransform;

  void Start() {
    Vector3 weaponsPosition = _weaponsTransform.position;
  }

  public void SetWeapon(Item weapon) {
    Debug.Log(weapon.Name);

    ClearWeapons();

    GameObject weaponModel = Instantiate(weapon.Model);
    weaponModel.transform.SetParent(_weaponsTransform);
    weaponModel.transform.localPosition = Vector3.zero;
    weaponModel.transform.rotation = _weaponsTransform.rotation;
  }

  public void ClearWeapons() {
    if (_weaponsTransform.childCount == 0) return;
    
    for (var i = _weaponsTransform.childCount - 1; i >= 0; i--) {
      Object.Destroy(_weaponsTransform.GetChild(i).gameObject);
    }
  }
}


