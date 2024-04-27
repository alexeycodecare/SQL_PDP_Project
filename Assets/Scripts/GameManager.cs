using UnityEngine;
using UnityEngine.SceneManagement;
using static JS_Manager.JSManager;

public class GameManager : MonoBehaviour
{
  private bool gameHasEnded = false;

  public GameObject levelMenuUI;
  public GameObject levelMenuWonUI;
  [SerializeField] private FloatSO scoreSO;

  public void EndGame() {
    if (gameHasEnded == false) {
      gameHasEnded = true;
      levelMenuUI.SetActive(true);
      SavePlayerScore();
    }
  }

  public void CompleatLevel() {
    if (gameHasEnded == false) {
      gameHasEnded = true;
      levelMenuWonUI.SetActive(true);
      SavePlayerScore();
    }
  }

  public void Restart() {
    JS_PlayerRestart();
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void LoadNextLevel() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void GoToMainMenu() {
    JS_PlayerRestart();
    SceneManager.LoadScene("MeinMenuScene");
  }

  private void SavePlayerScore() {
    string userName = StaticData.userName;
    int score = Mathf.RoundToInt(scoreSO.Value);
    JS_SendSaveUser(userName, score);
  }
}
