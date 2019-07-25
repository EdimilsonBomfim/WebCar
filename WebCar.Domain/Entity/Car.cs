using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebCar.Domain.Entity
{
   public class Car
    {

        //Construtor repository - nao tem retorno
        public Car(string marca, string modelo, string ano)
        {

        this.Marca = marca;
                       
        this.Modelo = modelo;
        this.Ano = ano;
        }
                
        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Modelo { get; set; }

        [Required]
        [MaxLength(2)]
        [MinLength(1)]
        public string Ano { get; set; }
    

    }
}
