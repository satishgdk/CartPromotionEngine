using System;
using PromotionEngine.Interfaces;

/// <summary>
/// This class representing Simple promotion for entities of same Product
/// </summary>
public class SimplePromotion : Promotion
{
    
    public override void ApplyRule(Cart cart) {
     // Apply own logic for this family with concrete defination
    }
}
