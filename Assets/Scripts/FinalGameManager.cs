using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using UnityEngine.UI;
using static JS_Manager.JSManager;

[Serializable]
public class PlayerInfo {
  public int id;
  public string userName;
  public int score;
}

public class FinalGameManager : MonoBehaviour
{

  public Text userListText;
  List<PlayerInfo> dataList = new List<PlayerInfo>(); 

  private void Start() {
    JS_GetUsersList();
  }

  public void ShowUsersList(string json) {
    dataList = ReadFromJson<PlayerInfo>(json);

    string userListString = "User List:\n";
    foreach (PlayerInfo playerInfo in dataList) {
        userListString += "ID: " + playerInfo.id + ", UserName: " + playerInfo.userName + ", Score: " + playerInfo.score + "\n";
    }
    
    userListText.text = userListString;
  }

  public List<T> ReadFromJson<T>(string json) {
    List<T> res = JsonHelper.FromJson<T>(json).ToList();
    return res;
  }
}
