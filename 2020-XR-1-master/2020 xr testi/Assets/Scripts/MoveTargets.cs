using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargets : MonoBehaviour
{
    public Transform movableObject;

    public float moveSpeed = 1f;
    public float turnSpeed = 1f;
    public float scale = 1f;
    public bool moveOnXZPlane = true;

    void Update()
    {

        float forward = Input.GetKey(KeyCode.UpArrow) ? 1.0f : 0.0f;
        float backward = Input.GetKey(KeyCode.DownArrow) ? 1.0f : 0.0f;

        float left = Input.GetKey(KeyCode.LeftArrow) ? 1.0f : 0.0f;
        float right = Input.GetKey(KeyCode.RightArrow) ? 1.0f : 0.0f;

        float up = Input.GetKey(KeyCode.PageUp) ? 1.0f : 0.0f;
        float down = Input.GetKey(KeyCode.PageDown) ? 1.0f : 0.0f;

        transform.Translate(movableObject.up * moveSpeed * up * Time.deltaTime, Space.World);
        transform.Translate(-movableObject.up * moveSpeed * down * Time.deltaTime, Space.World);

        if (moveOnXZPlane)
        {
            transform.Translate(VectorYToZero(movableObject.forward) * moveSpeed * forward * Time.deltaTime, Space.World);
            transform.Translate(VectorYToZero(-movableObject.forward) * moveSpeed * backward * Time.deltaTime, Space.World);

            transform.Translate(VectorYToZero(movableObject.right) * moveSpeed * right * Time.deltaTime, Space.World);
            transform.Translate(VectorYToZero(-movableObject.right) * moveSpeed * left * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(movableObject.forward * moveSpeed * forward * Time.deltaTime, Space.World);
            transform.Translate(-movableObject.forward * moveSpeed * backward * Time.deltaTime, Space.World);

            transform.Translate(movableObject.right * moveSpeed * right * Time.deltaTime, Space.World);
            transform.Translate(-movableObject.right * moveSpeed * left * Time.deltaTime, Space.World);
        }

        Vector3 VectorYToZero(Vector3 vector)
        {
            return new Vector3(vector.x, 0.0f, vector.z);
        }
    }
    


}
