using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RectTransform))]
public class VR_UI_Button : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;

    private bool canActivate = false;
    private bool isInStart = false;
    private bool isInQuit = false;

    private void OnEnable()
    {
        ValidateCollider();
    }

    private void OnValidate()
    {
        ValidateCollider();
    }

    private void ValidateCollider()
    {
        rectTransform = GetComponent<RectTransform>();

        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }

        boxCollider.size = rectTransform.sizeDelta;
    }

    private void OnTriggerEnter(Collider other)
    {
        CheckButton();
        canActivate = true;
    }

    private void OnTriggerExit(Collider other)
    {
        CheckButton();
        canActivate = false;
    }

    private void CheckButton()
    {
        switch (gameObject.name)
        {
            case "Start":
                isInStart = !isInStart;
                break;
            case "Quit":
                isInQuit = !isInQuit;
                break;
        }
    }

    private void Update()
    {
        if (canActivate)
        {
            if (SteamVR_Actions._default.InteractUI.GetStateDown(SteamVR_Input_Sources.Any) || Input.GetMouseButtonDown(0))
            {
                if (isInStart)
                {
                    StartGame("Main");
                }

                if (isInQuit)
                {
                    QuitGame();
                }
            }
        }
    }

    public void StartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}