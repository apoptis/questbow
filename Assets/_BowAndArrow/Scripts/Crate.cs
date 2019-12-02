using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour, IDamageable
{
    public void Damage(int amount)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer.material.color == Color.red) {
            DestroyImmediate(gameObject);
        } else { TurnRed(); }
    }

    private void TurnRed()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.red;
    }

}