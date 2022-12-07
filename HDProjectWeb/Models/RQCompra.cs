﻿using System.ComponentModel.DataAnnotations;

namespace HDProjectWeb.Models
{
    public class RQCompra
    {
        //Model for register
        [Required(ErrorMessage = "Campo obligatorio")]//Campo Requerido
        [MaxLength(2, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Cia_codcia { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//Campo Requerido
        [MaxLength(2, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Suc_codsuc { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//Campo Requerido
        [MaxLength(10, ErrorMessage = "El campo no debe de tener mas de 10 caracteres")]
        public string Rco_numrco { get; set; }         /***View****/
        public DateTime Rco_fec_registro { get; set; } /***View****/

        [Required(ErrorMessage = "Campo obligatorio")]//Campo Requerido
        [MaxLength(2, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Tin_codtin { get; set; } /***Vacio****/

        [Required(ErrorMessage = "Campo obligatorio")]//Campo Requerido
        [MaxLength(6, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Cco_codcco { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//Campo Requerido
        [MaxLength(200, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Rco_motivo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(2, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Adi_codadi { get; set; }  /***Vacio****/

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracter")]
        public string Rco_sitrco { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracter")]
        public string Rco_sitlog { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(4, ErrorMessage = "El campo no debe de tener mas de 4 caracteres")]
        public string Ano_codano { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(2, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Mes_codmes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracter")]
        public string Rco_indest { get; set; }        /***View****/


        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(30, ErrorMessage = "El campo no debe de tener mas de 30 caracteres")]
        public string Rco_usucre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] 
        [MaxLength(30, ErrorMessage = "El campo no debe de tener mas de 30 caracteres")]
        public string S10_usuario { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(30, ErrorMessage = "El campo no debe de tener mas de 30 caracteres")]
        public string Rco_codusu { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(2, ErrorMessage = "El campo no debe de tener mas de 2 caracteres")]
        public string Ung_codung { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        public short Rco_indcie { get; set; }

        [MaxLength(200, ErrorMessage = "El campo no debe de tener mas de 200 caracteres")]
        public string Rco_obscie { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        public short Rco_indval { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracteres")]
        public string Rco_rembls { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracteres")]
        public string Rco_presup { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracteres")]
        public string Rco_priori { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] //Campo Requerido
        [MaxLength(1, ErrorMessage = "El campo no debe de tener mas de 1 caracteres")]

        public string Rco_tiprco { get; set; }



    }
}