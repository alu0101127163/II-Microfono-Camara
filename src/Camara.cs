using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour
{
    public WebCamTexture webcamTexture;

    void Start()
    {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    void OnGUI()
    {
        if (webcamTexture.isPlaying)
        {
            if(GUI.Button(new Rect(Screen.width/2-300, Screen.height/2+250, 100, 50), "Pausa"))
            {
                webcamTexture.Pause();
            }
        }

        if (!webcamTexture.isPlaying)
        {
            if(GUI.Button(new Rect(Screen.width/2-300, Screen.height/2+250, 100, 50), "Play"))
            {
                webcamTexture.Play();
             }
        }
    }
}