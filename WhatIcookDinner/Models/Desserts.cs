namespace WhatIcookDinner.Models;

public class Desserts
{
    public Guid DessertsId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Ingredients { get; set; } = string.Empty;
}
