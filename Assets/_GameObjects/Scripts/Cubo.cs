using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    enum TiposEstado { Normal, Recargando, Agonizante, Regenerado};
    enum EstadoArma { Normal, Turbo, Superturbo};
    [SerializeField] TiposEstado estado;
    [SerializeField] EstadoArma estadoArma;
    [SerializeField] bool estaMuerto = false;

    public int[] rotaciones;
    public List<Pocima> pocimas;

    private const int NUMERO_CARAS = 6;
    public static int peso = 1;

    float x;//movimiento horizontal
    float z;//moviento vertical

    void Start()
    {
        Disparar();
    }

    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * x * Time.deltaTime);
        transform.Translate(Vector3.forward * z * Time.deltaTime);
    }
    
    private void OnMouseDown()
    {
        /*
         * 
        //Invocar sólo la primera magia
        foreach (Pocima p in pocimas){
            if (p.nombre == "infernal")
            {
                p.HacerMagia();
                pocimas.Remove(p);
                break;
            }
        }
        */
        //Invocar todas las magias
        for (int i=0;i<pocimas.Count;i++)
        {
            if (pocimas[i].nombre == "infernal")
            {
                pocimas[i].HacerMagia();
                pocimas.Remove(pocimas[i]);
                i--;
            }
        }


        /*
        int contador = 0;

        while (contador < 10) {
            contador++;
        }
        print("Fin del while");

        do
        {
            contador--;
        } while (contador > 0);
        print("Fin del do-while");

        int aux;
        bool repetido;
        int[] numeros = new int[10];
        numeros[0] = Random.Range(1, 11);
        for (int j = 1; j < 10; j++)
        {
            do
            {
                repetido = false;
                aux = Random.Range(1, 11);
                //Comprobar repecition
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == aux)
                    {
                        repetido = true;
                        break;
                    }
                }
            } while (repetido);
            numeros[j] = aux;
        }
        

        for (int i = 0; i < numeros.Length; i++)
        {
            print(numeros[i]);
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        pocimas.Add(other.gameObject.GetComponent<Pocima>());
        other.gameObject.SetActive(false);
    }

    void Disparar()
    {
        switch (estadoArma)
        {
            case EstadoArma.Normal:
                break;
            case EstadoArma.Turbo:
                print("TURBO");
                break;
            case EstadoArma.Superturbo:
                print("SUPERTURBO");
                break;
            default:
                print("ERROR");
                break;
        }
        print("FIN DE DISPARAR");
    }

}
