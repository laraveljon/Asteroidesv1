
using UnityEngine;

public class Asteroide_P : MonoBehaviour
{
    private float velocidad = 0.9f;
    private float velocidadDeRotacion;
    private Vector2 direccionDeMovimiento;

    // Update is called once per frame

    private void Start()
    {
        this.direccionDeMovimiento = Random.insideUnitCircle.normalized;
        this.velocidadDeRotacion = Random.Range(30f, 60f);
    }
    private void Update()
    {
        MovimientoConstanteAsteroide();
        RotarerAteroide();
        
    }

    private void MovimientoConstanteAsteroide()
    {
        this.transform.Translate(this.direccionDeMovimiento * this.velocidad * Time.deltaTime);
       
        //this.transform.position = new Vector2(this.transform.position.x + this.velocidad * Time.deltaTime, (this.transform.position.y + 0.9f * Time.deltaTime));
    }

    private void RotarerAteroide()
    {
        this.transform.Rotate(0f, 0f, this.velocidadDeRotacion * Time.deltaTime, Space.Self);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<ControllerNave>() != null)
        {
            Debug.Log("Collision con la nave");
        }
    }


}
