using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalForceController : MonoBehaviour
{
    public float speed;
    private Rigidbody m_rb;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        m_rb.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0 , speed * Input.GetAxis("Vertical")));
    }
}
