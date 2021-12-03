﻿using System;
using System.Text.Json.Serialization;

namespace Client.Model
{
    public class AdoptionRequest
    {
        [JsonPropertyName("requestId")] 
        public int RequestId { get;  }
        [JsonPropertyName("date")]
        public DateTime DateTime { get; set; }
        [JsonPropertyName("animalId")]
        public Animal AnimalId { get; set; }
        [JsonPropertyName("userId")]
        public PetOwner UserId { get; set; }
        [JsonPropertyName("veterinarianId")]
        public Veterinarian VeterinarianId { get; set; }
        [JsonPropertyName("approve")]
        public bool Approve { get; set; }

    }
}