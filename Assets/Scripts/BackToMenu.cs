using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public void OpenPanel()
    {
        settingsPanel.SetActive(false);
    }

}
