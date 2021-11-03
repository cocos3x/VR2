using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChater : MonoBehaviour
{
    // Start is called before the first frame update
    public SkinnedMeshRenderer body;
    public List<Material> lsMaterial;
    void Start()
    {
        
    }
    public void joinGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InHome");
    }
    public void changeBody(int index)
    {
        body.material = lsMaterial[index];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
