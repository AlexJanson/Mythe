using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RectTransform), typeof(ScalableBoxCollider))]
public class VR_UI_Button : MonoBehaviour
{
    public string mainSceneName = "Main";

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "laserPointerPrimitive")
        {
            if (SteamVR_Actions._default.InteractUI.stateDown)
            {
                switch (name)
                {
                    case "Start":
                        StartGame(mainSceneName);
                        break;

                    case "Quit":
                        Application.Quit();
                break;

                }
            }
        }        
    }

    private void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}