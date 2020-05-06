using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        // StartCoroutine(LoadAfterTimer());
    }

    // private IEnumerator LoadAfterTimer()
    // {
    //     // the reason we use a coroutine is simply to avoid a quick "flash" of the
    //     // loading screen by introducing an artificial minimum load time :boo:
    //     yield return new WaitForSeconds(2.0f);
    //
    //     LoadScene("Game");
    // }
    //
    // private void LoadScene(string sceneName)
    // {
    //     SceneManager.LoadScene(sceneName);
    // }
}
