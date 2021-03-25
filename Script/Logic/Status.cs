using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status
{
    private int population;
    private int size;
    private int brain;
    private int intestine;
    private int stomach;

    public Status()
    {
        population = GameSystem.Instance.InitialPopulation;
        size = GameSystem.Instance.InitialStatus;
        brain = GameSystem.Instance.InitialStatus;
        intestine = GameSystem.Instance.InitialStatus;
        stomach = GameSystem.Instance.InitialStatus;
    }

    Status(int population, int size, int brain, int intestine, int stomach)
    {
        this.population = population;
        this.size = size;
        this.brain = brain;
        this.intestine = intestine;
        this.stomach = stomach;
    }

    public int Population { get => population; set => population = value; }
    public int Size { get => size; set => size = value; }
    public int Brain { get => brain; set => brain = value; }
    public int Intestine { get => intestine; set => intestine = value; }
    public int Stomach { get => stomach; set => stomach = value; }

    public static Status Add(Status one, Status two)
    {
        int newPopulation = one.population + two.population;
        int newSize = one.size + two.size;
        int newBrain = one.brain + two.brain;
        int newIntestine = one.intestine + two.intestine;
        int newStomach = one.stomach + two.stomach;
        return new Status(newPopulation, newSize, newBrain, newIntestine, newStomach);
    }
    public static Status AddMultiple(params Status[] statuses)
    {
        Status result = new Status();
        if (statuses.Length <= 0) return result;
        result = statuses[0];
        for (int i = 1; i < statuses.Length; i++)
        {
            result = Add(result, statuses[i]);
        }
        return result;
    }

}
