using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayExample : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] private GameObject[] animals;
    /*public PlayerInput controls;
    private void Start() {

        controls = GetComponent<PlayerInput>();
    }*/
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && RayOut())
        {
            int index = Random.Range(0, animals.Length);
            Instantiate(animals[index], hit.point, Quaternion.identity);
        }
    }

    /// <summary>
    /// This return a bool to check if ray collides with an object (object needs a collider)
    /// </summary>
    public bool RayOut()
    {
        LayerMask mask = LayerMask.GetMask("Planes");
        return Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, mask);
    }
}
