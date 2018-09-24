using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraContraolet : MonoBehaviour {

    public GameObject target;
    public float damping = 0.01f;
    Vector3 offset;

    void Start()
    {
        Cursor.visible = false;
        offset = target.transform.position - transform.position;
    }

    void LateUpdate()
    {

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

        Vector3 desiredPosition = target.transform.position - (rotation * offset);
        Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.position = position;
        //transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
    }
}
