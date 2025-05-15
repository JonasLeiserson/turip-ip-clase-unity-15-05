using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject Prefab1;
    // Start is called before the first frame update
    void Start()
    {
        spawneaprefab();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spawneaprefab()
    {
        Instantiate(Prefab1);
    }

}
