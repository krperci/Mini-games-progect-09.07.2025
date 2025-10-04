using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0f, moveZ);
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }
    void OnCollisionEnter(Collision collision)
    {
        // ???? ??????????? ?? ??????
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over!");

            // ????????? ??? (????? ???????? ?? UI ??? ???????)
            Time.timeScale = 0f;
        }
    }
}

