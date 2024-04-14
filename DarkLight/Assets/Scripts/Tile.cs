using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public BoxCollider bc;
    public Material white;
    public Material black;
    public Material red;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void White()
    {
        bc.enabled = true;
        GetComponent<Renderer>().material = white;
    }

    public void Black()
    {
        bc.enabled = false;
        GetComponent<Renderer>().material = black;
    }

    public IEnumerator ChangeColor()
    {
        GetComponent<Renderer>().material = red;
        yield return new WaitForSeconds(.2f);

        GetComponent<Renderer>().material = white;
        yield return new WaitForSeconds(.2f);

        GetComponent<Renderer>().material = red;
        yield return new WaitForSeconds(.2f);

        GetComponent<Renderer>().material = white;
        yield return new WaitForSeconds(.2f);

        GetComponent<Renderer>().material = red;
        yield return new WaitForSeconds(.2f);
    }
}
