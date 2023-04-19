using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector3(0,16f,0);
        }
        player.velocity = new Vector2(-dirX * 7f, player.velocity.y);
        player.velocity = new Vector2 (dirX * 6f, player.velocity.y);
    }
}
