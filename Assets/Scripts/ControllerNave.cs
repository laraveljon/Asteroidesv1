using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerNave : MonoBehaviour
{

    [Header("Velocidad de Giro")]
    private float velocidadGiro = 100f;
    [Header("Fuerza Propulsion")]
    private float FuerzaPropulsion = 2f;
    [Header("Prefabs Bala")]
    [SerializeField] private GameObject prefabDisparo;

    // Update is called once per frame
    void Update()
    {
        this.ManejarRotacion();
        ManejarPropulsion();
        ManejarDisparos();
    }

    private void ManejarDisparos()
    {
        float disparar = Input.GetAxisRaw("Fire1");
        
        if(disparar > 0f)
        {
            Disparar();
        }

    }


    private void Disparar()
    {
        Debug.Log("This is ");
        GameObject.Instantiate(this.prefabDisparo, this.transform.position, this.transform.rotation);
    }
  

    public void ManejarPropulsion() {

        float propulsion = Input.GetAxis("Vertical");
        if(propulsion > 0f)
        {
            //this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,propulsion));
            this.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0f, propulsion * FuerzaPropulsion));
        }

    }

    public void ManejarRotacion() {

        float grio = -Input.GetAxis("Horizontal");

        this.transform.Rotate(0f, 0f, grio * Time.deltaTime * this.velocidadGiro);
    }
}
