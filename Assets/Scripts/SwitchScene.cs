
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public AudioSource switchScene;
    [SerializeField] GameObject present, past, future, canvas, spotlight;
    public Material pastScene, presentScene, futureScene;

    void Start()
    {
        RenderSettings.skybox = presentScene;
        DynamicGI.UpdateEnvironment();

        spotlight.SetActive(false); 
        present.SetActive(true);
        past.SetActive(false);
        future.SetActive(false);
        canvas.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "TheEnd")
        {
            SceneManager.LoadSceneAsync(2);

        }

        canvas.SetActive(true);
        spotlight.SetActive(true);
        if (Input.GetKeyDown(KeyCode.C))
        {
            switchScene.Play();
            RenderSettings.skybox = presentScene;
            DynamicGI.UpdateEnvironment();

            present.SetActive(true);
            past.SetActive(false);
            future.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            switchScene.Play();
            RenderSettings.skybox = futureScene;
            DynamicGI.UpdateEnvironment();

            present.SetActive(false);
            past.SetActive(false);
            future.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            switchScene.Play();
            RenderSettings.skybox = pastScene;
            DynamicGI.UpdateEnvironment();

            present.SetActive(false);
            past.SetActive(true);
            future.SetActive(false);
        }

    }
    void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false );
        spotlight.SetActive(false);
    }
}
