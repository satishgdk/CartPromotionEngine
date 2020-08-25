using System;
using PromotionEngine.Interfaces;
using PromotionEngine.Entities;
using System.Collections.Generic;

/// <summary>
/// This class to represent Abstract Factory for Promotion rules which need to provide own logic based on rule
/// </summary>
public abstract class Promotion 
{
	 public int RuleID { get; set; }

	public string RuleName { get; set; }

	public string Description { get; set; }

	public bool IsActive { get; set; }

	public abstract void ApplyRule(Cart cart);
}



/// <summary>
/// This class representing Simple promotion for entities of same Product
/// </summary>
public class SimplePromotion : Promotion
{
    /// <summary>
    /// This Property will hold criteria to apply and parameters involved in processing => rate calculation
    /// </summary>
    public Criteria Group { get; set; }

    public Criteria GetCriteria()
    {
        return Group;
    }

    public void SetCriteria(Criteria value)
    {
        Group = value;
    }

    //Apply the rule on cart 
    public override void ApplyRule(Cart cart)
    {
        // Apply own logic for this family with concrete defination
    }
}

public class GroupedPromotion : Promotion
{

    public decimal OfferedPrice { get; set; }
    public List<Criteria> Groups { get; set; }

    public override void ApplyRule(Cart cart)
    {
        //a apply the calculation logic on group of objects.
    }

}
