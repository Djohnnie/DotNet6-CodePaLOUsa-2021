using System.Collections.Generic;

namespace _04_SourceGenerator.Generator.Models;

public class ModelDescription
{
    public string Name { get; set; }

    public List<PropertyDescription> Properties { get; } = new List<PropertyDescription>();
}