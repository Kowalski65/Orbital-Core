using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public GameObject settingsPanel;
    public void OpenPanel()
    {
        settingsPanel.SetActive(true);
    }

}
