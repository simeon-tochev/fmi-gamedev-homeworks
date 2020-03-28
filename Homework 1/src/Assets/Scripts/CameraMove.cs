using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField]
    private float positionDifference;

    [SerializeField]
    private Transform playerObject;

    private Vector3 playerPosition;
    private float playerRotation;

    private Vector3 targetPosition;

    void Update()
    {
        playerPosition = playerObject.position;
        playerRotation = playerObject.rotation.eulerAngles.y;

        transform.LookAt(playerPosition);
        targetPosition = new Vector3(playerPosition.x + positionDifference * -Mathf.Sin(Mathf.Deg2Rad * playerRotation), playerPosition.y + positionDifference, playerPosition.z + positionDifference * -Mathf.Cos(Mathf.Deg2Rad * playerRotation));

        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f); 
    }
}
