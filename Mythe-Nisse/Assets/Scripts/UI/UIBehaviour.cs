using UnityEngine.SceneManagement;
using UnityEngine;
using Valve.VR;

public class UIBehaviour : MonoBehaviour
{
    public GameObject confirmQuit = null;

    private void Awake()
    {
        gameObject.GetComponent<Canvas>().enabled = false;
        confirmQuit.GetComponent<Canvas>().enabled = false;
    }

    private void Update()
    {
        if (SteamVR_Actions.default_PauseGame.GetStateDown(SteamVR_Input_Sources.Any))
        {
            PauseGame();
        }
    }

    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PauseGame()
    {
        if (Time.timeScale == 0)
        {
            gameObject.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 1;
        } else
        {
            gameObject.GetComponent<Canvas>().enabled = false;
            Time.timeScale = 0;
        }
    }

    public void QuitGame(bool value)
    {
        gameObject.GetComponent<Canvas>().enabled = value;
        confirmQuit.GetComponent<Canvas>().enabled = value;
    }

    public void ConfirmQuit(bool value)
    {
        if (value == true)
        {
            Application.Quit();
        }
        if (value == false)
        {
            QuitGame(false);
        }
    }
}
