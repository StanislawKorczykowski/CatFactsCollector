﻿using System.Text.Json.Serialization;

namespace CatFactsCollector.Models;

public class CatFact
{
    [JsonPropertyName("fact")]
    public string? Fact { get; set; }
    
    [JsonPropertyName("length")]
    public string? Length { get; set; }
}