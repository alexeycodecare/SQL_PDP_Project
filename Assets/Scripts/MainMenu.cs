using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
  [SerializeField] private InputField _input;

  public void PlayGame() {

    if (_input.text != "") {
      StaticData.userName = _input.text;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
      
  }

  public void QuitGame() {
    Application.Quit();
  }
}
