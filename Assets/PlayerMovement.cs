using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public SpriteRenderer sprite;
    float speed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = new Vector3(transform.position.x + horizontal * speed * Time.deltaTime, transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x, transform.position.y + vertical * speed * Time.deltaTime, transform.position.z);
    }
}
