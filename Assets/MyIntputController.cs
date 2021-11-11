using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MyIntputController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public InputActionReference InputA = default;
    public InputActionReference InputB = default;

    public InputActionReference InputX = default;
    public InputActionReference InputY = default;

    private void OnEnable()
    {
        InputA.action.performed += phimA;
        InputB.action.performed += phimB;
        InputX.action.performed += phimX;
        InputY.action.performed += phimY;
    }

    public void phimB(InputAction.CallbackContext context)
    {
        Debug.Log("B");
    }
    public void phimX(InputAction.CallbackContext context)
    {
        Debug.Log("X");
    }
    public void phimY(InputAction.CallbackContext context)
    {
        Debug.Log("Y");
    }
    public void phimA(InputAction.CallbackContext context)
    {
        Debug.Log("A");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
