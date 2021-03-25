using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodValue
{
    private int fishValue;
    private int meatValue;
    private int leafValue;
    private int grassValue;
    private int fruitValue;

    public FoodValue()
    {
        fishValue = 1;
        meatValue = 1;
        leafValue = 1;
        grassValue = 1;
        fruitValue = 1;
    }

    FoodValue(int fish, int meat, int leaf, int grass, int fruit)
    {
        fishValue = fish;
        meatValue = meat;
        leafValue = leaf;
        grassValue = grass;
        fruitValue = fruit;
    }

    public int FishValue { get => fishValue; set => fishValue = value; }
    public int MeatValue { get => meatValue; set => meatValue = value; }
    public int LeafValue { get => leafValue; set => leafValue = value; }
    public int GrassValue { get => grassValue; set => grassValue = value; }
    public int FruitValue { get => fruitValue; set => fruitValue = value; }

    public static FoodValue Add(FoodValue one, FoodValue two)
    {
        int newFish = one.fishValue + two.fishValue;
        int newMeat = one.meatValue + two.meatValue;
        int newLeaf = one.leafValue + two.leafValue ;
        int newGrass = one.grassValue + two.grassValue;
        int newFruit = one.fruitValue + two.fruitValue;
        return new FoodValue(newFish, newMeat, newLeaf, newGrass, newFruit);
    }
    public static FoodValue AddMultiple(params FoodValue[] foodValues)
    {
        FoodValue result = new FoodValue();
        if (foodValues.Length <= 0) return result;
        result = foodValues[0];
        for(int i = 1; i < foodValues.Length; i++)
        {
            result = Add(result, foodValues[i]);
        }
        return result;
    }
}
