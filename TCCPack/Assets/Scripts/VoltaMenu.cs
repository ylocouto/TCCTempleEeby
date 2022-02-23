using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltaMenu : MonoBehaviour
{
    public int Level;

    public void LoadScene(int level)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Application.LoadLevel(level);
    }
}
