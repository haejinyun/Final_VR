using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform objectFrontVector;
    [SerializeField] float normalSpeed, runSpeed;
    public float RotaionSpeed = 100;
    public float xRotate = 0;
    public float moveSpeed = 200;
    private float h = 0.0f;
    private float v = 0.0f;


    // Update is called once per frame
    void Update()
    {
        KeyRotation();
    }


    void KeyRotation()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            moveSpeed = runSpeed;
        else
            moveSpeed = normalSpeed;

        float yRotation = Input.GetAxis("Mouse X") * 4f;
        float yRotate = transform.eulerAngles.y + yRotation;
        float xRotation = -Input.GetAxis("Mouse Y") * 4f;
        xRotate = Mathf.Clamp(xRotate + xRotation, -45, 80);
        transform.rotation = Quaternion.Euler(new Vector3(xRotate, yRotate, 0));

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        transform.Translate(moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);

    }


}
