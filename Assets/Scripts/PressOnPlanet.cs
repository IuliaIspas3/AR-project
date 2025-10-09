using System;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PressOnAPlanet : PressInputBase
{
    [SerializeField] private ObjectInfoUI uiManager;
    [SerializeField] private GameObject earthUI;
    [SerializeField] private GameObject marsUI;
    [SerializeField] private GameObject mercuryUI;
    [SerializeField] private GameObject venusUI;
    [SerializeField] private GameObject jupiterUI;
    [SerializeField] private GameObject saturnUI;
    [SerializeField] private GameObject uranusUI;
    [SerializeField] private GameObject sunUI;
    [SerializeField] private GameObject neptuneUI;
    private GameObject activeObject;

    private Dictionary<string, GameObject> planetUIMap;

    private void Start()
    {
        planetUIMap = new Dictionary<string, GameObject>
        {
            { "earth", earthUI },
            { "mars", marsUI },
            { "mercury", mercuryUI },
            { "venus", venusUI },
            { "jupiter", jupiterUI },
            { "saturn", saturnUI },
            { "uranus", uranusUI },
            { "sphere", sunUI },
            { "neptune", neptuneUI }
        };

        foreach (var ui in planetUIMap.Values)
        {
            if (ui != null) ui.SetActive(false);
        }

        activeObject = null;
    }
    protected override void OnPressBegan(Vector3 position)
    {
        base.OnPressBegan(position);

        Ray ray = Camera.main.ScreenPointToRay(position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.GetComponent<ARPlane>() != null) return;
            
                
                Debug.Log(activeObject);
                //if (activeObject != null) return;
                Debug.Log(hitObject.name.ToLower());
                
                if (activeObject != null)
                    activeObject.SetActive(false);
                
                if (planetUIMap.TryGetValue(hitObject.name.ToLower(), out GameObject planetUI))
                {
                    planetUI.SetActive(true);
                    activeObject = planetUI;
                }
                else
                {
                    activeObject = null;
                }
                Debug.Log(hitObject.name);
                if (uiManager == null) return;
                uiManager.ShowInfo(hitObject.name);
            
        }
    }
    
}