using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerLocation;
    [SerializeField] int yOffset = 2;
    [SerializeField] int zOffset = -5;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = new Vector3(playerLocation.position.x, playerLocation.position.y +yOffset, playerLocation.position.z+zOffset);
        
    }
}
