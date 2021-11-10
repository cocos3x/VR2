using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class GameMain : MonoBehaviour
{
    // Start is called before the first frame update
    public Text oxy;
    public Text end;
    int unit = 110;
    int unitE = 17;
    //public XRInteractorLineVisual lineLelf;
    //public XRInteractorLineVisual lineR;
    //public GameObject dot;
    void Start()
    {
      //  dot.SetActive(false);
    }
    private void OnEnable()
    {
        oxy.text = "OXYGEN " + unit.ToString() + " UNIT";
        end.text = "ENERGY " + unitE.ToString() + " UNIT";
     //   lineLelf.enabled = true;
     //   lineR.enabled = true;
     //   dot.SetActive(true);
    }
    private void OnDisable()
    {
      //  lineLelf.enabled = false;
        //lineR.enabled = false;
        //dot.SetActive(false);
 
    }
  
    public void showUI()
    {
        gameObject.SetActive(!gameObject.activeSelf);
      
    }
    public void testButton()
    {
        Debug.Log("hihihehe");
    }
    public void setTextOxy()
    {
        unit+=10;
        oxy.text = "OXYGEN " + unit.ToString() + " UNIT";
    }

    public void setTextend()
    {
        unitE--;
        end.text = "ENERGY " + unitE.ToString() + " UNIT";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
