using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTextObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform target;
    public GameObject what_to_instantiate;

    // Update is called once per frame
    void Update()
    {
        GameObject to_create = Instantiate(what_to_instantiate);
        to_create.transform.SetParent(target);
    }
}
