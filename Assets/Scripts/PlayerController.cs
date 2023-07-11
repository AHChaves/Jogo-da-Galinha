using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D player;
    private Animator myAnimation;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        player.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;

        myAnimation.SetFloat("MoveX", player.velocity.x);
        myAnimation.SetFloat("MoveY", player.velocity.y);
    }
}
