using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToggle : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemies; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Ellen")
        {
            foreach (GameObject e in _enemies)
            {
                if(!e.activeSelf)
                    e.SetActive(true);
            }
        }
    }
}
