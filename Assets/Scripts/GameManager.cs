using UnityEngine;
using UnityEngine.SceneManagement;
using static JS_Manager.JSManager;

public class GameManager : MonoBehaviour
{
  private bool gameHasEnded = false;

  public GameObject levelMenuUI;
  public GameObject levelMenuWonUI;

  public void EndGame() {
    if (gameHasEnded == false) {
      gameHasEnded = true;
      levelMenuUI.SetActive(true);
    }
  }

  public void CompleatLevel() {
    if (gameHasEnded == false) {
      gameHasEnded = true;
      levelMenuWonUI.SetActive(true);
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
    SceneManager.LoadScene("MeinMenuScene");
  }
}
