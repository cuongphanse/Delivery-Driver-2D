using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] float PickupDelay = 0.5f;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("may bt chay xe khong?????");
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Get Package!!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, PickupDelay);
        }
        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Donee!!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
