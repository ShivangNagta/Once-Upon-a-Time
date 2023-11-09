
using System.Collections;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] GameObject present, past, future;

    void Start()
    {
        present.SetActive(true);
        past.SetActive(false);
        future.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            present.SetActive(true);
            past.SetActive(false);
            future.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            present.SetActive(false);
            past.SetActive(false);
            future.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            present.SetActive(false);
            past.SetActive(true);
            future.SetActive(false);
        }

    }
}
