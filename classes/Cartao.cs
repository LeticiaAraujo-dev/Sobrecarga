namespace Sobrecarga.classes
{
    public class Cartao
    {
            public int Numero { get; set; }
        
        private string bandeira = "Mastercard";

        protected string token = "qwertyui";
        public string Cvv { get; set; }
        protected float limite = 5000;

        public float Limite{
            get{return limite;}
        }


        public bool ValidarCompra(float valor){
            if(valor > limite){
                return false; 
            }else{
                return true;
            }
            }



        public string RegistarCompra(bool ValidarCompra){
            if(ValidarCompra == true){
                return "Compra realizada com sucesso";
            }else{
                return "Ocorreu um erro durante a compra";
            }
        }

    }

    

}
         
