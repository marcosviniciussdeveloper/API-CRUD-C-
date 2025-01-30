﻿namespace ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

    public class PersonModel
    {

        public PersonModel(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; init; }
        public string Name { get; private set; } = string.Empty;

        public void ChangenName (string name)
        {
            Name = name;
        }

        public void SetInactive()
        {

            Name = "Desativado";
        }
    }

