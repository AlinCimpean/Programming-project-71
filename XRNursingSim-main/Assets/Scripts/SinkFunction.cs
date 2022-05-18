using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkFunction : MonoBehaviour
{
    
    [SerializeField] private GameObject Water;
    private Collider handCollider;
    void Start()
    {
        handCollider = GetComponent<Collider>();
        handCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        Water.SetActive(!Water.activeSelf);
    }
}
