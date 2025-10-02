namespace Assets.Scripts
{
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.XR.ARFoundation;
    using UnityEngine.XR.ARSubsystems;

    public class Placer : PressInputBase
    {
        [SerializeField] private ARRaycastManager raycastManager;
        [SerializeField] private GameObject objectToPlace;
        private static List<ARRaycastHit> _hits = new();
        private bool _placed;

        protected override void OnPressBegan(Vector3 position)
        {
            base.OnPressBegan(position);
            if (_placed) return;
            if (EventSystem.current.IsPointerOverGameObject()) return;
            if (!raycastManager.Raycast(position, _hits, TrackableType.PlaneWithinPolygon)) return;
            var hitpose = _hits[0].pose;
            hitpose.position.y += 0.05f;
            Instantiate(objectToPlace, hitpose.position, hitpose.rotation);
            _placed = true;
        }
    }
}