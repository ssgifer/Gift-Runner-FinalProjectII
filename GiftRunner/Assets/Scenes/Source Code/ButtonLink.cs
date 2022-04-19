using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonLink : MonoBehaviour
{
    // Start is called before the first frame update
    public void Home() => SceneManager.LoadScene("HomePage");
    public void City() => SceneManager.LoadScene("City");
    public void Beach() => SceneManager.LoadScene("Beach");
    public void Desert() => SceneManager.LoadScene("Desert");
    public void Sweet() => SceneManager.LoadScene("Sweet");
    public void Scenes() => SceneManager.LoadScene("Scene");
    public void Setting() => SceneManager.LoadScene("Setting");
    public void Title() => SceneManager.LoadScene("Title");
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
