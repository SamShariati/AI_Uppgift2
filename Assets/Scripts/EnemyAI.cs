using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private float lowHealthThreshhold;
    [SerializeField] private float healthRestoreRate;

    [SerializeField] private float chasingRange;
    [SerializeField] private float shootingRange;

    [SerializeField] private float playerTransform;

    private Material material;
    private float currentHealth
    {
        get { return currentHealth; }
        set { currentHealth = Mathf.Clamp(value, 0, startingHealth); }
    }

    private void Start()
    {
        currentHealth = startingHealth;
        material=GetComponent<MeshRenderer>().material;
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    private void Update()
    {
        currentHealth += Time.deltaTime * healthRestoreRate;
    }

    public void SetColor(Color green)
    {
        material.color = green;
    }
}
