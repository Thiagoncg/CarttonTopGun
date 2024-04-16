using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objetoPrefab;

    void Update()
    {
        // Verifica o clique do mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Converte a posição do clique do mouse para as coordenadas do mundo
            Vector3 posicaoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicaoMouse.z = 0;

            // Instancia o objeto na posição do clique do mouse
            GameObject novoObjeto = Instantiate(objetoPrefab, posicaoMouse, Quaternion.identity);
        }

        // Verifica o clique do mouse para deletar objetos
        if (Input.GetMouseButtonDown(1))
        {
            // Converte a posição do clique do mouse para as coordenadas do mundo
            Vector3 posicaoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicaoMouse.z = 0;

            // Lança um raio para detectar objetos na posição do clique do mouse
            RaycastHit2D hit = Physics2D.Raycast(posicaoMouse, Vector2.zero);

            // Se um objeto foi atingido, deleta-o
            if (hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
