using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    [Header("點擊後要生成的物件")]
    public GameObject obj;
    [Header("AR管理器")]
    public ARRaycastManager arManager;

    private Vector2 pointMouse;

    private List<ARRaycastHit> hits;

    private void Tap()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pointMouse = Input.mousePosition;
            print(pointMouse);
        }

    }
    private void Update()
    {
        Tap();
    }

}
