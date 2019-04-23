using UnityEngine;
using Valve.VR;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RectTransform), typeof(ScalableBoxCollider))]
public class VR_UI_Button : MonoBehaviour
{
    public string mainSceneName = "Main";
    [Tooltip("place the Teleporter GameObject here (found in Main scene).")]
    public GameObject teleporters;
    [Tooltip("Place the SteamVR_LaserPointer script (which is located on the player's right hand) here.")]
    public SteamVR_LaserPointer laserRightHand;

    private void Awake()
    {
        teleporters.SetActive(false);
        laserRightHand.GetComponent<SteamVR_LaserPointer>();
        laserRightHand.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "laserPointerPrimitive")
        {
            if (SteamVR_Actions._default.InteractUI.GetState(SteamVR_Input_Sources.Any))
            {
                switch (name)
                {
                    case "Start":
                        teleporters.SetActive(true);
                        laserRightHand.enabled = false;
                        this.transform.parent.gameObject.SetActive(false);
                       // StartGame(mainSceneName);
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