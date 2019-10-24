using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float m_WalkSpeed;
    public float m_RotationRate;


    private float m_HInput;
    private float m_VInput;
    private int m_LateralInput;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_HInput = Input.GetAxis("Horizontal");
        m_VInput = Input.GetAxis("Vertical");
        m_LateralInput = 0;
        if (Input.GetKey(KeyCode.Q))
        {
            m_LateralInput -= 1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            m_LateralInput += 1;
        }
    }

    private void FixedUpdate()
    {
        Vector3 walk = transform.forward * m_VInput + transform.right * m_LateralInput;
        rb.MovePosition(transform.position + walk.normalized * m_WalkSpeed);
        //transform.position += walk.normalized * m_WalkSpeed;
        transform.Rotate (new Vector3(0f, m_RotationRate * m_HInput, 0f));
    }
}
