using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedPlayer = 3.0f;
    public float SpeedPlayer { get => speedPlayer; set => speedPlayer = value; }
    private float gravity = 10.0f;
    private CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speedPlayer;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);
    }

    public void PointerClick()
    {
        GameManager.Instance.StarGame(true);
    }
}
