using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    public float speed = 1.5f;
    public float forwardSpeed = 6.0f;
    public float back = 2.0f;
    public float rotate = 2.0f;
    public float jump = 3.0f;

    public Rigidbody rb;

    private Animator anim;
    private CapsuleCollider col;
    private Vector3 velocity;

    private float orgColHeight;
    private Vector3 orgVectColCenter;

    private AnimatorStateInfo currentBaseState;

    static int idle = Animator.StringToHash("Base Layer.Idle");
    static int locoState = Animator.StringToHash("Base Layer.Locomotion");
    static int jumpState = Animator.StringToHash("Base Layer.Jump");

    private void Start()
    {
        anim = GetComponent<Animator>();

        col = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();

        orgColHeight = col.height;
        orgVectColCenter = col.center;
    }

    // Update is called once per frame
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", v);
        anim.SetFloat("Direction", h);
        anim.speed = speed;
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
        rb.useGravity = true;

        velocity = new Vector3(0, 0, v);
        velocity = transform.TransformDirection(velocity);

        if(v > 0.1)
        {
            velocity *= forwardSpeed;
        }
        else if (v < -0.1)
        {
            velocity *= back;
        }

        transform.localPosition += velocity * Time.fixedDeltaTime;

        transform.Rotate(0, h * rotate, 0);
	}
}
