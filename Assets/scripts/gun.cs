using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensitivity = 1.5f;
    [Range(45f, 135f)][SerializeField] float xLimit;
    [Range(0f, 90f)][SerializeField] float yLimit;
    Vector2 rotation = new Vector2(60f, 0f);
    // Start is called before the first frame update
    void Start()
    {
     Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;
        rotation.x += horizontal;
        rotation.y += vertical;
        rotation.x = Mathf.Clamp(rotation.x, 0, xLimit);
        rotation.y = Mathf.Clamp(rotation.y, -yLimit, yLimit);
        var xQuaternion = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuaternion = Quaternion.AngleAxis(rotation.y, Vector3.left);
        transform.localRotation = xQuaternion * yQuaternion;
    }
}
