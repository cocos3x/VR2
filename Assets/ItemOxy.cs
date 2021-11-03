using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemOxy : MonoBehaviour
{
    // Start is called before the first frame update
     Image zz;
    public GameMain main;
    public Sprite sp;
    bool isClcik = false;
    void Start()
    {
        zz = gameObject.GetComponent<Image>();
    }
    public void ClickMe()
    {
        if (isClcik) return;
        isClcik = true;
        zz.sprite = sp;
        main.setTextOxy();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
