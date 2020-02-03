using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    private string thisone; 
    public void levelpas() {
        thisone = SceneManager.GetActiveScene().name;
        if (thisone=="level1")
        {
            SceneManager.LoadScene("level2", LoadSceneMode.Single);

        }
        if (thisone == "level2")
        {
            SceneManager.LoadScene("level3", LoadSceneMode.Single);

        }
        if (thisone == "level3")
        {
            SceneManager.LoadScene("level1", LoadSceneMode.Single);

        }


    }
}
