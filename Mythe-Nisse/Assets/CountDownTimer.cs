using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public float time;
    private TextMesh timerText;

    void Start()
    {
        timerText = GetComponent<TextMesh>();   
    }
    void Update()
    {
        if(time > 0.0f) time -= Time.deltaTime;
        if(time < 0.0f)
        {
            TimeOver();
        }

        timerText.text = ((int)time).ToString() + " seconds left.";
    }

    private void TimeOver()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
