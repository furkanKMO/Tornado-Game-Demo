using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public static bool MoveAllowed = false;
    public GameObject mainmenu;
    public void startGame() {
        mainmenu.SetActive(false);
        MoveAllowed = true;
    }
}
