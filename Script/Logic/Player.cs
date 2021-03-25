using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Status status;
    private FoodValue foodValue;
    private Combat combat;
    private int dna;

    public Status Status { get => status; set => status = value; }
    public FoodValue FoodValue { get => foodValue; set => foodValue = value; }
    public Combat Combat { get => combat; set => combat = value; }
    public int Dna { get => dna; set => dna = value; }

    // Start is called before the first frame update
    void Start()
    {
        Status = new Status();
        FoodValue = new FoodValue();
        Combat = new Combat();
        Dna = GameSystem.Instance.InitialDNA;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
