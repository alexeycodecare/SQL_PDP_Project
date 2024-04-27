using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUserName : MonoBehaviour
{
    [SerializeField] private Text UserNameText;

    void Start() {
        UserNameText.text = StaticData.userName;
    }
}
