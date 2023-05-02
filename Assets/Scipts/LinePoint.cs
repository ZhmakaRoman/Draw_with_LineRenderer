using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePoint : MonoBehaviour
{
    [SerializeField] 
    private LineRenderer _linePrefab;
    
    private void Start()
    {
        //начальная ширина
        _linePrefab.startWidth = 0.2f;
        //конечная ширина
        _linePrefab.endWidth = 0.2f;
        _linePrefab.positionCount = 0;

    }

    // Update is called once per frame
    private  void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 currentPoint = GetWorldCoordinate(Input.mousePosition);
            _linePrefab.positionCount++;
            _linePrefab.SetPosition(_linePrefab.positionCount -1,currentPoint);
        }
        
    }

    private Vector2 GetWorldCoordinate(Vector3 mousePosition)
    {
        Vector2 mousePoint = new Vector3(mousePosition.x, mousePosition.y, 1);
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
