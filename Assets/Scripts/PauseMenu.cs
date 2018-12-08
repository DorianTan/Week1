using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject ui;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toggle();
        }
    }

    public void Toggle() // marche pour le bouton "continue"
    {
        ui.SetActive(!ui.activeSelf); //plus simple pour basculer d'un état à l'autre

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
