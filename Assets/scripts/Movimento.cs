using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(HorizontalInput, 0, VerticalInput);
        transform.position += direccion * velocidad * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
