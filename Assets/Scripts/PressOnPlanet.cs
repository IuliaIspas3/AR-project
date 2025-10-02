using Assets.Scripts;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PressOnAPlanet : PressInputBase
{
    [SerializeField] private ObjectInfoUI uiManager;

    protected override void OnPressBegan(Vector3 position)
    {
        base.OnPressBegan(position);

        Ray ray = Camera.main.ScreenPointToRay(position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.GetComponent<ARPlane>() == null)
            {
                Debug.Log(hitObject.name);
                uiManager.ShowInfo(hitObject.name);
            }
        }
    }
    
}