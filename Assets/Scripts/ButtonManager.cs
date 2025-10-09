using System;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
  
    [SerializeField] private PressOnAPlanet pressOnAPlanet;
    [SerializeField] private ObjectInfoUI uiManager;

    private void Start()
    {
        
    }

    public void OnButtonClick()
    {
        Debug.Log("Button clicked");
        pressOnAPlanet.OnButtonClick();
    }
    
}
