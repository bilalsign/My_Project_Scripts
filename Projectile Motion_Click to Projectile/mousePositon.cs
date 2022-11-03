using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePositon : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] LayerMask layerMask;
    
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue , layerMask))
        {
            transform.position = raycastHit.point;
        }
    }
}
