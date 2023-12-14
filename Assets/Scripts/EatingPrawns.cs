using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EatingPrawns : MonoBehaviour
{
    //Variable for text (amount of mangos)
    public TMP_Text prawnText;

    //Variable for the counter
    public float counter = 0f;

    public Restart logic2;

    // Start is called before the first frame update
    void Start()
    {
        //to write the counter beginning in 0/50
      prawnText.text = counter.ToString() + "/10";

      logic2 = GameObject.FindGameObjectWithTag("Logic2").GetComponent<Restart>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When duck collides with a prawn the counter adds 1
     private void OnCollisionEnter(Collision collision)
    {
     
        //when the player touches another gameObject with the tag Mango
        if (collision.gameObject.CompareTag("Food"))
        {
        
            // Destroy the prawn
            Destroy(collision.gameObject);

            //counter adds 1
            counter = counter + 1f;

            //to update the counter in the text
          prawnText.text = counter.ToString() + "/10";
        } 

         if (collision.gameObject.CompareTag("Food2"))
        {
        
            // Destroy the prawn
            Destroy(collision.gameObject);

            //counter adds 1
            counter = 10;

            //to update the counter in the text
          prawnText.text = counter.ToString() + "/10";

          logic2.gameOver();
        } 
    }
}