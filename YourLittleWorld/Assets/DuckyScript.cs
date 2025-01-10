using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using Random = UnityEngine.Random;

public class DuckyScript : MonoBehaviour
{
    public Rigidbody MyRigidbody;

    // Update is called once per frame
    void Update()
    {
        var cameraPositionY = Camera.main.transform.position.y;
        var duckyPositionY = MyRigidbody.position.y;
        var diff = duckyPositionY - cameraPositionY;
        if (diff > 3 || diff < -3)
        {
            Destroy(gameObject);
        }
        duckyMove();
    }

    void duckyMove()
    {
        transform.position += new Vector3(Random.Range(-0.05f, 0.05f), 0, Random.Range(-0.05f, 0.05f)) * Time.deltaTime;
    }
}