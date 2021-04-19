using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform _gameObject;
    public float minY;
    public float maxY;
    public float minX;
    public float maxX;



    void Update()
    {
        UpdateFeetPosition();
    }

    private void UpdateFeetPosition()
    {
        try
        {
            transform.position = new Vector3(
                Mathf.Clamp(_gameObject.position.x, minX, maxX),
                Mathf.Clamp(_gameObject.position.y, minY, maxY),
                transform.position.z 
              );

        }

        catch (Exception error)
        {
            Debug.LogError(error);
        }
    }
}
