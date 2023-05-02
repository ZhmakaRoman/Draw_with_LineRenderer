using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [SerializeField] 
    public LineRenderer _linePrefab;
    
    private void Start()
    {
        //начальная ширина
        _linePrefab.startWidth = 0.2f;
        //конечная ширина
        _linePrefab.endWidth = 0.2f;
        _linePrefab.positionCount = 0;

    }


    private  void Update()
    {
        if (_linePrefab.positionCount > 0 && Input.GetMouseButtonDown(0))
        {
            // удаление старой линии
            _linePrefab.positionCount = 0;
        }
        
        if (Input.GetMouseButton(0))
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
