using UnityEngine;
using Valve.VR;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(RectTransform))]
public class VR_UI_Button : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;

    private SteamVR_LaserPointer laserPointer;

    private void OnEnable()
    {
        ValidateCollider();
        laserPointer = GetComponent<SteamVR_LaserPointer>();
        laserPointer.PointerClick += StartGame;
        laserPointer.PointerClick += QuitGame;
    }

    private void OnDisable()
    {
        laserPointer.PointerClick -= StartGame;
        laserPointer.PointerClick -= QuitGame;
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

    public void StartGame(object sender, PointerEventArgs e)
    {
        //SceneManager.LoadScene(sceneName);
        if (e.target == this.transform)
        {
            Debug.Log("Now load game");
            SceneManager.LoadScene("Main");
        }
        else
        Debug.Log("Did not hit this object!");
    }

    public void QuitGame(object sender, PointerEventArgs e)
    {
        Application.Quit();
    }
}