using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube_2;
    public GameObject cube_1;
    void Start()
    {
        cube_2.transform.position = new Vector3(5, 2, 3);
    }

    // Update is called once per frame
    void FixeUpdate()
    {
        if (Input.GetKey(KeyCode.Space)) 
        { }
        
    }
   
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;

    }
    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;

    }
    private void OnMouseExit()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

    }      
    public void Button_Click()
    {
        cube_2.transform.localScale = new Vector3(5, 2, 3);
        Debug.Log("Clic");
    }
}
