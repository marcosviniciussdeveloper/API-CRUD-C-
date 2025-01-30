namespace ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

    public class PersonModel
    {

        public PersonModel(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            Isactive = true;
        }
        public Guid Id { get; init; }
        public string Name { get; private set; } = string.Empty;
        
        public bool Isactive { get; private set; }  
        
        public void ChangenName (string name)
        {
            Name = name;
        }

        public void SetInactive()
        {

            Isactive = false;
        }
    }

