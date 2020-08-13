using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restrictions : MonoBehaviour
{
    [SerializeField] private TakeObjects takeObjectsScript;
    [SerializeField] private GameObject restrictionGO;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && takeObjectsScript.IHaveFire == false)
            restrictionGO.SetActive(true);
        else if(other.gameObject.tag == "Player" && takeObjectsScript.IHaveFire == true)
        Destroy(this.gameObject);
       
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
            restrictionGO.SetActive(false);
    }

}
