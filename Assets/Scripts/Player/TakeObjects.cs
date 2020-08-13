using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObjects : MonoBehaviour
{
    [SerializeField] private bool iHaveFire;
    public bool IHaveFire { get => iHaveFire; set => iHaveFire = value; }
    [SerializeField] private GameObject fireStinguisher;

    private void Update()
    {
        Check();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Destroy(other.gameObject);
            iHaveFire = true;
        }
    }
    public void Check()
    {
        if (iHaveFire == true)
            fireStinguisher.SetActive(true);
    }
}



