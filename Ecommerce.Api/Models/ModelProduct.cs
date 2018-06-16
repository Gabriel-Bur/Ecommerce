using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Api.Models
{
    public class ModelProduct
    {

        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage="Informe o codigo do produto")]
        [MaxLength(10,ErrorMessage = "Digite um codigo referente ao produto que possua exatamente 10 digitos")]
        [MinLength(10,ErrorMessage = "Digite um codigo referente ao produto que possua exatamente 10 digitos")]
        public string ProductCode { get; set; }



        [Required(ErrorMessage = "Informe o nome do produto")]
        [MaxLength(100, ErrorMessage = "O nome do produto deve conter no máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "O nome do produto deve conter no mínimo 2 caracteres")]
        public string ProductName { get; set; }



        [Required(ErrorMessage = "Informe uma descrição do produto")]
        [MaxLength(100, ErrorMessage = "A descrição do produto deve conter no máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "A descrição do produto deve conter no mínimo 2 caracteres")]
        public string ProductDescription { get; set; }



        [Required(ErrorMessage = "Informe uma categoria do produto")]
        [MaxLength(100, ErrorMessage = "A categoria do produto deve conter no máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "A categoria do produto deve conter no mínimo 2 caracteres")]
        public string ProductCategory { get; set; }


        [Required(ErrorMessage = "Informe a URL de uma imagem referente ao produto")]
        [MaxLength(2000, ErrorMessage = "URL não é valido")]
        [DataType(DataType.ImageUrl)]
        public string ProductImageURL { get; set; }


        [Required(ErrorMessage = "Informe o preço do produto")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","99999")]
        public decimal ProductPrice { get; set; }


        [Required(ErrorMessage = "Informe a marca do produto")]
        [MaxLength(100, ErrorMessage = "A marca do produto deve conter no máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "A marca do produto deve conter no mínimo 2 caracteres")]
        public string ProductBrand { get; set; }

    }
}