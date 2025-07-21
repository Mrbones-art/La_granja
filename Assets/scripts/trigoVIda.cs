using UnityEngine;
using System.Collections;
public class trigoVIda : MonoBehaviour
{
    public float tiempoEspera = 8f;
    public Animator animator;
    public int estadoTrigo = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }

    // Update is called once per frame

    private IEnumerator CambiarEstado()
    {
        while (estadoTrigo < 4)
        {
            animator.SetInteger("estado", estadoTrigo);
            estadoTrigo++;
            yield return new WaitForSeconds(tiempoEspera);
        }
    }
    
        
    
}
