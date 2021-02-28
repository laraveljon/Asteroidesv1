
using UnityEngine;

public class DetectorBordepantalla : MonoBehaviour
{

    [SerializeField] private bool esVertical;

    // este metodo es invocado por unity
    private void OnTriggerEnter2D(Collider2D colliderAjeno)
    {
        if (this.esVertical)
        {
            colliderAjeno.transform.position = new Vector2(colliderAjeno.transform.position.x, -colliderAjeno.transform.position.y);
        }
        else
        {
            colliderAjeno.transform.position = new Vector2(-colliderAjeno.transform.position.x, colliderAjeno.transform.position.y);
        }

      
    }
}
