using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolor : MonoBehaviour
{
    [SerializeField] private Color HitcolorOne;
    [SerializeField] private int one;
    [SerializeField] private bool enableone;
     [SerializeField] private Color HitcolorTwo;
    [SerializeField] private int two;
    [SerializeField] private bool enabletwo;
     [SerializeField] private Color HitcolorThree;
    [SerializeField] private int three;
    [SerializeField] private bool enablethree;
    private GameObject child1;
    private GameObject child2;
    private GameObject child3;
    private void ships(){
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            Vector2 mousePos2DD = new Vector2(mousePos.x-1, mousePos.y);
            Vector2 mousePos2DDD = new Vector2(mousePos.x+1, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            RaycastHit2D hitt = Physics2D.Raycast(mousePos2DD, Vector2.zero);
            RaycastHit2D hittt = Physics2D.Raycast(mousePos2DDD, Vector2.zero);
            GameObject child1 = hit.transform.GetChild(0).gameObject;
            GameObject child2 = hitt.transform.GetChild(0).gameObject;
            GameObject child3 = hittt.transform.GetChild(0).gameObject;
            if (hit.collider != null)
            {
                string name = hit.collider.gameObject.tag;
                if(name == "one"){
                    enablethree = false;
                    enabletwo = false; 
                    enableone = true;
                    Debug.Log(hit.collider.gameObject.name);

                }
                if(name == "two"){
                    enablethree = false;
                    enabletwo = true; 
                    enableone = false;
                    Debug.Log(hit.collider.gameObject.name);
                }
                if(name == "three"){
                    enablethree = true;
                    enabletwo = false; 
                    enableone = false;
                    Debug.Log(hit.collider.gameObject.name);

                }
                if(enablethree == true) {
                    Debug.Log(hit.collider.gameObject.name);
                    if(three != 0){
                        if(name == "Untagged"){
                            three -= 1;
                            Debug.Log(hit.collider.gameObject.name);
                            Debug.Log(hitt.collider.gameObject.name);
                            Debug.Log(hittt.collider.gameObject.name);
                            SpriteRenderer renderer = hit.collider.GetComponent<SpriteRenderer>();
                            SpriteRenderer rendererr = hitt.collider.GetComponent<SpriteRenderer>();
                            SpriteRenderer rendererrr = hittt.collider.GetComponent<SpriteRenderer>();
                            renderer.color = HitcolorThree;
                            rendererr.color = HitcolorThree;
                            rendererrr.color = HitcolorThree;
                            hit.collider.gameObject.tag = "three";
                            hitt.collider.gameObject.tag = "three";
                            hittt.collider.gameObject.tag = "three";
                        }
                    }
                
                }
                if(enabletwo == true) {
                    if(two != 0){
                        if(name == "Untagged"){
                            two -= 1;
                            Debug.Log(hit.collider.gameObject.name);
                            Debug.Log(hitt.collider.gameObject.name);
                            SpriteRenderer renderer = hit.collider.GetComponent<SpriteRenderer>();
                            SpriteRenderer rendererr = hitt.collider.GetComponent<SpriteRenderer>();
                            renderer.color = HitcolorTwo;
                            rendererr.color = HitcolorTwo;
                            hit.collider.gameObject.tag = "two";
                            hitt.collider.gameObject.tag = "two";
                        }
                    }
                    }
                if(enableone == true) {
                    if(one != 0){
                        if(name == "Untagged"){
                            Debug.Log(hit.collider.gameObject.name);
                            one -= 1;
                            SpriteRenderer renderer = hit.collider.GetComponent<SpriteRenderer>();
                            renderer.color = HitcolorOne;
                        }
                    }
            }
        }
    }
    }
    void OnMouseEnter(){
        child1.SetActive(true);
        if(enabletwo == true){
            child2.SetActive(true);
        }
        if(enablethree == true){
            child3.SetActive(true);
        }
    }
    void OnMouseExit(){
        child1.SetActive(false);
        child2.SetActive(false);
        child3.SetActive(false);
    }
    void Update(){
        ships();
    }

    }



