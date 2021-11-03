using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class ButtonHandle : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionManager zz;
    InputAction menuPress;
    public XRInteractorLineVisual lineLelf;
    public XRInteractorLineVisual lineR;
    public GameObject menu;
    void Start()
    {
        InputActionAsset playerControls = zz.actionAssets[0];

        var gameplayActionMap = playerControls.FindActionMap("XRI LeftHand");
        Debug.Log(gameplayActionMap.ToString());
        menuPress = gameplayActionMap.FindAction("Menu");
        Debug.Log(menuPress.ToString());
        menuPress.performed += OnMenuPress;
        menuPress.Enable();
    }
    void OnMenuPress(InputAction.CallbackContext context)
    {
        lineLelf.enabled = !lineLelf.enabled;
        lineR.enabled = !lineR.enabled;
        menu.SetActive(lineR.enabled);
        Debug.Log("that la vl");
        //Handle Menu Click
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
